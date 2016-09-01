using System;
using System.ComponentModel;

namespace ORISkocko
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelChoice = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSign1 = new System.Windows.Forms.Button();
            this.buttonSign2 = new System.Windows.Forms.Button();
            this.buttonSign3 = new System.Windows.Forms.Button();
            this.buttonSign4 = new System.Windows.Forms.Button();
            this.buttonSign5 = new System.Windows.Forms.Button();
            this.buttonSign6 = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnComp = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalanRežimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izazoviKompjuteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.podešavanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pravilaIgreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRegime = new System.Windows.Forms.Label();
            this.checkBoxSolution = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lblNumberOfIteration = new System.Windows.Forms.Label();
            this.btnUpdateFitness = new System.Windows.Forms.Button();
            this.solutionPanel = new ORISkocko.CombinationPanel();
            this.tablePanel = new ORISkocko.TablePanel();
            this.panelChoice.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChoice
            // 
            this.panelChoice.BackColor = System.Drawing.Color.ForestGreen;
            this.panelChoice.Controls.Add(this.buttonSign1);
            this.panelChoice.Controls.Add(this.buttonSign2);
            this.panelChoice.Controls.Add(this.buttonSign3);
            this.panelChoice.Controls.Add(this.buttonSign4);
            this.panelChoice.Controls.Add(this.buttonSign5);
            this.panelChoice.Controls.Add(this.buttonSign6);
            this.panelChoice.Controls.Add(this.btnUndo);
            this.panelChoice.Controls.Add(this.btnCheck);
            this.panelChoice.Controls.Add(this.btnComp);
            this.panelChoice.Location = new System.Drawing.Point(36, 296);
            this.panelChoice.Margin = new System.Windows.Forms.Padding(4);
            this.panelChoice.Name = "panelChoice";
            this.panelChoice.Size = new System.Drawing.Size(678, 84);
            this.panelChoice.TabIndex = 1;
            // 
            // buttonSign1
            // 
            this.buttonSign1.BackColor = System.Drawing.Color.Red;
            this.buttonSign1.BackgroundImage = global::ORISkocko.Properties.Resources.pik;
            this.buttonSign1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSign1.Location = new System.Drawing.Point(4, 4);
            this.buttonSign1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSign1.Name = "buttonSign1";
            this.buttonSign1.Size = new System.Drawing.Size(43, 39);
            this.buttonSign1.TabIndex = 0;
            this.buttonSign1.UseVisualStyleBackColor = false;
            this.buttonSign1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSign2
            // 
            this.buttonSign2.BackColor = System.Drawing.Color.Blue;
            this.buttonSign2.BackgroundImage = global::ORISkocko.Properties.Resources.karo;
            this.buttonSign2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSign2.Location = new System.Drawing.Point(55, 4);
            this.buttonSign2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSign2.Name = "buttonSign2";
            this.buttonSign2.Size = new System.Drawing.Size(43, 39);
            this.buttonSign2.TabIndex = 1;
            this.buttonSign2.UseVisualStyleBackColor = false;
            this.buttonSign2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSign3
            // 
            this.buttonSign3.BackColor = System.Drawing.Color.Green;
            this.buttonSign3.BackgroundImage = global::ORISkocko.Properties.Resources.tref;
            this.buttonSign3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSign3.Location = new System.Drawing.Point(106, 4);
            this.buttonSign3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSign3.Name = "buttonSign3";
            this.buttonSign3.Size = new System.Drawing.Size(43, 39);
            this.buttonSign3.TabIndex = 2;
            this.buttonSign3.UseVisualStyleBackColor = false;
            this.buttonSign3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSign4
            // 
            this.buttonSign4.BackColor = System.Drawing.Color.Yellow;
            this.buttonSign4.BackgroundImage = global::ORISkocko.Properties.Resources.herc;
            this.buttonSign4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSign4.Location = new System.Drawing.Point(157, 4);
            this.buttonSign4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSign4.Name = "buttonSign4";
            this.buttonSign4.Size = new System.Drawing.Size(43, 39);
            this.buttonSign4.TabIndex = 3;
            this.buttonSign4.UseVisualStyleBackColor = false;
            this.buttonSign4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonSign5
            // 
            this.buttonSign5.BackColor = System.Drawing.Color.Violet;
            this.buttonSign5.BackgroundImage = global::ORISkocko.Properties.Resources.skockoSlika;
            this.buttonSign5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSign5.Location = new System.Drawing.Point(208, 4);
            this.buttonSign5.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSign5.Name = "buttonSign5";
            this.buttonSign5.Size = new System.Drawing.Size(43, 39);
            this.buttonSign5.TabIndex = 4;
            this.buttonSign5.UseVisualStyleBackColor = false;
            this.buttonSign5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonSign6
            // 
            this.buttonSign6.BackColor = System.Drawing.Color.Teal;
            this.buttonSign6.BackgroundImage = global::ORISkocko.Properties.Resources.zvezda;
            this.buttonSign6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSign6.Location = new System.Drawing.Point(259, 4);
            this.buttonSign6.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSign6.Name = "buttonSign6";
            this.buttonSign6.Size = new System.Drawing.Size(43, 39);
            this.buttonSign6.TabIndex = 5;
            this.buttonSign6.UseVisualStyleBackColor = false;
            this.buttonSign6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(310, 4);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(100, 28);
            this.btnUndo.TabIndex = 6;
            this.btnUndo.Text = "Izbrisi jedno";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(418, 4);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 28);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Proveri";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnComp
            // 
            this.btnComp.Location = new System.Drawing.Point(525, 3);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(139, 29);
            this.btnComp.TabIndex = 9;
            this.btnComp.Text = "Kompjuter";
            this.btnComp.UseVisualStyleBackColor = true;
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(570, 400);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(114, 38);
            this.btnNewGame.TabIndex = 8;
            this.btnNewGame.Text = "Nova Igra";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNovaIgra_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.PaleGreen;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(28, 391);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcijeToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcijeToolStripMenuItem
            // 
            this.opcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalanRežimToolStripMenuItem,
            this.izazoviKompjuteraToolStripMenuItem,
            this.toolStripSeparator1,
            this.podešavanjaToolStripMenuItem,
            this.toolStripSeparator2,
            this.izlazToolStripMenuItem});
            this.opcijeToolStripMenuItem.Name = "opcijeToolStripMenuItem";
            this.opcijeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.opcijeToolStripMenuItem.Text = "Opcije";
            // 
            // normalanRežimToolStripMenuItem
            // 
            this.normalanRežimToolStripMenuItem.Name = "normalanRežimToolStripMenuItem";
            this.normalanRežimToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.normalanRežimToolStripMenuItem.Text = "Normalan režim";
            this.normalanRežimToolStripMenuItem.Click += new System.EventHandler(this.normalRegimeToolStripMenuItem_Click);
            // 
            // izazoviKompjuteraToolStripMenuItem
            // 
            this.izazoviKompjuteraToolStripMenuItem.Name = "izazoviKompjuteraToolStripMenuItem";
            this.izazoviKompjuteraToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.izazoviKompjuteraToolStripMenuItem.Text = "Izazovi kompjutera";
            this.izazoviKompjuteraToolStripMenuItem.Click += new System.EventHandler(this.challengeComputerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // podešavanjaToolStripMenuItem
            // 
            this.podešavanjaToolStripMenuItem.Name = "podešavanjaToolStripMenuItem";
            this.podešavanjaToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.podešavanjaToolStripMenuItem.Text = "Podešavanja";
            this.podešavanjaToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pravilaIgreToolStripMenuItem});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // pravilaIgreToolStripMenuItem
            // 
            this.pravilaIgreToolStripMenuItem.Name = "pravilaIgreToolStripMenuItem";
            this.pravilaIgreToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.pravilaIgreToolStripMenuItem.Text = "Pravila igre";
            this.pravilaIgreToolStripMenuItem.Click += new System.EventHandler(this.gameRulesToolStripMenuItem_Click);
            // 
            // lblRegime
            // 
            this.lblRegime.AutoSize = true;
            this.lblRegime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegime.Location = new System.Drawing.Point(523, 38);
            this.lblRegime.Name = "lblRegime";
            this.lblRegime.Size = new System.Drawing.Size(67, 20);
            this.lblRegime.TabIndex = 10;
            this.lblRegime.Text = "Rezim :";
            // 
            // checkBoxSolution
            // 
            this.checkBoxSolution.AutoSize = true;
            this.checkBoxSolution.Location = new System.Drawing.Point(561, 253);
            this.checkBoxSolution.Name = "checkBoxSolution";
            this.checkBoxSolution.Size = new System.Drawing.Size(123, 21);
            this.checkBoxSolution.TabIndex = 11;
            this.checkBoxSolution.Text = "Prikazi rešenje";
            this.checkBoxSolution.UseVisualStyleBackColor = true;
            this.checkBoxSolution.CheckedChanged += new System.EventHandler(this.checkBoxSolution_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.BackColor = System.Drawing.Color.PaleGreen;
            this.lblPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulation.Location = new System.Drawing.Point(28, 431);
            this.lblPopulation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(53, 20);
            this.lblPopulation.TabIndex = 12;
            this.lblPopulation.Text = "label1";
            // 
            // lblNumberOfIteration
            // 
            this.lblNumberOfIteration.AutoSize = true;
            this.lblNumberOfIteration.BackColor = System.Drawing.Color.PaleGreen;
            this.lblNumberOfIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfIteration.Location = new System.Drawing.Point(198, 431);
            this.lblNumberOfIteration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfIteration.Name = "lblNumberOfIteration";
            this.lblNumberOfIteration.Size = new System.Drawing.Size(53, 20);
            this.lblNumberOfIteration.TabIndex = 13;
            this.lblNumberOfIteration.Text = "label1";
            // 
            // btnUpdateFitness
            // 
            this.btnUpdateFitness.Location = new System.Drawing.Point(561, 205);
            this.btnUpdateFitness.Name = "btnUpdateFitness";
            this.btnUpdateFitness.Size = new System.Drawing.Size(139, 42);
            this.btnUpdateFitness.TabIndex = 14;
            this.btnUpdateFitness.Text = "Ažuriraj prilagođenost";
            this.btnUpdateFitness.UseVisualStyleBackColor = true;
            this.btnUpdateFitness.Click += new System.EventHandler(this.btnUpdateFitness_Click);
            // 
            // solutionPanel
            // 
            this.solutionPanel.Fields = new int[] {
        0,
        0,
        0,
        0};
            this.solutionPanel.Location = new System.Drawing.Point(525, 63);
            this.solutionPanel.Margin = new System.Windows.Forms.Padding(5);
            this.solutionPanel.Name = "solutionPanel";
            this.solutionPanel.Size = new System.Drawing.Size(210, 39);
            this.solutionPanel.TabIndex = 2;
            this.solutionPanel.Visible = false;
            // 
            // tablePanel
            // 
            this.tablePanel.Location = new System.Drawing.Point(15, 38);
            this.tablePanel.Margin = new System.Windows.Forms.Padding(5);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(500, 262);
            this.tablePanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(727, 474);
            this.Controls.Add(this.btnUpdateFitness);
            this.Controls.Add(this.lblNumberOfIteration);
            this.Controls.Add(this.lblPopulation);
            this.Controls.Add(this.checkBoxSolution);
            this.Controls.Add(this.lblRegime);
            this.Controls.Add(this.solutionPanel);
            this.Controls.Add(this.panelChoice);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skočko";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelChoice.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion

        private TablePanel tablePanel;
        private System.Windows.Forms.FlowLayoutPanel panelChoice;
        private System.Windows.Forms.Button buttonSign1;
        private System.Windows.Forms.Button buttonSign2;
        private System.Windows.Forms.Button buttonSign3;
        private System.Windows.Forms.Button buttonSign4;
        private System.Windows.Forms.Button buttonSign5;
        private System.Windows.Forms.Button buttonSign6;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnCheck;
        private CombinationPanel solutionPanel;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnComp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalanRežimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izazoviKompjuteraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem podešavanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pravilaIgreToolStripMenuItem;
        private System.Windows.Forms.Label lblRegime;
        private System.Windows.Forms.CheckBox checkBoxSolution;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Label lblNumberOfIteration;
        private System.Windows.Forms.Button btnUpdateFitness;
    }
}

