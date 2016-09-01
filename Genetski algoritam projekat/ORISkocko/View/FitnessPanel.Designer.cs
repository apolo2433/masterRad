namespace ORISkocko
{
    partial class FitnessPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAverageFitness = new System.Windows.Forms.Label();
            this.lblFitnessOfBestIndividual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProsecnaPrilagodjenost
            // 
            this.lblAverageFitness.AutoSize = true;
            this.lblAverageFitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageFitness.Location = new System.Drawing.Point(3, 10);
            this.lblAverageFitness.Name = "lblProsecnaPrilagodjenost";
            this.lblAverageFitness.Size = new System.Drawing.Size(53, 20);
            this.lblAverageFitness.TabIndex = 0;
            this.lblAverageFitness.Text = "label1";
            this.lblAverageFitness.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrilagodjenostNajbolje
            // 
            this.lblFitnessOfBestIndividual.AutoSize = true;
            this.lblFitnessOfBestIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFitnessOfBestIndividual.Location = new System.Drawing.Point(92, 10);
            this.lblFitnessOfBestIndividual.Name = "lblPrilagodjenostNajbolje";
            this.lblFitnessOfBestIndividual.Size = new System.Drawing.Size(53, 20);
            this.lblFitnessOfBestIndividual.TabIndex = 1;
            this.lblFitnessOfBestIndividual.Text = "label2";
            this.lblFitnessOfBestIndividual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PoljaLabelePrilagodjenosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFitnessOfBestIndividual);
            this.Controls.Add(this.lblAverageFitness);
            this.Name = "PoljaLabelePrilagodjenosti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAverageFitness;
        private System.Windows.Forms.Label lblFitnessOfBestIndividual;
    }
}
