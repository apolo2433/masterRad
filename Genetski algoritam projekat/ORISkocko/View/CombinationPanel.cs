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
    public partial class CombinationPanel : UserControl, IView
    {
        IUtilityController controller;
        int[] fields;


        public int[] Fields
        {
            get { return fields; }
            set { fields = value; }
        }

        public CombinationPanel()
        {
            InitializeComponent();
        }

        public CombinationPanel(int X, int Y)
        {
            Location = new Point(X, Y);
            InitializeComponent();
        }

        public void initializeCombinationPanel()
        {
            fields = new int[controller.GetNumberOfSignsInCombination()];
            for (int i = 0; i < controller.GetNumberOfSignsInCombination(); i++)
                fields[i] = 0;

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gr = e.Graphics;
            int currentField = 0;
           
            Rectangle rec = this.ClientRectangle;
            for (int i = 0; i < controller.GetNumberOfSignsInCombination(); i++)
            {
                Rectangle r = new Rectangle(i * (32 + 10), 0, 32, 32);
                currentField = fields[i];
                
                Color color1 = Color.White;
                Image icon = Properties.Resources.prazno;
                switch (currentField)
                {
                    case 0:
                        {
                            icon = Properties.Resources.prazno;
                            break;
                        }
                    case 1:
                        {
                            icon = Properties.Resources.pik;
                            break;
                        }
                    case 2:
                        {
                            icon = Properties.Resources.karo;
                            break;
                        }
                    case 3:
                        {
                            icon = Properties.Resources.tref;
                            break;
                        }
                    case 4:
                        {
                            icon = Properties.Resources.herc;
                            break;
                        }
                    case 5:
                        {
                            icon = Properties.Resources.skockoSlika;
                            break;
                        }
                    case 6:
                        {
                            icon = Properties.Resources.zvezda;
                            break;
                        }

                }
                gr.DrawImage(icon, r);
            }

        }

        public void Draw(PaintEventArgs e)
        {
            OnPaint(e);
        }

        private void PoljaPanel_Load(object sender, EventArgs e)
        {

        }

        public void setController(IUtilityController cont)
        {
            controller = cont;

        }
    }
}
