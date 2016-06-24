using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORISkocko.Genetski_Algoritam
{
    public class GenetskiAlgoritam
    {
        private int brojIteracija = 10; //broj ponavljanja genetskog algoritma pre svakog pokusaja
        public static double pragMutacije = 0.05;
        public static double pragUkrstanja = 0.3;

        Populacija roditelji = new Populacija();
        Populacija deca = new Populacija();

        private Jedinka najbolja = null;
        private int velicinaPopulacije = 500;
        private int brojZnakovaUkombinaciji = 4;

        public int BrojZnakovaUkombinaciji
        {
            get { return brojZnakovaUkombinaciji; }
            set { brojZnakovaUkombinaciji = value; }
        }

        public int BrojIteracija
        {
            set { brojIteracija = value; }
            get { return brojIteracija; }

        }

        public int VelicinaPopulacije
        {
            get { return velicinaPopulacije; }
            set { velicinaPopulacije = value; }
        }

        public void inicijalizacija()
        {
            roditelji = new Populacija(velicinaPopulacije);
            deca = new Populacija(velicinaPopulacije);

            roditelji.BrojZnakovaUkombinaciji = brojZnakovaUkombinaciji;
            deca.BrojZnakovaUkombinaciji = brojZnakovaUkombinaciji;

            roditelji.inicijalizujJedinke();
            deca.inicijalizujJedinke();


        }

        public void jednaIteracija()
        {
            roditelji.IzracunajPrilagodjenostJedinki();
            double sumaOcena = roditelji.SumaOcena();
            SacuvajNajboljuJedinkuIzOveIteracije();
            int roditelj1;
            int roditelj2;

            for (int i = 1; i < roditelji.jedinke.Length / 2; i++)
            {
                roditelj1 = roditelji.SelekcijaRulet(sumaOcena);
                roditelj2 = roditelji.SelekcijaRulet(sumaOcena);

                while (roditelj1 == roditelj2) //razliciti roditelji
                {
                    roditelj2 = roditelji.SelekcijaRulet(sumaOcena);
                }
                Jedinka A = new Jedinka(roditelji.jedinke[roditelj1]);
                Jedinka B = new Jedinka(roditelji.jedinke[roditelj2]);
                Jedinka a = new Jedinka();
                Jedinka b = new Jedinka();
                a.BrojZnakovaUkombinaciji = brojZnakovaUkombinaciji;
                b.BrojZnakovaUkombinaciji = brojZnakovaUkombinaciji;
                a.inicijalizujJedinku();
                b.inicijalizujJedinku();

                roditelji.UniformnoUkrstanje(A, B, a, b, pragUkrstanja);
                
                deca.Mutacija(pragMutacije, a);
                deca.Mutacija(pragMutacije, b);

                deca.jedinke[i * 2] = a;
                deca.jedinke[i * 2 + 1] = b;

            }
            roditelji = deca;
            deca = new Populacija(velicinaPopulacije);

        }

        public void SacuvajNajboljuJedinkuIzOveIteracije()
        {

            int najbolji = roditelji.NajvecaOcena();
            najbolja = roditelji.jedinke[najbolji];  //elitizam

            deca.jedinke[0] = new Jedinka(najbolja);
            deca.jedinke[1] = new Jedinka(najbolja);
        }

        static public void SetSuperPanel(SuperPanel superPanel)
        {
            Jedinka.SuperPanel = superPanel;
        }

        public int[] pronadjiNajboljuJedinku()  //Pronaci najbolju jedinku kroz zadati broj iteracija 
        {
            inicijalizacija();
            for (int it = 0; it < brojIteracija; it++)
            {
                jednaIteracija();

            }
            SacuvajNajboljuJedinkuIzOveIteracije();
            return najbolja.hromozom;
        }


    }
}
