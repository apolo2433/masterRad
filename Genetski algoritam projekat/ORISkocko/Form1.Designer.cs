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
            ORISkocko.Genetski_Algoritam.GenetskiAlgoritam genetskiAlgoritam1 = new ORISkocko.Genetski_Algoritam.GenetskiAlgoritam();
            this.panelIzbor = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonZnak1 = new System.Windows.Forms.Button();
            this.buttonZnak2 = new System.Windows.Forms.Button();
            this.buttonZnak3 = new System.Windows.Forms.Button();
            this.buttonZnak4 = new System.Windows.Forms.Button();
            this.buttonZnak5 = new System.Windows.Forms.Button();
            this.buttonZnak6 = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnComp = new System.Windows.Forms.Button();
            this.btnNovaIgra = new System.Windows.Forms.Button();
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
            this.lblRezim = new System.Windows.Forms.Label();
            this.checkBoxResenje = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblPopulacija = new System.Windows.Forms.Label();
            this.lblBrojIteracija = new System.Windows.Forms.Label();
            this.poljaPanelResenje = new ORISkocko.PoljaPanel();
            this.superPanel1 = new ORISkocko.SuperPanel();
            this.panelIzbor.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIzbor
            // 
            this.panelIzbor.BackColor = System.Drawing.Color.ForestGreen;
            this.panelIzbor.Controls.Add(this.buttonZnak1);
            this.panelIzbor.Controls.Add(this.buttonZnak2);
            this.panelIzbor.Controls.Add(this.buttonZnak3);
            this.panelIzbor.Controls.Add(this.buttonZnak4);
            this.panelIzbor.Controls.Add(this.buttonZnak5);
            this.panelIzbor.Controls.Add(this.buttonZnak6);
            this.panelIzbor.Controls.Add(this.btnUndo);
            this.panelIzbor.Controls.Add(this.btnCheck);
            this.panelIzbor.Controls.Add(this.btnComp);
            this.panelIzbor.Location = new System.Drawing.Point(36, 296);
            this.panelIzbor.Margin = new System.Windows.Forms.Padding(4);
            this.panelIzbor.Name = "panelIzbor";
            this.panelIzbor.Size = new System.Drawing.Size(678, 84);
            this.panelIzbor.TabIndex = 1;
            // 
            // buttonZnak1
            // 
            this.buttonZnak1.BackColor = System.Drawing.Color.Red;
            this.buttonZnak1.BackgroundImage = global::ORISkocko.Properties.Resources.pik;
            this.buttonZnak1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZnak1.Location = new System.Drawing.Point(4, 4);
            this.buttonZnak1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZnak1.Name = "buttonZnak1";
            this.buttonZnak1.Size = new System.Drawing.Size(43, 39);
            this.buttonZnak1.TabIndex = 0;
            this.buttonZnak1.UseVisualStyleBackColor = false;
            this.buttonZnak1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonZnak2
            // 
            this.buttonZnak2.BackColor = System.Drawing.Color.Blue;
            this.buttonZnak2.BackgroundImage = global::ORISkocko.Properties.Resources.karo;
            this.buttonZnak2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZnak2.Location = new System.Drawing.Point(55, 4);
            this.buttonZnak2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZnak2.Name = "buttonZnak2";
            this.buttonZnak2.Size = new System.Drawing.Size(43, 39);
            this.buttonZnak2.TabIndex = 1;
            this.buttonZnak2.UseVisualStyleBackColor = false;
            this.buttonZnak2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonZnak3
            // 
            this.buttonZnak3.BackColor = System.Drawing.Color.Green;
            this.buttonZnak3.BackgroundImage = global::ORISkocko.Properties.Resources.tref;
            this.buttonZnak3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZnak3.Location = new System.Drawing.Point(106, 4);
            this.buttonZnak3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZnak3.Name = "buttonZnak3";
            this.buttonZnak3.Size = new System.Drawing.Size(43, 39);
            this.buttonZnak3.TabIndex = 2;
            this.buttonZnak3.UseVisualStyleBackColor = false;
            this.buttonZnak3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonZnak4
            // 
            this.buttonZnak4.BackColor = System.Drawing.Color.Yellow;
            this.buttonZnak4.BackgroundImage = global::ORISkocko.Properties.Resources.herc;
            this.buttonZnak4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZnak4.Location = new System.Drawing.Point(157, 4);
            this.buttonZnak4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZnak4.Name = "buttonZnak4";
            this.buttonZnak4.Size = new System.Drawing.Size(43, 39);
            this.buttonZnak4.TabIndex = 3;
            this.buttonZnak4.UseVisualStyleBackColor = false;
            this.buttonZnak4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonZnak5
            // 
            this.buttonZnak5.BackColor = System.Drawing.Color.Violet;
            this.buttonZnak5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonZnak5.BackgroundImage")));
            this.buttonZnak5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZnak5.Location = new System.Drawing.Point(208, 4);
            this.buttonZnak5.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZnak5.Name = "buttonZnak5";
            this.buttonZnak5.Size = new System.Drawing.Size(43, 39);
            this.buttonZnak5.TabIndex = 4;
            this.buttonZnak5.UseVisualStyleBackColor = false;
            this.buttonZnak5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonZnak6
            // 
            this.buttonZnak6.BackColor = System.Drawing.Color.Teal;
            this.buttonZnak6.BackgroundImage = global::ORISkocko.Properties.Resources.zvezda;
            this.buttonZnak6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZnak6.Location = new System.Drawing.Point(259, 4);
            this.buttonZnak6.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZnak6.Name = "buttonZnak6";
            this.buttonZnak6.Size = new System.Drawing.Size(43, 39);
            this.buttonZnak6.TabIndex = 5;
            this.buttonZnak6.UseVisualStyleBackColor = false;
            this.buttonZnak6.Click += new System.EventHandler(this.button6_Click);
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
            // btnNovaIgra
            // 
            this.btnNovaIgra.Location = new System.Drawing.Point(570, 400);
            this.btnNovaIgra.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovaIgra.Name = "btnNovaIgra";
            this.btnNovaIgra.Size = new System.Drawing.Size(114, 38);
            this.btnNovaIgra.TabIndex = 8;
            this.btnNovaIgra.Text = "Nova Igra";
            this.btnNovaIgra.UseVisualStyleBackColor = true;
            this.btnNovaIgra.Click += new System.EventHandler(this.btnNovaIgra_Click);
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
            this.normalanRežimToolStripMenuItem.Click += new System.EventHandler(this.normalanRežimToolStripMenuItem_Click);
            // 
            // izazoviKompjuteraToolStripMenuItem
            // 
            this.izazoviKompjuteraToolStripMenuItem.Name = "izazoviKompjuteraToolStripMenuItem";
            this.izazoviKompjuteraToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.izazoviKompjuteraToolStripMenuItem.Text = "Izazovi kompjutera";
            this.izazoviKompjuteraToolStripMenuItem.Click += new System.EventHandler(this.izazoviKompjuteraToolStripMenuItem_Click);
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
            this.podešavanjaToolStripMenuItem.Click += new System.EventHandler(this.podešavanjaToolStripMenuItem_Click);
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
            this.pravilaIgreToolStripMenuItem.Click += new System.EventHandler(this.pravilaIgreToolStripMenuItem_Click);
            // 
            // lblRezim
            // 
            this.lblRezim.AutoSize = true;
            this.lblRezim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezim.Location = new System.Drawing.Point(523, 38);
            this.lblRezim.Name = "lblRezim";
            this.lblRezim.Size = new System.Drawing.Size(67, 20);
            this.lblRezim.TabIndex = 10;
            this.lblRezim.Text = "Rezim :";
            // 
            // checkBoxResenje
            // 
            this.checkBoxResenje.AutoSize = true;
            this.checkBoxResenje.Location = new System.Drawing.Point(561, 253);
            this.checkBoxResenje.Name = "checkBoxResenje";
            this.checkBoxResenje.Size = new System.Drawing.Size(123, 21);
            this.checkBoxResenje.TabIndex = 11;
            this.checkBoxResenje.Text = "Prikazi rešenje";
            this.checkBoxResenje.UseVisualStyleBackColor = true;
            this.checkBoxResenje.CheckedChanged += new System.EventHandler(this.checkBoxResenje_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblPopulacija
            // 
            this.lblPopulacija.AutoSize = true;
            this.lblPopulacija.BackColor = System.Drawing.Color.PaleGreen;
            this.lblPopulacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulacija.Location = new System.Drawing.Point(28, 431);
            this.lblPopulacija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPopulacija.Name = "lblPopulacija";
            this.lblPopulacija.Size = new System.Drawing.Size(53, 20);
            this.lblPopulacija.TabIndex = 12;
            this.lblPopulacija.Text = "label1";
            // 
            // lblBrojIteracija
            // 
            this.lblBrojIteracija.AutoSize = true;
            this.lblBrojIteracija.BackColor = System.Drawing.Color.PaleGreen;
            this.lblBrojIteracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojIteracija.Location = new System.Drawing.Point(198, 431);
            this.lblBrojIteracija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrojIteracija.Name = "lblBrojIteracija";
            this.lblBrojIteracija.Size = new System.Drawing.Size(53, 20);
            this.lblBrojIteracija.TabIndex = 13;
            this.lblBrojIteracija.Text = "label1";
            // 
            // poljaPanelResenje
            // 
            this.poljaPanelResenje.BrojZnakovaUkombinaciji = 4;
            this.poljaPanelResenje.Location = new System.Drawing.Point(525, 63);
            this.poljaPanelResenje.Margin = new System.Windows.Forms.Padding(5);
            this.poljaPanelResenje.Name = "poljaPanelResenje";
            this.poljaPanelResenje.Size = new System.Drawing.Size(210, 39);
            this.poljaPanelResenje.TabIndex = 2;
            this.poljaPanelResenje.TrenutnaVrednost = 0;
            this.poljaPanelResenje.Visible = false;
            this.poljaPanelResenje.Vrednosti = new int[] {
        0,
        0,
        0,
        0};
            // 
            // superPanel1
            // 
            this.superPanel1.BrojRedova = 6;
            this.superPanel1.BrojZnakovaUkombinaciji = 6;
            genetskiAlgoritam1.BrojIteracija = 10;
            genetskiAlgoritam1.BrojZnakovaUkombinaciji = 4;
            genetskiAlgoritam1.VelicinaPopulacije = 500;
            this.superPanel1.Genetski = genetskiAlgoritam1;
            this.superPanel1.GlavnoResenje = null;
            this.superPanel1.Location = new System.Drawing.Point(15, 38);
            this.superPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.superPanel1.Name = "superPanel1";
            this.superPanel1.Reseno = false;
            this.superPanel1.Size = new System.Drawing.Size(500, 262);
            this.superPanel1.TabIndex = 0;
            this.superPanel1.TrenutnaVrednost = 0;
            this.superPanel1.TrenutniRed = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(727, 474);
            this.Controls.Add(this.lblBrojIteracija);
            this.Controls.Add(this.lblPopulacija);
            this.Controls.Add(this.checkBoxResenje);
            this.Controls.Add(this.lblRezim);
            this.Controls.Add(this.poljaPanelResenje);
            this.Controls.Add(this.panelIzbor);
            this.Controls.Add(this.superPanel1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnNovaIgra);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skočko";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelIzbor.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion

        private SuperPanel superPanel1;
        private System.Windows.Forms.FlowLayoutPanel panelIzbor;
        private System.Windows.Forms.Button buttonZnak1;
        private System.Windows.Forms.Button buttonZnak2;
        private System.Windows.Forms.Button buttonZnak3;
        private System.Windows.Forms.Button buttonZnak4;
        private System.Windows.Forms.Button buttonZnak5;
        private System.Windows.Forms.Button buttonZnak6;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnCheck;
        private PoljaPanel poljaPanelResenje;
        private System.Windows.Forms.Button btnNovaIgra;
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
        private System.Windows.Forms.Label lblRezim;
        private System.Windows.Forms.CheckBox checkBoxResenje;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblPopulacija;
        private System.Windows.Forms.Label lblBrojIteracija;
        
    }
}

