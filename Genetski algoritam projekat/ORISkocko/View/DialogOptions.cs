using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORISkocko
{
    public partial class DialogOptions : Form
    {

        int numberOfRows;
        int populationSize;
        int numberOfIterations;
        int numberOfSignsInCombination;

        public int NumberOfRows

        {
            get { return numberOfRows; }
            set { numberOfRows = value; }
        }

        public int NumberOfSignsInCombination
        {
            get { return numberOfSignsInCombination; }
            set { numberOfSignsInCombination = value; }
        }

        public int PopulationSize
        {
            get { return populationSize; }
            set { populationSize = value; }
        }

        public int NumberOfIterations
        {
            get { return numberOfIterations; }
            set { numberOfIterations = value; }
        }



      
        public DialogOptions(int populationSize,int numberOfIterations,int numberOfRows,int numberOfSignsInCombination
            )
        {
           

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.numberOfRows = numberOfRows;
            this.populationSize = populationSize;
            this.numberOfIterations = numberOfIterations;
            this.numberOfSignsInCombination = numberOfSignsInCombination;

            cmbNumberOfIterations.Text = this.numberOfIterations.ToString();
            cmbPopulationSize.Text = this.populationSize.ToString();
            cmbNumberOfRows.Text = this.numberOfRows.ToString();
            cmbNumberOfSignsInCombination.Text = numberOfSignsInCombination.ToString();
        }

        private void btnPrihvati_Click(object sender, EventArgs e)
        {
            numberOfRows = Convert.ToInt32(cmbNumberOfRows.SelectedItem);
            numberOfIterations= Convert.ToInt32(cmbNumberOfIterations.SelectedItem);
            populationSize = Convert.ToInt32(cmbPopulationSize.SelectedItem);
            numberOfSignsInCombination= Convert.ToInt32(cmbNumberOfSignsInCombination.SelectedItem);
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void DijalogOpcije_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbBrRedova_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBrojIteracija_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
