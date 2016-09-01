using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ORISkocko.Genetski_Algoritam;
using ORISkocko.Controllers;
using ORISkocko.View;

namespace ORISkocko
{
    public partial class TablePanel : UserControl,IView
    {
        IUtilityController controller;
        public CombinationPanel[] combinationPanels;
        public FeedbackPanel[] feedbackPanels;
        public FitnessPanel[] fitnessPanels;

        public TablePanel()
        {
            InitializeComponent();
        }

        public void initializeTablePanel()
        {

            int numberOfRowsForGuessing = controller.GetNumberOfRowsForGuessng();
            int numberOfSignsInCombination = controller.GetNumberOfSignsInCombination();
            float averageFitness = controller.GetAverageFitnessOfGeneration();
            float fitnessOfBestIndividual = controller.GetFitnessOfBestFitedIndividual();
            this.Controls.Clear();
            combinationPanels = new CombinationPanel[numberOfRowsForGuessing];
            feedbackPanels = new FeedbackPanel[numberOfRowsForGuessing];
            fitnessPanels = new FitnessPanel[numberOfRowsForGuessing];
            
            for (int i = 0; i < numberOfRowsForGuessing; i++)
            {
                combinationPanels[i] = new CombinationPanel();
                combinationPanels[i].Location = new Point(20, i * (32 + 10));
                combinationPanels[i].Width = (numberOfSignsInCombination + 1) * (32 + 10);
                combinationPanels[i].setController(controller);
                combinationPanels[i].initializeCombinationPanel();
                this.Controls.Add(combinationPanels[i]);
                feedbackPanels[i] = new FeedbackPanel();
                feedbackPanels[i].Location = new Point(combinationPanels[i].Location.X + combinationPanels[i].Width, combinationPanels[i].Location.Y + 8);
                feedbackPanels[i].Width = (numberOfSignsInCombination + 1) * (16 + 5);              
                feedbackPanels[i].setController(controller);
                feedbackPanels[i].initializeFeedbackPanel();
                this.Controls.Add(feedbackPanels[i]);

                if (i > 0)
                {               
                    fitnessPanels[i] = new FitnessPanel();
                    fitnessPanels[i].LabelType = "value";
                    fitnessPanels[i].Location = new Point(feedbackPanels[i].Location.X + feedbackPanels[i].Width, combinationPanels[i].Location.Y + 8);
                    fitnessPanels[i].AverageFitness = 0;
                    fitnessPanels[i].FitnessOfBestIndividual = 0;
                    fitnessPanels[i].Width = 250;
                    fitnessPanels[i].setController(controller);                                     
                    this.Controls.Add(fitnessPanels[i]);
                }

                else if (i==0)
                {                   
                    fitnessPanels[i] = new FitnessPanel();
                    fitnessPanels[i].LabelType = "default";
                    fitnessPanels[i].Location = new Point(feedbackPanels[i].Location.X + feedbackPanels[i].Width, combinationPanels[i].Location.Y + 8);                 
                    fitnessPanels[i].Width = 250;
                    this.Controls.Add(fitnessPanels[i]);
                }
            }

            this.Height = numberOfRowsForGuessing * (32 + 10) + 10;
            this.Width = fitnessPanels[0].Location.X + fitnessPanels[0].Width+ 20;

        }

        protected override void OnPaint(PaintEventArgs e) 
        {
            int currentRow = controller.GetCurrentRow();
            int numberOfRowsForGuessing = controller.GetNumberOfRowsForGuessng();
            base.OnPaint(e);
            Graphics gr = e.Graphics;
            if (currentRow < numberOfRowsForGuessing)
            {
                gr.FillEllipse(new SolidBrush(Color.Black), 0, currentRow * (32 + 10) + 10, 10, 10); //oznaka trenutnog reda
            }
        }
        public void addSign(int sign)
        {

            int ordinalNumberOfSign = controller.GetOrdinalNumberOfSign();
            int currentRow = controller.GetCurrentRow();
            if (ordinalNumberOfSign < controller.GetNumberOfSignsInCombination())
            {
                controller.AddSignIntoTableGuessing(sign);
                combinationPanels[currentRow].Fields = controller.GetCurrentRowFromTableOfGuessing() ;
                combinationPanels[currentRow].Invalidate();
            }

        }

        public void updatePointer()
        {
            Rectangle rec = new Rectangle(0, 0, 12, this.Height);
            Invalidate(rec);
        }

        public void undo() //uklanjanje poslednjeg znaka iz polja
        {
            
            int currentRow = controller.GetCurrentRow();
            if (controller.GetOrdinalNumberOfSign() > 0)
            {
                controller.RemoveSignFromTableGuessing();
                combinationPanels[currentRow].Fields = controller.GetCurrentRowFromTableOfGuessing();
                combinationPanels[currentRow].Invalidate();
            }
        }

        public void checkCurrentCombinationWithMainSolution()  
        {

            int ordinalNumberOfSign = controller.GetOrdinalNumberOfSign();
            int numberOfSignsInCombination = controller.GetNumberOfSignsInCombination();
            int currentRow = controller.GetCurrentRow();
            float averageFitness = controller.GetAverageFitnessOfGeneration();
            float fitnessOfBestIndividual = controller.GetFitnessOfBestFitedIndividual();

            if (ordinalNumberOfSign == numberOfSignsInCombination)
            { 
                controller.CheckCurrentCombinationWithMainSolution();
                feedbackPanels[currentRow].Fields = controller.GetCurrentRowFromTableResoults();
                controller.CheckIfSolutionIsFound();

                if (currentRow > 0) { 
                fitnessPanels[currentRow].AverageFitness = averageFitness;
                fitnessPanels[currentRow].FitnessOfBestIndividual = fitnessOfBestIndividual;
                fitnessPanels[currentRow].LabelType = "value";
                }   

                combinationPanels[currentRow].Invalidate();
                feedbackPanels[currentRow].Invalidate(); 
                fitnessPanels[currentRow].Invalidate();

                currentRow++;

                controller.SetCurrentRow(currentRow);
                controller.SetOrdinalNumberOfSign(0);

            }
        }

        public int[] returnFeedback(int row)
        {
            return feedbackPanels[row].Fields;
        }

        public void CumputerGuess()
        {
            int currentRow = controller.GetCurrentRow();       
            controller.FindBestIndividualForNextRow();
            controller.SetOrdinalNumberOfSign(controller.GetNumberOfSignsInCombination());
            combinationPanels[currentRow].Fields = controller.GetCurrentRowFromTableOfGuessing();
            checkCurrentCombinationWithMainSolution();

        }

        public void updateFitnessPanels()
        {
            for (int i = 1; i < controller.GetCurrentRow(); i++) { 

            fitnessPanels[i].AverageFitness = controller.GetAllPopulations()[i].AverageFitness;
            fitnessPanels[i].FitnessOfBestIndividual = controller.GetAllPopulations()[i].FitnessOfBestIndividual;
            fitnessPanels[i].LabelType = "value";
                fitnessPanels[i].Invalidate();
        }
        }

        public void setController(IUtilityController cont)
        {
            controller = cont;
        }

        private void TablePanel_Load(object sender, EventArgs e)
        {

        }
    }
}
