using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ORISkocko.Controllers;
using ORISkocko.View;

namespace ORISkocko
{
    public partial class FitnessPanel : UserControl,IView
    {
        IUtilityController controller;
        private float averageFitness = 0.0f;
        private float fitnessOfBestIndividual = 0.0f;
        private string labelType;

        public string LabelType
        {
            get { return labelType; }
            set { labelType = value; }
        }

        public FitnessPanel()
        {
            InitializeComponent();
        }

        public float AverageFitness
        {
            get { return averageFitness; }
            set { averageFitness = value; }
        }

        public float FitnessOfBestIndividual
        {
            get { return fitnessOfBestIndividual; }
            set { fitnessOfBestIndividual = value; }
        }

        public void Draw(PaintEventArgs e)
        {
            OnPaint(e);
          
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (labelType == "default")
            {
                lblAverageFitness.Text = "prosečna \nprilagodjenost";
                lblFitnessOfBestIndividual.Text = "prilagodjenost \nnajboljeg";
                lblAverageFitness.Location = new Point(Width / 4 - lblAverageFitness.Width / 2, 0);
                lblFitnessOfBestIndividual.Location = new Point(Width / 4 * 3 - lblFitnessOfBestIndividual.Width / 2, 0);
            }

            else if (labelType == "value")
            {
                lblAverageFitness.Text = Math.Round(averageFitness,2).ToString();
                lblFitnessOfBestIndividual.Text = Math.Round(fitnessOfBestIndividual,2).ToString();
                lblAverageFitness.Location = new Point(Width / 4 - lblAverageFitness.Width / 2, 0);
                lblFitnessOfBestIndividual.Location = new Point(Width / 4 * 3 - lblFitnessOfBestIndividual.Width / 2 + 10, 0);

            }
            Height = lblAverageFitness.Height + 5; 
        }

        public void setController(IUtilityController cont)
        {
            controller = cont;
        }
    }
}