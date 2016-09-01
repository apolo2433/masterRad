namespace ORISkocko
{
    partial class DialogOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogOptions));
            this.lblBrojJedinki = new System.Windows.Forms.Label();
            this.lblBrojZnakova = new System.Windows.Forms.Label();
            this.cmbNumberOfRows = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbPopulationSize = new System.Windows.Forms.ComboBox();
            this.lblBrojIteracija = new System.Windows.Forms.Label();
            this.cmbNumberOfIterations = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNumberOfSignsInCombination = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblBrojJedinki
            // 
            this.lblBrojJedinki.AutoSize = true;
            this.lblBrojJedinki.Location = new System.Drawing.Point(32, 23);
            this.lblBrojJedinki.Name = "lblBrojJedinki";
            this.lblBrojJedinki.Size = new System.Drawing.Size(129, 17);
            this.lblBrojJedinki.TabIndex = 3;
            this.lblBrojJedinki.Text = "Velicina populacije:";
            // 
            // lblBrojZnakova
            // 
            this.lblBrojZnakova.AutoSize = true;
            this.lblBrojZnakova.Location = new System.Drawing.Point(32, 205);
            this.lblBrojZnakova.Name = "lblBrojZnakova";
            this.lblBrojZnakova.Size = new System.Drawing.Size(183, 17);
            this.lblBrojZnakova.TabIndex = 4;
            this.lblBrojZnakova.Text = "Broj znakova u kombinaciji :";
            // 
            // cmbNumberOfRows
            // 
            this.cmbNumberOfRows.DisplayMember = "7";
            this.cmbNumberOfRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumberOfRows.FormattingEnabled = true;
            this.cmbNumberOfRows.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbNumberOfRows.Location = new System.Drawing.Point(263, 132);
            this.cmbNumberOfRows.Name = "cmbNumberOfRows";
            this.cmbNumberOfRows.Size = new System.Drawing.Size(83, 24);
            this.cmbNumberOfRows.TabIndex = 5;
            this.cmbNumberOfRows.SelectedIndexChanged += new System.EventHandler(this.cmbBrRedova_SelectedIndexChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(160, 268);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(90, 32);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Prihvati";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnPrihvati_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(256, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cmbPopulationSize
            // 
            this.cmbPopulationSize.DisplayMember = "7";
            this.cmbPopulationSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPopulationSize.FormattingEnabled = true;
            this.cmbPopulationSize.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.cmbPopulationSize.Location = new System.Drawing.Point(263, 23);
            this.cmbPopulationSize.Name = "cmbPopulationSize";
            this.cmbPopulationSize.Size = new System.Drawing.Size(83, 24);
            this.cmbPopulationSize.TabIndex = 8;
            // 
            // lblBrojIteracija
            // 
            this.lblBrojIteracija.AutoSize = true;
            this.lblBrojIteracija.Location = new System.Drawing.Point(32, 82);
            this.lblBrojIteracija.Name = "lblBrojIteracija";
            this.lblBrojIteracija.Size = new System.Drawing.Size(90, 17);
            this.lblBrojIteracija.TabIndex = 9;
            this.lblBrojIteracija.Text = "Broj iteracija:";
            // 
            // cmbNumberOfIterations
            // 
            this.cmbNumberOfIterations.DisplayMember = "7";
            this.cmbNumberOfIterations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumberOfIterations.FormattingEnabled = true;
            this.cmbNumberOfIterations.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "50",
            "100",
            "200",
            "500"});
            this.cmbNumberOfIterations.Location = new System.Drawing.Point(263, 75);
            this.cmbNumberOfIterations.Name = "cmbNumberOfIterations";
            this.cmbNumberOfIterations.Size = new System.Drawing.Size(83, 24);
            this.cmbNumberOfIterations.TabIndex = 10;
            this.cmbNumberOfIterations.SelectedIndexChanged += new System.EventHandler(this.cmbBrojIteracija_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Broj redova za pogađanje :";
            // 
            // cmbNumberOfSignsInCombination
            // 
            this.cmbNumberOfSignsInCombination.DisplayMember = "7";
            this.cmbNumberOfSignsInCombination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumberOfSignsInCombination.FormattingEnabled = true;
            this.cmbNumberOfSignsInCombination.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbNumberOfSignsInCombination.Location = new System.Drawing.Point(263, 198);
            this.cmbNumberOfSignsInCombination.Name = "cmbNumberOfSignsInCombination";
            this.cmbNumberOfSignsInCombination.Size = new System.Drawing.Size(83, 24);
            this.cmbNumberOfSignsInCombination.TabIndex = 12;
            // 
            // DialogOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 325);
            this.Controls.Add(this.cmbNumberOfSignsInCombination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNumberOfIterations);
            this.Controls.Add(this.lblBrojIteracija);
            this.Controls.Add(this.cmbPopulationSize);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cmbNumberOfRows);
            this.Controls.Add(this.lblBrojZnakova);
            this.Controls.Add(this.lblBrojJedinki);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DialogOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opcije";
            this.Load += new System.EventHandler(this.DijalogOpcije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBrojJedinki;
        private System.Windows.Forms.Label lblBrojZnakova;
        private System.Windows.Forms.ComboBox cmbNumberOfRows;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbPopulationSize;
        private System.Windows.Forms.Label lblBrojIteracija;
        private System.Windows.Forms.ComboBox cmbNumberOfIterations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNumberOfSignsInCombination;
    }
}