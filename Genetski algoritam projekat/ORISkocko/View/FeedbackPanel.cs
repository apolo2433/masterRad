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
    public partial class FeedbackPanel : UserControl,IView
    {
        IUtilityController controller;
        int[] fields;
     
      
        public int[] Fields
        {
            get { return fields; }
            set { fields = value; }
        }

        public FeedbackPanel()
        {
            InitializeComponent();
        }

        public FeedbackPanel(int X, int Y)
        {
            Location = new Point(X, Y);
            InitializeComponent();
        }

        public void initializeFeedbackPanel()
        {
            fields = new int[controller.GetNumberOfSignsInCombination()];
            for (int i = 0; i < controller.GetNumberOfSignsInCombination(); i++)
                fields[i] = 0;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gr = e.Graphics;
            for (int i = 0; i < controller.GetNumberOfSignsInCombination(); i++)
            {
                Rectangle recElipsa = new Rectangle(i * (16 + 5), 0, 16, 16);
                Color color1 = Color.White;
                int cuurentField = fields[i];
                switch (cuurentField)
                {
                    case 0:
                        {
                            color1 = Color.White;
                            break;
                        }
                    case 1:
                        {
                            color1 = Color.Yellow;
                            break;
                        }
                    case 2:
                        {
                            color1 = Color.Red;
                            break;
                        }
                }
                gr.FillEllipse(new SolidBrush(color1), recElipsa);
                gr.DrawEllipse(new Pen(Color.Black, 1), recElipsa);
            }
        }

        public void Draw(PaintEventArgs e)
        {
            OnPaint(e);
        }

        public void setController(IUtilityController cont)
        {
            controller = cont;
        }
    }
}
