using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORISkocko.Genetski_Algoritam
{
    class Populacija
    {
        private int velicinaPopulacije = 500;
        Random random = new Random();
        public Jedinka[] jedinke;
        private int brojZnakovaUkombinaciji = 4;

        public Populacija(int brojJedinki)
        {
            velicinaPopulacije = brojJedinki;
            jedinke = new Jedinka[velicinaPopulacije];
        }

        public Populacija()
        {
            jedinke = new Jedinka[velicinaPopulacije];
        }

        public void inicijalizujJedinke()
        {
            for (int i = 0; i < velicinaPopulacije; i++)
            {
                jedinke[i] = new Jedinka();
                jedinke[i].BrojZnakovaUkombinaciji = brojZnakovaUkombinaciji;
                jedinke[i].inicijalizujJedinku();

            }
        }

        public int BrojZnakovaUkombinaciji
        {
            get { return brojZnakovaUkombinaciji; }
            set { brojZnakovaUkombinaciji = value; }
        }




        public int VelicinaPopulacije
        {
            get { return velicinaPopulacije; }
            set { velicinaPopulacije = value; }
        }

        public void IzracunajPrilagodjenostJedinki()
        {
            for (int i = 0; i < velicinaPopulacije; i++)
            {
                jedinke[i].IzracunajPrilagodjenost();
            }
        }

        public double SumaOcena()
        {
            double sumaPrilagodjenosti = 0;
            for (int i = 0; i < velicinaPopulacije; i++)
            {
                sumaPrilagodjenosti += jedinke[i].Prilagodjenost;
            }
            return sumaPrilagodjenosti;
        }

        public int NajvecaOcena()
        {
            int redniBrojJedinke = 0;
            for (int i = 0; i < velicinaPopulacije; i++)
            {
                if (jedinke[redniBrojJedinke].Prilagodjenost < jedinke[i].Prilagodjenost)
                {
                    redniBrojJedinke = i;
                }
            }
            return redniBrojJedinke;
        }


        public int SelekcijaRulet(double sumaOcena)
        {
            
            int redniBrojJedinke = 0;
            double vrednostRuleta = sumaOcena * random.NextDouble();
            double gornjaGranica = 0.0;
            double donjaGranica = 0.0;
            for (int i = 0; i < velicinaPopulacije; i++)
            {
                donjaGranica = gornjaGranica;
                // ovako najvise sanse imaju vece 
                gornjaGranica += jedinke[i].Prilagodjenost;
                if ((donjaGranica <= vrednostRuleta) && (vrednostRuleta < gornjaGranica))
                {
                    redniBrojJedinke = i;
                    break;
                }
            }
            return redniBrojJedinke;
        }



        public void JednostavnoUkrstanje(Jedinka roditelj1, Jedinka roditelj2, Jedinka dete1, Jedinka dete2)
        {
            int prag = (int)(brojZnakovaUkombinaciji * random.NextDouble()); //trazi se mesto preseka
            for (int i = 0; i < prag; i++)
            {
                dete1.hromozom[i] = roditelj1.hromozom[i];
                dete2.hromozom[i] = roditelj2.hromozom[i];
            }
            // popuniti preostale gene  dece
            for (int i = prag; i < brojZnakovaUkombinaciji; i++)
            {

                dete1.hromozom[i] = roditelj2.hromozom[i];
                dete2.hromozom[i] = roditelj1.hromozom[i];
            }
        }

        public void UniformnoUkrstanje(Jedinka roditelj1, Jedinka roditelj2, Jedinka dete1, Jedinka dete2, double prag)
        {
          
            for (int i = 0; i < brojZnakovaUkombinaciji; i++)
            {

                double broj = random.NextDouble();

                if (broj <= prag)
                {

                    dete1.hromozom[i] = roditelj2.hromozom[i];
                    dete2.hromozom[i] = roditelj1.hromozom[i];

                }
                else
                {
                    dete1.hromozom[i] = roditelj1.hromozom[i];
                    dete2.hromozom[i] = roditelj2.hromozom[i];
                }
            }

        }

        public void Mutacija(double pragMutacije, Jedinka jedinka)
        {
            for (int i = 0; i < brojZnakovaUkombinaciji; i++)
            {
                //mala sansa da se desi mutacija nakog gena
                double broj = random.NextDouble();
                if (broj <= pragMutacije)
                {
                    
                    jedinka.hromozom[i] = Jedinka.generisiBrojUopsegu(1, 7);
                }
            }
        }

        



    }
}
