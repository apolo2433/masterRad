using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORISkocko.Genetski_Algoritam
{
    class Jedinka
    {

        public int[] hromozom;
        public static Random random = new Random((int)DateTime.Now.Ticks);
        public static SuperPanel SuperPanel;
        private float prilagodjenost = 0;
        private int brojZnakovaUkombinaciji = 4;

        public int BrojZnakovaUkombinaciji
        {
            get { return brojZnakovaUkombinaciji; }
            set { brojZnakovaUkombinaciji = value; }
        }


        public Jedinka()
        {

        }

        public Jedinka(Jedinka aJedinka)
        {
            brojZnakovaUkombinaciji = aJedinka.BrojZnakovaUkombinaciji;
            hromozom = new int[brojZnakovaUkombinaciji];
            for (int i = 0; i < brojZnakovaUkombinaciji; i++)
                hromozom[i] = aJedinka.hromozom[i];
            prilagodjenost = aJedinka.Prilagodjenost;

        }

        public void inicijalizujJedinku()
        {
            hromozom = new int[brojZnakovaUkombinaciji];
            for (int i = 0; i < brojZnakovaUkombinaciji; i++)
            {
                int broj = generisiBrojUopsegu(1, 7);         
                hromozom[i] = broj;
            }
        }

        public static int generisiBrojUopsegu(int min, int max)
        {
            return random.Next(min, max);
        }

        public float Prilagodjenost
        {
            get { return prilagodjenost; }
            set { prilagodjenost = value; }
        }


        public void IzracunajPrilagodjenost()
        {
            float trenutnaPrilagodjenost = 0.0f;
            int poklapanja;
            int[] poklapanjaSaPrethodnimIzborima;
            for (int i = 0; i < SuperPanel.TrenutniRed; i++)
            {
                poklapanjaSaPrethodnimIzborima = SuperPanel.poredjenjeJedinkeSaPrethodnimPokusajem(hromozom, i); // vrati npr [2 1 0 0 ] za pogotke ili promasaje
                poklapanja = uporediSaResenjima(i, poklapanjaSaPrethodnimIzborima);
                trenutnaPrilagodjenost += ((float)poklapanja) / 4.0f;
            }

            trenutnaPrilagodjenost += .02f;

            prilagodjenost = trenutnaPrilagodjenost;

        }

        private int uporediSaResenjima(int red, int[] resenje)  //poredi vrednosti poslatog niza sa vrednostima resenja za dati red
        {
            int poklapanja = 0;
            int[] pogoci = SuperPanel.vratiPogotke(red);
            for (int i = 0; i < brojZnakovaUkombinaciji; i++)
            {

                if (resenje[i] == pogoci[i])
                {
                    poklapanja++;
                }
            }

            return poklapanja;
        }
        // Ako je vrednost resenjePanela 2 2 1 0 to znaci da i naredna jedinka mora biti takva u odnosu na prethodne
    }
}
