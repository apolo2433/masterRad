namespace ORISkocko
{
    partial class DijalogOpcije
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
            this.lblBrojJedinki = new System.Windows.Forms.Label();
            this.lblBrojZnakova = new System.Windows.Forms.Label();
            this.cmbBrRedova = new System.Windows.Forms.ComboBox();
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.cmbVelicinaPopulacije = new System.Windows.Forms.ComboBox();
            this.lblBrojIteracija = new System.Windows.Forms.Label();
            this.cmbBrojIteracija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBrojZnakova = new System.Windows.Forms.ComboBox();
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
            // cmbBrRedova
            // 
            this.cmbBrRedova.DisplayMember = "7";
            this.cmbBrRedova.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrRedova.FormattingEnabled = true;
            this.cmbBrRedova.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbBrRedova.Location = new System.Drawing.Point(263, 132);
            this.cmbBrRedova.Name = "cmbBrRedova";
            this.cmbBrRedova.Size = new System.Drawing.Size(83, 24);
            this.cmbBrRedova.TabIndex = 5;
            this.cmbBrRedova.SelectedIndexChanged += new System.EventHandler(this.cmbBrRedova_SelectedIndexChanged);
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.Location = new System.Drawing.Point(160, 268);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(90, 32);
            this.btnPrihvati.TabIndex = 6;
            this.btnPrihvati.Text = "Prihvati";
            this.btnPrihvati.UseVisualStyleBackColor = true;
            this.btnPrihvati.Click += new System.EventHandler(this.btnPrihvati_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(256, 268);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(90, 32);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cmbVelicinaPopulacije
            // 
            this.cmbVelicinaPopulacije.DisplayMember = "7";
            this.cmbVelicinaPopulacije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVelicinaPopulacije.FormattingEnabled = true;
            this.cmbVelicinaPopulacije.Items.AddRange(new object[] {
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
            this.cmbVelicinaPopulacije.Location = new System.Drawing.Point(263, 23);
            this.cmbVelicinaPopulacije.Name = "cmbVelicinaPopulacije";
            this.cmbVelicinaPopulacije.Size = new System.Drawing.Size(83, 24);
            this.cmbVelicinaPopulacije.TabIndex = 8;
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
            // cmbBrojIteracija
            // 
            this.cmbBrojIteracija.DisplayMember = "7";
            this.cmbBrojIteracija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrojIteracija.FormattingEnabled = true;
            this.cmbBrojIteracija.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "30",
            "50"});
            this.cmbBrojIteracija.Location = new System.Drawing.Point(263, 75);
            this.cmbBrojIteracija.Name = "cmbBrojIteracija";
            this.cmbBrojIteracija.Size = new System.Drawing.Size(83, 24);
            this.cmbBrojIteracija.TabIndex = 10;
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
            // cmbBrojZnakova
            // 
            this.cmbBrojZnakova.DisplayMember = "7";
            this.cmbBrojZnakova.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrojZnakova.FormattingEnabled = true;
            this.cmbBrojZnakova.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbBrojZnakova.Location = new System.Drawing.Point(263, 198);
            this.cmbBrojZnakova.Name = "cmbBrojZnakova";
            this.cmbBrojZnakova.Size = new System.Drawing.Size(83, 24);
            this.cmbBrojZnakova.TabIndex = 12;
            // 
            // DijalogOpcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 325);
            this.Controls.Add(this.cmbBrojZnakova);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBrojIteracija);
            this.Controls.Add(this.lblBrojIteracija);
            this.Controls.Add(this.cmbVelicinaPopulacije);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPrihvati);
            this.Controls.Add(this.cmbBrRedova);
            this.Controls.Add(this.lblBrojZnakova);
            this.Controls.Add(this.lblBrojJedinki);
            this.Name = "DijalogOpcije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opcije";
            this.Load += new System.EventHandler(this.DijalogOpcije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBrojJedinki;
        private System.Windows.Forms.Label lblBrojZnakova;
        private System.Windows.Forms.ComboBox cmbBrRedova;
        private System.Windows.Forms.Button btnPrihvati;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ComboBox cmbVelicinaPopulacije;
        private System.Windows.Forms.Label lblBrojIteracija;
        private System.Windows.Forms.ComboBox cmbBrojIteracija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBrojZnakova;
    }
}