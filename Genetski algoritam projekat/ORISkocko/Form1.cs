using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ORISkocko
{
    public partial class Form1 : Form
    {

        int[] glavnoResenje;
        int rezim = 1; // 1 - Normalan rezim, 2 - Rezim izazivanja kompjutera
        int trenutnaVrednost = 0;  // redni broj polja gde se dodaje znak
        int brojIteracija = 10;
        int brojJedinki = 500;
        int brojRedovaZaPogadjanje = 6;
        int brojZnakovaUkombinaciji = 4;

        public int BrojZnakovaUkombinaciji
        {
            get { return brojZnakovaUkombinaciji; }
            set { brojZnakovaUkombinaciji = value; }
        }

        public int BrojIteracija
        {
            get { return brojIteracija; }
            set { brojIteracija = value; }
        }


        public int BrojJedinki
        {
            get { return brojJedinki; }
            set { brojJedinki = value; }
        }

        public Form1()
        {
            InitializeComponent();
            inicijalizujNormalanRezim();

        }

        private void inicijalizujNormalanRezim()
        {

            btnCheck.Text = "Proveri";
            btnUndo.Text = "Izbrisi jedno";
            btnComp.Visible = true;
            btnComp.Enabled = true;
            btnComp.Text = "Kompjuter";
            glavnoResenje = new int [brojZnakovaUkombinaciji];
            Random random = new Random();
            for (int i = 0; i < brojZnakovaUkombinaciji; i++)
            {
                glavnoResenje[i] = random.Next(1, 7);
            }
            checkBoxResenje.Visible = true;
            checkBoxResenje.Checked = false;
            checkBoxResenje.Enabled = true;
            lblStatus.Text = "Igra u toku. ";
            lblRezim.Text = "Rezim : Normalni";
            lblPopulacija.Visible = false;
            lblBrojIteracija.Visible = false;
            poljaPanelResenje.Visible = false;
            inicijalizujRezim();

        }

        private void inicijalizujIzazoviRezim()
        {

            btnCheck.Text = "Izazovi";
            btnComp.Visible = true;
            btnComp.Enabled = true;
            btnComp.Text = "Generisi Kombinaciju";
            checkBoxResenje.Visible = false;
            checkBoxResenje.Enabled = true;
            trenutnaVrednost = 0;
            glavnoResenje = new int[brojZnakovaUkombinaciji];
            for (int i = 0; i < brojZnakovaUkombinaciji; i++)
            {
                glavnoResenje[i] = 0;
            }
            lblStatus.Text = "Unesite kombinaciju: ";
            lblRezim.Text = "Rezim : Izazovi";
            poljaPanelResenje.Visible = true;
            lblPopulacija.Visible = true;
            lblBrojIteracija.Visible = true;
            inicijalizujRezim();

        }

        private void inicijalizujRezim()
        {

            buttonZnak1.Enabled = true;
            buttonZnak2.Enabled = true;
            buttonZnak3.Enabled = true;
            buttonZnak4.Enabled = true;
            buttonZnak5.Enabled = true;
            buttonZnak6.Enabled = true;
            btnUndo.Enabled = true;
            btnCheck.Enabled = false;
            podesiSuperPanel();
            inicijalizujPoljaPanelResenje();
            panelIzbor.Location = new Point(superPanel1.Location.X + 16, superPanel1.Height + 40);
            panelIzbor.Width = poljaPanelResenje.Location.X + poljaPanelResenje.Width - 40;
            btnComp.Width = 150;
            this.Height = superPanel1.Height + panelIzbor.Height + 150;
            this.Width = panelIzbor.Location.X + panelIzbor.Width + 20;
            lblRezim.Location = new Point(panelIzbor.Location.X + panelIzbor.Width - lblRezim.Width, superPanel1.Location.Y);
            lblStatus.Location = new Point(panelIzbor.Location.X, panelIzbor.Location.Y + panelIzbor.Height + 10);
            lblPopulacija.Location = new Point(lblStatus.Location.X, lblStatus.Location.Y + lblStatus.Height + 10);
            lblBrojIteracija.Location = new Point(lblPopulacija.Location.X + lblPopulacija.Width + 50, lblPopulacija.Location.Y);
            lblPopulacija.Text = "Broj jedinki :" + brojJedinki;
            lblBrojIteracija.Text = "Broj iteracija :" + brojIteracija;
            btnNovaIgra.Location = new Point(panelIzbor.Location.X + panelIzbor.Width - btnNovaIgra.Width, lblStatus.Location.Y);
            checkBoxResenje.Location = new Point(panelIzbor.Location.X + panelIzbor.Width - checkBoxResenje.Width, panelIzbor.Location.Y - 30);

            CenterToScreen();
            Invalidate();

        }

        private void podesiSuperPanel()
        {
            superPanel1.BrojRedova = brojRedovaZaPogadjanje;
            superPanel1.BrojZnakovaUkombinaciji = brojZnakovaUkombinaciji;
            superPanel1.Location = new Point(20, 40);
            superPanel1.updatePokazivac();
            superPanel1.GlavnoResenje = glavnoResenje;
            superPanel1.Genetski.VelicinaPopulacije = brojJedinki;
            superPanel1.Genetski.BrojIteracija = brojIteracija;
            superPanel1.Genetski.BrojZnakovaUkombinaciji = brojZnakovaUkombinaciji;
            superPanel1.inicijalizujSuperPanel();

        }

        private void inicijalizujPoljaPanelResenje()
        {
            poljaPanelResenje.BrojZnakovaUkombinaciji = brojZnakovaUkombinaciji;
            poljaPanelResenje.Vrednosti = glavnoResenje;
            poljaPanelResenje.Location = new Point(superPanel1.Location.X + superPanel1.Width + 100, lblRezim.Location.Y + lblRezim.Height + 10);
            poljaPanelResenje.Width = (brojZnakovaUkombinaciji) * (32 + 10);
            poljaPanelResenje.Invalidate();
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            if (rezim == 1)
            {
                inicijalizujNormalanRezim();
            }
            else if (rezim == 2)
            {
                inicijalizujIzazoviRezim();
            }

            superPanel1.inicijalizujSuperPanel();


        }

        #region ProcessCmdKey

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.D1 && buttonZnak1.Enabled)
            {
                dodavanjeZnaka(1);
            }
            else if (keyData == Keys.D2 && buttonZnak2.Enabled)
            {
                dodavanjeZnaka(2);
            }
            else if (keyData == Keys.D3 && buttonZnak3.Enabled)
            {
                dodavanjeZnaka(3);
            }
            else if (keyData == Keys.D4 && buttonZnak4.Enabled)
            {
                dodavanjeZnaka(4);
            }
            else if (keyData == Keys.D5 && buttonZnak5.Enabled)
            {
                dodavanjeZnaka(5);
            }
            else if (keyData == Keys.D6 && buttonZnak6.Enabled)
            {
                dodavanjeZnaka(6);
            }
            else if (keyData == Keys.Back && btnUndo.Enabled)
            {
                superPanel1.undo();
                btnCheck.Enabled = false;
            }
            else if (keyData == Keys.Enter)
            {
                if (rezim == 1)
                {
                    if (btnCheck.Enabled)
                    {
                        superPanel1.proveraTrenutneKombinacijeSaGlavnimResenjem();
                        poljaPanelResenje.Invalidate();
                        if (superPanel1.TrenutniRed == superPanel1.BrojRedova || superPanel1.Reseno)
                        {

                            poljaPanelResenje.Visible = true;
                            lblStatus.Text = "Nemate više poteza. Više sreće sledeći put.";
                            if (superPanel1.Reseno)
                                lblStatus.Text = "Pobedili ste! ";
                            this.prekiniIgru();
                        }
                        superPanel1.updatePokazivac();
                        btnCheck.Enabled = false;
                    }
                    else if (!buttonZnak1.Enabled)
                    {
                        inicijalizujNormalanRezim();
                        superPanel1.inicijalizujSuperPanel();


                    }


                    return true;
                }

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion ProcessCmdKey

        private void dodavanjeZnaka(int znak)
        {
            if (rezim == 1)
            {
                superPanel1.dodajZnak(znak);
                if (superPanel1.TrenutnaVrednost == brojZnakovaUkombinaciji)
                    btnCheck.Enabled = true;
            }
            else if (rezim == 2)
            {
                if (trenutnaVrednost < brojZnakovaUkombinaciji)
                {
                    glavnoResenje[trenutnaVrednost] = znak;
                    trenutnaVrednost++;
                    poljaPanelResenje.Invalidate();
                    if (trenutnaVrednost == brojZnakovaUkombinaciji)
                        btnCheck.Enabled = true;
                }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            dodavanjeZnaka(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dodavanjeZnaka(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dodavanjeZnaka(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dodavanjeZnaka(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dodavanjeZnaka(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dodavanjeZnaka(6);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (rezim == 1)
            {
                superPanel1.undo();
                btnCheck.Enabled = false;
            }
            else if (rezim == 2)
            {
                if (trenutnaVrednost > 0)
                {
                    trenutnaVrednost--;
                    glavnoResenje[trenutnaVrednost] = 0;
                    btnCheck.Enabled = false;
                    poljaPanelResenje.Invalidate();
                }

            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (rezim == 1)
            {
                superPanel1.proveraTrenutneKombinacijeSaGlavnimResenjem();
                poljaPanelResenje.Invalidate();
                if (superPanel1.TrenutniRed == superPanel1.BrojRedova || superPanel1.Reseno)
                {
                    poljaPanelResenje.Visible = true;
                    lblStatus.Text = "Resenje nije nadjeno.";
                    if (superPanel1.Reseno)
                        lblStatus.Text = "Resenje nadjeno!";

                    this.prekiniIgru();
                }
                superPanel1.updatePokazivac();
                btnCheck.Enabled = false;
            }
            else if (rezim == 2)
            {

                superPanel1.GlavnoResenje = glavnoResenje;

                if (!backgroundWorker1.IsBusy) 
                {
                    backgroundWorker1.RunWorkerAsync();
                    //asinhrono izvrsenje racunanja

                }

            }

        }

        private void prekiniIgru()
        {
            buttonZnak1.Enabled = false;
            buttonZnak2.Enabled = false;
            buttonZnak3.Enabled = false;
            buttonZnak4.Enabled = false;
            buttonZnak5.Enabled = false;
            buttonZnak6.Enabled = false;
            btnUndo.Enabled = false;
            btnCheck.Enabled = false;
            btnComp.Enabled = false;
            checkBoxResenje.Enabled = false;
        }


        private void btnComp_Click(object sender, EventArgs e)
        {
            if (rezim == 1)
            {
                KompjuterPogadjaJedanRed();
                if (superPanel1.TrenutniRed == superPanel1.BrojRedova || superPanel1.Reseno)
                {
                    poljaPanelResenje.Visible = true;
                    lblStatus.Text = "Resenje nije nadjeno.";
                    if (superPanel1.Reseno)
                        lblStatus.Text = "Resenje nadjeno! ";

                    this.prekiniIgru();
                }
                superPanel1.updatePokazivac();
            }
            else if (rezim == 2)  //generisanje kombinacije za pogadjanje
            {
                Random random = new Random();
                inicijalizujIzazoviRezim();
                for (int i = 0; i < brojZnakovaUkombinaciji; i++)
                {
                    glavnoResenje[i] = random.Next(1, 7);
                }

                poljaPanelResenje.Invalidate();
                trenutnaVrednost = brojZnakovaUkombinaciji;
                btnCheck.Enabled = true;

            }
        }

        private void KompjuterPogadjaJedanRed() //pronalazenje resenja za jedan red
        {
            this.Cursor = Cursors.WaitCursor;
            btnComp.Enabled = false;
            superPanel1.KompjuterPogadja();
            this.Cursor = Cursors.Arrow;
            btnComp.Enabled = true;

        }

        private void KompjuterPogadjaJedanRedAsinhrono() 
        {
            superPanel1.KompjuterPogadja();
        }


        private void normalanRežimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rezim = 1;
            inicijalizujNormalanRezim();

        }

        private void izazoviKompjuteraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rezim = 2;
            inicijalizujIzazoviRezim();

        }

        private void checkBoxResenje_CheckedChanged(object sender, EventArgs e)
        {
            poljaPanelResenje.Visible = checkBoxResenje.Checked;
        }

        private void podešavanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DijalogOpcije dijalogOpcije = new DijalogOpcije(brojJedinki, brojIteracija, brojRedovaZaPogadjanje, brojZnakovaUkombinaciji);
            if (dijalogOpcije.ShowDialog() == DialogResult.OK)
            {
                brojRedovaZaPogadjanje = dijalogOpcije.BrRedova;
                brojJedinki = dijalogOpcije.BrJedinki;
                brojIteracija = dijalogOpcije.BrIteracija;
                brojZnakovaUkombinaciji = dijalogOpcije.BrZnakovaUkombinaciji;

                if (rezim == 1)
                {

                    inicijalizujNormalanRezim();
                }

                else if (rezim == 2)
                {

                    inicijalizujIzazoviRezim();

                }

            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            rezim = 1;
            inicijalizujNormalanRezim();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void autoriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pravilaIgreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DijalogPravila pravila = new DijalogPravila();
            pravila.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker bw = sender as BackgroundWorker;

            while (superPanel1.TrenutniRed < superPanel1.BrojRedova && !superPanel1.Reseno)
            {
                KompjuterPogadjaJedanRedAsinhrono();

            }


            backgroundWorker1.ReportProgress(100);

            if (bw.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            {
                if (e.Cancelled)
                {

                    MessageBox.Show("Operation was canceled");
                }
                else if (e.Error != null)
                {

                    string msg = String.Format("An error occurred: {0}", e.Error.Message);
                    MessageBox.Show(msg);
                }

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            poljaPanelResenje.Visible = true;
            lblStatus.Text = "Resenje nije nadjeno.";
            if (superPanel1.Reseno)
                lblStatus.Text = "Resenje nadjeno! ";
            this.prekiniIgru();
            superPanel1.updatePokazivac();
        }
    }
}
