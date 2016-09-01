using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORISkocko.Genetski_Algoritam
{
    public class Individual
    {

        public int[] genes;
        public static Random random = new Random((int)DateTime.Now.Ticks);
        private float fitness = 0;
        private int numberOfSignsInCombination = 4;

        public int NumberOfSignsInCombination
        {
            get { return numberOfSignsInCombination; }
            set { numberOfSignsInCombination = value; }
        }

        public Individual()
        {

        }
        public Individual(Individual individual)
        {
            numberOfSignsInCombination = individual.NumberOfSignsInCombination;
            genes = new int[numberOfSignsInCombination];
            for (int i = 0; i < numberOfSignsInCombination; i++)
                genes[i] = individual.genes[i];
            fitness = individual.Fitness;

        }

        public void initializeIndividual()
        {
            genes = new int[numberOfSignsInCombination];
            for (int i = 0; i < numberOfSignsInCombination; i++)
            {
                int broj = generateRandomNumber(1, 7);         
                genes[i] = broj;
            }
        }

        public static int generateRandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        public float Fitness
        {
            get { return fitness; }
            set { fitness = value; }
        }


         }
}
