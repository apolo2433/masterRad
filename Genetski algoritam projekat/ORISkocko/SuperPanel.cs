using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ORISkocko.Genetski_Algoritam;

namespace ORISkocko
{
    public partial class SuperPanel : UserControl
    {
        int brojRedova = 6;
        int trenutniRed = 0;
        int trenutnaVrednost = 0; //redni broj polja u panelu u koji ce se staviti znak
        int[] glavnoResenje; //resenje igre
        int[] najboljaJedinka;
        GenetskiAlgoritam genetskiAlgoritam;
        public PoljaPanel[] PoljaPaneli;
        public ResenjePanel[] ResenjePaneli;
        bool reseno = false;
        int brojZnakovaUkombinaciji = 4;
        int[] obradjenoResenje;
        int[] obradjeniPanel;
        int[] trenutnoResenje;

        public bool Reseno
        {
            get { return reseno; }
            set { reseno = value; }
        }

        public int BrojZnakovaUkombinaciji
        {
            get { return brojZnakovaUkombinaciji; }
            set { brojZnakovaUkombinaciji = value; }
        }


        public GenetskiAlgoritam Genetski
        {
            get { return genetskiAlgoritam; }
            set { genetskiAlgoritam = value; }
        }

        public int[] GlavnoResenje
        {
            get { return glavnoResenje; }
            set { glavnoResenje = value; }
        }


        public int TrenutnaVrednost
        {
            get { return trenutnaVrednost; }
            set { trenutnaVrednost = value; }
        }

        public int TrenutniRed
        {
            get { return trenutniRed; }
            set { trenutniRed = value; }
        }

        public int BrojRedova
        {
            get { return brojRedova; }
            set { brojRedova = value; }
        }


        public void inicijalizujSuperPanel()
        {

            trenutniRed = 0;
            trenutnaVrednost = 0;
            reseno = false;
            this.Controls.Clear();
            PoljaPaneli = new PoljaPanel[brojRedova];
            ResenjePaneli = new ResenjePanel[brojRedova];
            for (int i = 0; i < brojRedova; i++)
            {
                PoljaPaneli[i] = new PoljaPanel();
                PoljaPaneli[i].Location = new Point(20, i * (32 + 10));
                PoljaPaneli[i].Width = (brojZnakovaUkombinaciji + 1) * (32 + 10);
                PoljaPaneli[i].BrojZnakovaUkombinaciji = brojZnakovaUkombinaciji;
                PoljaPaneli[i].inicijalizjPoljaPanel();

                this.Controls.Add(PoljaPaneli[i]);

                ResenjePaneli[i] = new ResenjePanel();
                ResenjePaneli[i].Location = new Point(PoljaPaneli[i].Location.X + PoljaPaneli[i].Width, PoljaPaneli[i].Location.Y + 8);
                ResenjePaneli[i].Width = (brojZnakovaUkombinaciji + 1) * (16 + 5);
                ResenjePaneli[i].BrojZnakovaUkombinaciji = brojZnakovaUkombinaciji;
                ResenjePaneli[i].inicijalizujResenjaPanel();

                this.Controls.Add(ResenjePaneli[i]);
            }

            this.Height = brojRedova * (32 + 10) + 10;
            this.Width = PoljaPaneli[0].Width + ResenjePaneli[0].Width;
            this.Invalidate();

        }

        public SuperPanel()
        {
            GenetskiAlgoritam.SetSuperPanel(this);
            genetskiAlgoritam = new GenetskiAlgoritam();
            InitializeComponent();
            inicijalizujSuperPanel();

        }

        protected override void OnPaint(PaintEventArgs e) 
        {
            base.OnPaint(e);
            Graphics gr = e.Graphics;
            if (trenutniRed < brojRedova)
            {
                gr.FillEllipse(new SolidBrush(Color.Black), 0, trenutniRed * (32 + 10) + 10, 10, 10); //oznaka trenutnog reda


            }

        }

        public void dodajZnak(int znak)
        {

            if (trenutnaVrednost < brojZnakovaUkombinaciji)
            {
                PoljaPaneli[trenutniRed].Vrednosti[trenutnaVrednost] = znak;
                for (int i = trenutnaVrednost + 1; i < brojZnakovaUkombinaciji; i++)
                {
                    PoljaPaneli[trenutniRed].Vrednosti[i] = 0;

                }
                PoljaPaneli[trenutniRed].Invalidate();
                trenutnaVrednost++;
            }

        }

        public void updatePokazivac()
        {
            Rectangle rec = new Rectangle(0, 0, 12, this.Height);
            Invalidate(rec);

        }

        public void undo() //uklanjanje poslednjeg znaka iz polja
        {

            if (trenutnaVrednost > 0)
            {
                PoljaPaneli[trenutniRed].Vrednosti[trenutnaVrednost - 1] = 0;
                PoljaPaneli[trenutniRed].Invalidate();
                trenutnaVrednost--;

            }

        }

        public int[] poredjenjeJedinkeSaPrethodnimPokusajem(int[] jedinka, int red)  
        {

            obradjenoResenje = new int[brojZnakovaUkombinaciji];
            obradjeniPanel = new int[brojZnakovaUkombinaciji];
            trenutnoResenje = new int[brojZnakovaUkombinaciji];

            for (int i = 0; i < brojZnakovaUkombinaciji; i++)
            {
                obradjenoResenje[i] = 0;
                obradjeniPanel[i] = 0;
                trenutnoResenje[i] = 0;

            }

            int indexResenje = 0;
            bool nadjeno;
            //provera da li je pravi znak na pravom mestu
            for (int i = 0; i < PoljaPaneli[trenutniRed].BrojZnakovaUkombinaciji; i++)
            {
                if (jedinka[i] == PoljaPaneli[red].Vrednosti[i])
                {
                    trenutnoResenje[indexResenje] = 2;
                    obradjeniPanel[i] = 1;
                    obradjenoResenje[i] = 1;
                    indexResenje++;
                }

            }
            //provera da li je pravi znak na pogresnom mestu
            for (int i = 0; i < PoljaPaneli[trenutniRed].BrojZnakovaUkombinaciji; i++)
            {
                nadjeno = false;
                for (int j = 0; j < PoljaPaneli[trenutniRed].BrojZnakovaUkombinaciji && !nadjeno; j++)
                {
                    if (j != i && obradjeniPanel[i] == 0 && obradjenoResenje[j] == 0)
                    {
                        if (jedinka[i] == PoljaPaneli[red].Vrednosti[j])
                        {
                            trenutnoResenje[indexResenje] = 1;
                            obradjeniPanel[i] = 1;
                            obradjenoResenje[j] = 1;
                            nadjeno = true;
                            indexResenje++;
                        }


                    }


                }


            }

            return trenutnoResenje;

        }

        public void proveraTrenutneKombinacijeSaGlavnimResenjem()  
        {

            bool nadjeno;
            if (trenutnaVrednost == brojZnakovaUkombinaciji) 
            {
                obradjenoResenje = new int[brojZnakovaUkombinaciji];
                obradjeniPanel = new int[brojZnakovaUkombinaciji];
                trenutnoResenje = new int[brojZnakovaUkombinaciji];

                for (int i = 0; i < brojZnakovaUkombinaciji; i++)
                {
                    obradjenoResenje[i] = 0;
                    obradjeniPanel[i] = 0;
                    trenutnoResenje[i] = 0;

                }
                int indexResenje = 0;
                //provera da li je pravi znak na pravom mestu
                for (int i = 0; i < PoljaPaneli[trenutniRed].BrojZnakovaUkombinaciji; i++)
                {
                    if (PoljaPaneli[trenutniRed].Vrednosti[i] == glavnoResenje[i])
                    {
                        trenutnoResenje[indexResenje] = 2;
                        obradjeniPanel[i] = 1;
                        obradjenoResenje[i] = 1;
                        indexResenje++;
                    }

                }
                //provera da li je pravi znak na pogresnom mestu
                for (int i = 0; i < PoljaPaneli[trenutniRed].BrojZnakovaUkombinaciji; i++)
                {
                    nadjeno = false;
                    for (int j = 0; j < PoljaPaneli[trenutniRed].BrojZnakovaUkombinaciji && !nadjeno; j++)
                    {
                        if (j != i && obradjeniPanel[i] == 0 && obradjenoResenje[j] == 0)
                        {
                            if (PoljaPaneli[trenutniRed].Vrednosti[i] == glavnoResenje[j])
                            {
                                trenutnoResenje[indexResenje] = 1;
                                obradjeniPanel[i] = 1;
                                obradjenoResenje[j] = 1;
                                nadjeno = true;
                                indexResenje++;
                            }

                        }

                    }

                }

                for (int i = 0; i < ResenjePaneli[trenutniRed].BrojZnakovaUkombinaciji; i++)
                    ResenjePaneli[trenutniRed].Pogoci[i] = trenutnoResenje[i];

                ResenjePaneli[trenutniRed].Invalidate();
                PoljaPaneli[trenutniRed].Invalidate();


                if (ResenjePaneli[trenutniRed].reseno())
                {
                    reseno = true;
                }
                else
                {
                    trenutniRed++;
                    TrenutnaVrednost = 0;
                }
            }

        }

        public int[] vratiPogotke(int red)
        {
            return ResenjePaneli[red].Pogoci;
        }


        public void KompjuterPogadja()
        {

            najboljaJedinka = genetskiAlgoritam.pronadjiNajboljuJedinku();
            PoljaPaneli[trenutniRed].Vrednosti = najboljaJedinka;
            trenutnaVrednost = brojZnakovaUkombinaciji;
            proveraTrenutneKombinacijeSaGlavnimResenjem();
        }

        private void SuperPanel_Load(object sender, EventArgs e)
        {

        }

    }
}
