using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORISkocko
{
    public partial class ResenjePanel : UserControl
    {
        int brojZnakovaUkombinaciji = 4;
        int[] pogoci;

        public int BrojZnakovaUkombinaciji
        {
            get { return brojZnakovaUkombinaciji; }
            set { brojZnakovaUkombinaciji = value; }
        }
        public int[] Pogoci
        {
            get { return pogoci; }
            set { pogoci = value; }
        }

        public ResenjePanel()
        {
            InitializeComponent();

        }

        public ResenjePanel(int X, int Y)
        {

            Location = new Point(X, Y);
            InitializeComponent();
        }

        public void inicijalizujResenjaPanel()
        {
            pogoci = new int[brojZnakovaUkombinaciji];
            for (int i = 0; i < brojZnakovaUkombinaciji; i++)
                pogoci[i] = 0;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gr = e.Graphics;

            for (int i = 0; i < brojZnakovaUkombinaciji; i++)
            {
                Rectangle recElipsa = new Rectangle(i * (16 + 5), 0, 16, 16);

                Color color1 = Color.White;
                int trenutniPogodak = pogoci[i];
                switch (trenutniPogodak)
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

        public bool reseno()
        {
            bool retVal = true;
            for (int i = 0; i < brojZnakovaUkombinaciji; i++)
            {
                if (pogoci[i] != 2)
                    retVal = false;
            }
            return retVal;

        }

        private void ResenjePanel_Load(object sender, EventArgs e)
        {

        }

    }
}
