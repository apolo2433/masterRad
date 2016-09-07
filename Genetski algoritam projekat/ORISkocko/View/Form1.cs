using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using ORISkocko.Controllers;
using ORISkocko.Genetski_Algoritam;
using ORISkocko.Model;
using ORISkocko.View;

namespace ORISkocko
{
    

    
    public partial class Form1 : Form, IView, IModelObserver
    {
        IUtilityController controller;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        public void initializeNormalRegime()
        {
            controller.InitializeTablesGuessingAndSolutions();
            btnCheck.Text = "Proveri";
            btnUndo.Text = "Izbrisi jedno";
            btnComp.Visible = true;
            btnComp.Enabled = true;
            btnComp.Text = "Kompjuter";
            Random random = new Random();
            int numberOfSignsInCombination = controller.GetNumberOfSignsInCombination();
            int [] mainSolution = new int [numberOfSignsInCombination];
           
            for (int i = 0; i < numberOfSignsInCombination; i++)
            {
                mainSolution[i] = random.Next(1, 7);
            }

            controller.SetMainSolution(mainSolution);

            checkBoxSolution.Visible = true;
            checkBoxSolution.Checked = false;
            checkBoxSolution.Enabled = true;
            lblStatus.Text = "Igra u toku. ";
            lblRegime.Text = "Rezim : Normalni";
            lblPopulation.Visible = false;
            lblNumberOfIteration.Visible = false;
            solutionPanel.Visible = false;
            initializeRegime();  
        }

        private void initializeChallengeRegime()
        {

            btnCheck.Text = "Izazovi";
            btnComp.Visible = true;
            btnComp.Enabled = true;
            btnComp.Text = "Generisi Kombinaciju";
            checkBoxSolution.Visible = false;
            checkBoxSolution.Enabled = true;
            int numberOfSignsInCombination = controller.GetNumberOfSignsInCombination();
            int[] mainSolution = new int[numberOfSignsInCombination];

            for (int i = 0; i < numberOfSignsInCombination; i++)
            {
                mainSolution[i] = 0;
            }
            controller.SetMainSolution(mainSolution);
            lblStatus.Text = "Unesite kombinaciju: ";
            lblRegime.Text = "Rezim : Izazovi";
            solutionPanel.Visible = true;
            lblPopulation.Visible = true;
            lblNumberOfIteration.Visible = true;
            initializeRegime();

        }

        private void initializeRegime()
        {
            solutionPanel.setController(controller);
            solutionPanel.initializeCombinationPanel();
            tablePanel.setController(controller);
            tablePanel.initializeTablePanel();
            buttonSign1.Enabled = true;
            buttonSign2.Enabled = true;
            buttonSign3.Enabled = true;
            buttonSign4.Enabled = true;
            buttonSign5.Enabled = true;
            buttonSign6.Enabled = true;
            btnUndo.Enabled = true;
            btnCheck.Enabled = false;
            btnComp.Width = 150;
            controller.SetOrdinalNumberOfSign(0);
            controller.SetCurrentRow(0);
            controller.InitializeTablesGuessingAndSolutions();
            controller.SetSolutionFound(false);
            updateTablePanel();
            initializeSolutionPanel();
            panelChoice.Location = new Point(tablePanel.Location.X + 16, tablePanel.Height + 40);
            panelChoice.Width = tablePanel.Width  + solutionPanel.Width;
           


            lblRegime.Location = new Point(solutionPanel.Location.X, tablePanel.Location.Y);
            lblStatus.Location = new Point(panelChoice.Location.X, panelChoice.Location.Y + panelChoice.Height + 10);
            lblPopulation.Location = new Point(lblStatus.Location.X, lblStatus.Location.Y + lblStatus.Height + 10);
            lblNumberOfIteration.Location = new Point(lblPopulation.Location.X + lblPopulation.Width + 50, lblPopulation.Location.Y);
            lblPopulation.Text = "Broj jedinki :" + controller.GetPopulationSize();
            lblNumberOfIteration.Text = "Broj iteracija :" + controller.GetNumberOfIterations();
            btnNewGame.Location = new Point(panelChoice.Location.X + panelChoice.Width - btnNewGame.Width, lblStatus.Location.Y);
            checkBoxSolution.Location = new Point(panelChoice.Location.X + panelChoice.Width - checkBoxSolution.Width, panelChoice.Location.Y - 30);
            btnUpdateFitness.Location = new Point(solutionPanel.Location.X, solutionPanel.Location.Y+ btnUpdateFitness.Height+10 );
            btnUpdateFitness.Visible = false;
            this.Height = tablePanel.Height + panelChoice.Height + 150;
            this.Width = panelChoice.Location.X + panelChoice.Width + 20;
            CenterToScreen();
            Invalidate();

        }

        private void updateTablePanel()
        {
            tablePanel.Location = new Point(20, 40);
            tablePanel.updatePointer();
            tablePanel.initializeTablePanel();
        }

        private void initializeSolutionPanel()
        {
            solutionPanel.Fields = controller.GetMainSolution();
            solutionPanel.Width = (controller.GetNumberOfSignsInCombination()) * (32 + 10);
            solutionPanel.Location = new Point(tablePanel.Location.X + tablePanel.Width, lblRegime.Location.Y + lblRegime.Height + 10);
            solutionPanel.Invalidate();
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            if (controller.GetRegime() == 1)
            {
                initializeNormalRegime();
            }
            else if (controller.GetRegime() == 2)
            {
                initializeChallengeRegime();
            }

            tablePanel.initializeTablePanel();
        }

        #region ProcessCmdKey

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.D1 && buttonSign1.Enabled)
            {
                addSign(1);
            }
            else if (keyData == Keys.D2 && buttonSign2.Enabled)
            {
                addSign(2);
            }
            else if (keyData == Keys.D3 && buttonSign3.Enabled)
            {
                addSign(3);
            }
            else if (keyData == Keys.D4 && buttonSign4.Enabled)
            {
                addSign(4);
            }
            else if (keyData == Keys.D5 && buttonSign5.Enabled)
            {
                addSign(5);
            }
            else if (keyData == Keys.D6 && buttonSign6.Enabled)
            {
                addSign(6);
            }
            else if (keyData == Keys.Back && btnUndo.Enabled)
            {
                tablePanel.undo();
                btnCheck.Enabled = false;
            }
            else if (keyData == Keys.Enter)
            {
                if (controller.GetRegime() == 1)
                {
                    if (btnCheck.Enabled)
                    {
                        tablePanel.checkCurrentCombinationWithMainSolution();
                        solutionPanel.Invalidate();
                        if (controller.GetCurrentRow() == controller.GetNumberOfRowsForGuessng() || controller.GetSolutionFound())
                        {

                            solutionPanel.Visible = true;
                            lblStatus.Text = "Nemate više poteza. Više sreće sledeći put.";
                            if (controller.GetSolutionFound())
                                lblStatus.Text = "Pobedili ste! ";
                            this.EndGame();
                        }
                        tablePanel.updatePointer();
                        btnCheck.Enabled = false;
                    }
                    else if (!buttonSign1.Enabled)
                    {
                        initializeNormalRegime();
                        tablePanel.initializeTablePanel();
                    }

                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion ProcessCmdKey

        private void addSign(int znak)
        {
            if (controller.GetRegime() == 1)
            {
                tablePanel.addSign(znak);
                if (controller.GetOrdinalNumberOfSign() == controller.GetNumberOfSignsInCombination())
                    btnCheck.Enabled = true;

            }
            else if (controller.GetRegime() == 2)
            {
                if (controller.GetOrdinalNumberOfSign() < controller.GetNumberOfSignsInCombination())
                {
                    controller.AddSignToSolution(znak);
                    solutionPanel.Fields = controller.GetMainSolution();
                    solutionPanel.Invalidate();
                    if (controller.GetOrdinalNumberOfSign() == controller.GetNumberOfSignsInCombination()) 
                        btnCheck.Enabled = true;
                }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            addSign(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addSign(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addSign(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addSign(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addSign(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addSign(6);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (controller.GetRegime() == 1)
            {
                tablePanel.undo();
                btnCheck.Enabled = false;
            }
            else if (controller.GetRegime() == 2)
            {
                    controller.RemoveSignFromSolution();
                    solutionPanel.Fields = controller.GetMainSolution();
                    btnCheck.Enabled = false;
                    solutionPanel.Invalidate();
                }
            }
        
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (controller.GetRegime() == 1)
            {
                tablePanel.checkCurrentCombinationWithMainSolution();
                //ako je kraj
                if (controller.GetCurrentRow() == controller.GetNumberOfRowsForGuessng() || controller.GetSolutionFound())
                {
                    solutionPanel.Visible = true;
                    lblStatus.Text = "Resenje nije nadjeno.";
                    if (controller.GetSolutionFound())
                        lblStatus.Text = "Resenje nadjeno!";

                    this.EndGame();
                }
                tablePanel.updatePointer();
                btnCheck.Enabled = false;
            }
            else if (controller.GetRegime() == 2)
            {
                if (!backgroundWorker1.IsBusy) 
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }

        private void EndGame()
        {
            buttonSign1.Enabled = false;
            buttonSign2.Enabled = false;
            buttonSign3.Enabled = false;
            buttonSign4.Enabled = false;
            buttonSign5.Enabled = false;
            buttonSign6.Enabled = false;
            btnUndo.Enabled = false;
            btnCheck.Enabled = false;
            btnComp.Enabled = false;
            checkBoxSolution.Enabled = false;
        }


        private void btnComp_Click(object sender, EventArgs e)
        {
            if (controller.GetRegime() == 1)
            {
                ComputerGuessOneRow();
                if (controller.GetCurrentRow() == controller.GetNumberOfRowsForGuessng() ||controller.GetSolutionFound())
                {
                    solutionPanel.Visible = true;
                    lblStatus.Text = "Resenje nije nadjeno.";
                    if (controller.GetSolutionFound())
                        lblStatus.Text = "Resenje nadjeno! ";

                    this.EndGame();
                }
                tablePanel.updatePointer();
            }
            else if (controller.GetRegime() == 2)  //generisanje kombinacije za pogadjanje
            {
                int[] mainSolution = new int[controller.GetNumberOfSignsInCombination()];
                Random random = new Random();
                initializeChallengeRegime();
                for (int i = 0; i < controller.GetNumberOfSignsInCombination(); i++)
                {
                    mainSolution[i] = random.Next(1, 7);
                }
                controller.SetMainSolution(mainSolution);
                controller.SetOrdinalNumberOfSign(controller.GetNumberOfSignsInCombination()); //
                solutionPanel.Fields = controller.GetMainSolution();
                solutionPanel.Invalidate();             
                btnCheck.Enabled = true;

            }
        }

        private void ComputerGuessOneRow() //pronalazenje resenja za jedan red
        {
            this.Cursor = Cursors.WaitCursor;
            btnComp.Enabled = false;
            controller.InitializeGeneration();
            tablePanel.CumputerGuess();
            this.Cursor = Cursors.Arrow;
            btnComp.Enabled = true;
        }

        private void ComputerGuessAsinc() 
        {
            tablePanel.CumputerGuess();
        }

        private void normalRegimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.SetRegime(1);
            initializeNormalRegime();

        }

        private void challengeComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.SetRegime(2);
            initializeChallengeRegime();

        }

        private void checkBoxSolution_CheckedChanged(object sender, EventArgs e)
        {
            solutionPanel.Visible = checkBoxSolution.Checked;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogOptions dialogOptions = new DialogOptions(controller.GetPopulationSize(), controller.GetNumberOfIterations(), controller.GetNumberOfRowsForGuessng(), controller.GetNumberOfSignsInCombination());
            if (dialogOptions.ShowDialog() == DialogResult.OK)
            {
               
                controller.SetNumberOfSignsInCombination(dialogOptions.NumberOfSignsInCombination);
                controller.SetNumberOfRowsForGuessng(dialogOptions.NumberOfRows);
                controller.SetPopulationSize(dialogOptions.PopulationSize);
                controller.SetNumberOfIterations(dialogOptions.NumberOfIterations);
                if (controller.GetRegime() == 1)
                {
                    initializeNormalRegime();
                }

                else if (controller.GetRegime() == 2)
                {

                    initializeChallengeRegime();
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            controller.SetRegime(1);
            initializeNormalRegime();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void gameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogRules dialogRules = new DialogRules();
            dialogRules.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker bw = sender as BackgroundWorker;

            controller.InitializeGeneration();
            while (controller.GetCurrentRow() <controller.GetNumberOfRowsForGuessng() && !controller.GetSolutionFound())
            {
                ComputerGuessAsinc();
            }

            backgroundWorker1.ReportProgress(100);

            if (bw.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            {
                if (e.Cancelled)
                {

                    MessageBox.Show("Operation was canceled");
                }
                else if (e.Error != null)
                {

                    string msg = String.Format("An error occurred: {0}", e.Error.Message);
                    MessageBox.Show(msg);
                }

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            solutionPanel.Visible = true;
            lblStatus.Text = "Resenje nije nadjeno.";
            if (controller.GetSolutionFound())
                lblStatus.Text = "Resenje nadjeno! ";
            this.EndGame();
            tablePanel.updatePointer();
            btnUpdateFitness.Visible = true;
        }

        public void setController(IUtilityController cont)
        {
            controller = cont;
        }

        public void valueIncremented(IUtility model, ModelEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnUpdateFitness_Click(object sender, EventArgs e)
        {
            controller.UpdateAverageFitnessOfAllPopulations();
            tablePanel.updateFitnessPanels();
        }
    }

    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);
   

    public class ViewEventArgs : EventArgs
    {
        public int value;
        public ViewEventArgs(int val)
        {
            value = val;
        }
    }
}
