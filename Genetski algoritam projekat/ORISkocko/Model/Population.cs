using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORISkocko.Genetski_Algoritam
{
   public class Population
    {
        Random random = new Random();
        private int populationSize = 500;
        public Individual[] individuals;
        private int numberOfSignsInCombination = 4;
        private float averageFitness = 0.0f;
        private float fitnessOfBestIndividual = 0.0f;
        

        public Population(int populationSize)
        {
            this.populationSize = populationSize;
            individuals = new Individual[this.populationSize];
        }

        public Population()
        {
            individuals = new Individual[populationSize];
        }

        public void initializeIndividuals()
        {
            for (int i = 0; i < populationSize; i++)
            {
                individuals[i] = new Individual();
                individuals[i].NumberOfSignsInCombination = numberOfSignsInCombination;
                individuals[i].initializeIndividual();

            }
        }

        public int NumberOfSignsInCombination
        {
            get { return numberOfSignsInCombination; }
            set { numberOfSignsInCombination = value; }
        }




        public int PopulationSize
        {
            get { return populationSize; }
            set { populationSize = value; }
        }

        public float FitnessOfBestIndividual
        {
            get
            {
                return fitnessOfBestIndividual;
            }

            set
            {
                fitnessOfBestIndividual = value;
            }
        }

        public float AverageFitness
        {
            get
            {
                return averageFitness;
            }

            set
            {
                averageFitness = value;
            }
        }

        public float SumOfFitness()
        {
            float sumOfFitness = 0;
            for (int i = 0; i < populationSize; i++)
            {
                sumOfFitness += individuals[i].Fitness;
            }
            return sumOfFitness;
        }

        public Individual FindBestFitedIndividual()
        {
            int ordinalNumber = 0;
            for (int i = 0; i < populationSize; i++)
            {
                if (individuals[ordinalNumber].Fitness < individuals[i].Fitness)
                {
                    ordinalNumber = i;
                }
            }
            Individual individual = new Individual(individuals[ordinalNumber]);
            return individual;
        }


        public int RulettSelection(double sumOfFitness)
        {
            
            int ordinalNumber = 0;
            double rulletValue = sumOfFitness * random.NextDouble();
            double topLimit = 0.0;
            double lowerLimit = 0.0;
            for (int i = 0; i < populationSize; i++)
            {
                lowerLimit = topLimit;
                // ovako najvise sanse imaju vece 
                topLimit += individuals[i].Fitness;
                if ((lowerLimit <= rulletValue) && (rulletValue < topLimit))
                {
                    ordinalNumber = i;
                    break;
                }
            }
            return ordinalNumber;
        }


        public void SimpleCrossover(Individual parent1, Individual parent2, Individual child1, Individual child2)
        {
            int threshold = (int)(numberOfSignsInCombination * random.NextDouble()); //trazi se mesto preseka
            for (int i = 0; i < threshold; i++)
            {
                child1.genes[i] = parent1.genes[i];
                child2.genes[i] = parent2.genes[i];
            }
            // popuniti preostale gene  dece
            for (int i = threshold; i < numberOfSignsInCombination; i++)
            {
                child1.genes[i] = parent2.genes[i];
                child2.genes[i] = parent1.genes[i];
            }
        }

        public void UniformCrossover(Individual parent1, Individual parent2, Individual child1, Individual child2, double threshold)
        {
            for (int i = 0; i < numberOfSignsInCombination; i++)
            {
                double randomNumber = random.NextDouble();

                if (randomNumber <= threshold)
                {

                    child1.genes[i] = parent2.genes[i];
                    child2.genes[i] = parent1.genes[i];

                }
                else
                {
                    child1.genes[i] = parent1.genes[i];
                    child2.genes[i] = parent2.genes[i];
                }
            }
        }

        public void Mutation(double mutationChance, Individual individual)
        {
            for (int i = 0; i < numberOfSignsInCombination; i++)
            {
                //mala sansa da se desi mutacija nakog gena
                double randomNumber = random.NextDouble();
                if (randomNumber <= mutationChance)
                {
                    individual.genes[i] = Individual.generateRandomNumber(1, 7);
                }
            }
        }

        



    }
}
