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
    public partial class DijalogOpcije : Form
    {

        int brRedova;
        int brJedinki;
        int brIteracija;
        int brZnakovaUkombinaciji;

        public int BrRedova
        {
            get { return brRedova; }
            set { brRedova = value; }
        }

        public int BrZnakovaUkombinaciji
        {
            get { return brZnakovaUkombinaciji; }
            set { brZnakovaUkombinaciji = value; }
        }

        public int BrJedinki
        {
            get { return brJedinki; }
            set { brJedinki = value; }
        }

        public int BrIteracija
        {
            get { return brIteracija; }
            set { brIteracija = value; }
        }



      
        public DijalogOpcije(int velicinaPopulacije,int brojIteracija,int brojRedova,int brojZnakovaUkombinaciji)
        {
           

            InitializeComponent();
            brRedova = brojRedova;
            brJedinki = velicinaPopulacije;
            brIteracija = brojIteracija;
            brZnakovaUkombinaciji = brojZnakovaUkombinaciji;

            cmbBrojIteracija.Text = brIteracija.ToString();
            cmbVelicinaPopulacije.Text = brJedinki.ToString();
            cmbBrRedova.Text = brRedova.ToString();
            cmbBrojZnakova.Text = brZnakovaUkombinaciji.ToString();
        }

        private void btnPrihvati_Click(object sender, EventArgs e)
        {
            brRedova = Convert.ToInt32(cmbBrRedova.SelectedItem);
            brIteracija= Convert.ToInt32(cmbBrojIteracija.SelectedItem);
            brJedinki = Convert.ToInt32(cmbVelicinaPopulacije.SelectedItem);
            brZnakovaUkombinaciji= Convert.ToInt32(cmbBrojZnakova.SelectedItem);
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
    }
}
