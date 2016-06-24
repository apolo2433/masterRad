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
    public partial class PoljaPanel : UserControl
    {
        public int brojZnakovaUkombinaciji = 4;
        int trenutnaVrednost = 0;
        int[] vrednosti;

        public int BrojZnakovaUkombinaciji
        {
            get { return brojZnakovaUkombinaciji; }
            set { brojZnakovaUkombinaciji = value; }
        }


        public int TrenutnaVrednost
        {
            get { return trenutnaVrednost; }
            set { trenutnaVrednost = value; }
        }

        public int[] Vrednosti
        {
            get { return vrednosti; }
            set { vrednosti = value; }
        }

        public PoljaPanel()
        {
            InitializeComponent();

        }

        public PoljaPanel(int X, int Y)
        {
            Location = new Point(X, Y);
            InitializeComponent();
        }

        public void inicijalizjPoljaPanel()
        {
            vrednosti = new int[brojZnakovaUkombinaciji];
            for (int i = 0; i < brojZnakovaUkombinaciji; i++)
                vrednosti[i] = 0;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gr = e.Graphics;
            int trenutnaVrednost = 0;
            int brojac = 0;
            Rectangle rec = this.ClientRectangle;
            for (int i = 0; i < brojZnakovaUkombinaciji; i++)
            {
                Rectangle r = new Rectangle(i * (32 + 10), 0, 32, 32);
                trenutnaVrednost = vrednosti[i];
                brojac++;
                Color color1 = Color.White;
                Image icon = Properties.Resources.prazno;
                switch (trenutnaVrednost)
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
                            icon = Properties.Resources.cd;
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




    }
}
