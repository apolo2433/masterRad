using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORISkocko.Genetski_Algoritam
{



    public class Generation
    {

        private int numberOfIterations = 50; //broj ponavljanja genetskog algoritma pre svakog pokusaja
        public static double mutationThreshold = 0.05;
        public static double crossoverThreshold = 0.3;
        private int numberOfRowsForGuessing = 6;
        private int numberOfSignsInCombination = 4;
        private int currentRow = 0;
        private Population parents = new Population();
        private Population children = new Population();
        private int populationSize = 500;
        private int[][] tableForGuessing;
        private int[][] tableForResoults;
        private Population[] pastPopulations;


        public Generation()
        {
            InitializeTablesGuessingAndResoults();

        }

        public void InitializeTablesGuessingAndResoults()
        {
            
            tableForGuessing = new int[numberOfRowsForGuessing][];
            tableForResoults = new int[numberOfRowsForGuessing][];
            for (int i = 0; i < numberOfRowsForGuessing; i++)
            {
                tableForGuessing[i] = new int[numberOfSignsInCombination];
                tableForResoults[i] = new int[numberOfSignsInCombination];
            }
        }

        public void InitializeGeneration()
        {
            parents = new Population(populationSize);
            children = new Population(populationSize);
            PastPopulations = new Population[numberOfRowsForGuessing];
            parents.NumberOfSignsInCombination = numberOfSignsInCombination;
            children.NumberOfSignsInCombination = numberOfSignsInCombination;
            parents.initializeIndividuals();
            children.initializeIndividuals();
        }

        public void CalculateFitnessOfIndividual(int currentRow, Individual individual)
        {

            float fitness = 0;
            int similarly; // poklapanja
            int[] similarityWithPastCombinations;
            for (int i = 0; i < currentRow; i++)
            {
                //poredjenje sa prethodnim pokusajima a zatim sa resenjima tih pokusaja
                similarityWithPastCombinations = CompareIndividualWithPastCombination(individual.genes, tableForGuessing[i]); // vrati npr [2 1 0 0 ] za pogotke ili promasaje
                similarly = CompareWithResoults(i, similarityWithPastCombinations);
                fitness += ((float)similarly) / numberOfSignsInCombination;  //u slucaju problema sa deljenjem
            }
            if (currentRow > 0) // delimo brojem redova sa kojima smo poredili
                fitness = ((float)fitness) / currentRow;

            if (fitness == 0)
                fitness += .01f;

            individual.Fitness = fitness;

        }

        public void OneIteration()
        {
            SaveBestIndividualFromThisIteration();
            double sumOfFitness = parents.SumOfFitness();
            int parent1;
            int parent2;

            for (int i = 1; i < parents.individuals.Length / 2; i++)
            {
                parent1 = parents.RulettSelection(sumOfFitness);
                parent2 = parents.RulettSelection(sumOfFitness);

                while (parent1 == parent2) 
                {
                    parent2 = parents.RulettSelection(sumOfFitness);
                }
                Individual A = new Individual(parents.individuals[parent1]);
                Individual B = new Individual(parents.individuals[parent2]);
                Individual a = new Individual();
                Individual b = new Individual();
                a.NumberOfSignsInCombination = numberOfSignsInCombination;
                b.NumberOfSignsInCombination = numberOfSignsInCombination;
                a.initializeIndividual();
                b.initializeIndividual();
                parents.UniformCrossover(A, B, a, b, crossoverThreshold);
                children.Mutation(mutationThreshold, a);
                children.Mutation(mutationThreshold, b);

                children.individuals[i * 2] = a;
                children.individuals[i * 2 + 1] = b;

            }
            parents = children;
            children = new Population(populationSize);

        }

        public Individual SaveBestIndividualFromThisIteration()
        {
            Individual bestIndividual = new Individual();

            for (int i = 0; i < populationSize; i++)
                CalculateFitnessOfIndividual(currentRow, parents.individuals[i]);

            bestIndividual = parents.FindBestFitedIndividual();  //elitizam


            children.individuals[0] = new Individual(bestIndividual);
            children.individuals[1] = new Individual(bestIndividual);
            return bestIndividual;
        }



        public void FindBestIndividualForNextRow()  //Pronaci najbolju jedinku kroz zadati broj iteracija 
        {
            Individual bestIndvidual;
            for (int it = 0; it < numberOfIterations; it++)
            {
                OneIteration();

            }
            bestIndvidual = SaveBestIndividualFromThisIteration();
            parents.FitnessOfBestIndividual = bestIndvidual.Fitness;
            parents.AverageFitness = parents.SumOfFitness() / parents.individuals.Length;
            tableForGuessing[currentRow] = bestIndvidual.genes;
            PastPopulations[currentRow] = parents;


        }

        public void UpdateAverageFitnessOfAllPopulations()
        {

            for (int i = 0; i < currentRow - 1; i++)
            {
                for (int j = 0; j < populationSize; j++)
                {

                    CalculateFitnessOfIndividual(currentRow, PastPopulations[i].individuals[j]);
                }
                PastPopulations[i].AverageFitness = PastPopulations[i].SumOfFitness() / PastPopulations[i].individuals.Length;
                PastPopulations[i].FitnessOfBestIndividual = PastPopulations[i].FindBestFitedIndividual().Fitness;
            }
            
        }




        public int CompareWithResoults(int row, int[] resoultsComapraingWithPastAttempts)  //poredi vrednosti poslatog niza sa vrednostima resenja za dati red
        {
            int similarly = 0;
            int[] resoults = tableForResoults[row];
            for (int i = 0; i < numberOfSignsInCombination; i++)
            {

                if (resoultsComapraingWithPastAttempts[i] == resoults[i])
                {
                    similarly++;
                }
            }

            return similarly;
        }
        // Ako je vrednost resenjePanela 2 2 1 0 to znaci da i naredna jedinka mora biti takva u odnosu na prethodne


        public int[] CompareIndividualWithPastCombination(int[] individual, int[] pastCombination)
        {
            int[] processedSolution = new int[NumberOfSignsInCombination];
            int[] processedPanel = new int[NumberOfSignsInCombination];
            int[] currentSolution = new int[NumberOfSignsInCombination];

            for (int i = 0; i < NumberOfSignsInCombination; i++)
            {
                processedSolution[i] = 0;
                processedPanel[i] = 0;  // skracuje vreme pretrage
                currentSolution[i] = 0;
            }
            int indexNumber = 0;
            bool found;
            //provera da li je pravi znak na pravom mestu
            for (int i = 0; i < NumberOfSignsInCombination; i++)
            {
                if (individual[i] == pastCombination[i])
                {
                    currentSolution[indexNumber] = 2;
                    processedPanel[i] = 1;
                    processedSolution[i] = 1;
                    indexNumber++;
                }
            }
            //provera da li je pravi znak na pogresnom mestu
            for (int i = 0; i < NumberOfSignsInCombination; i++)
            {
                found = false;
                for (int j = 0; j < NumberOfSignsInCombination && !found; j++)
                {
                    if (j != i && processedPanel[i] == 0 && processedSolution[j] == 0)
                    {
                        if (individual[i] == pastCombination[j])
                        {
                            currentSolution[indexNumber] = 1;
                            processedPanel[i] = 1;
                            processedSolution[j] = 1;
                            found = true;
                            indexNumber++;
                        }
                    }
                }
            }

            return currentSolution;

        }

        public void AddRowIntoTableGuessing(int[] individual, int currentRow)
        {
            tableForGuessing[currentRow] = individual;
        }

        public int[] GetCurrentRowFromTableGuessing()
        {
            return tableForGuessing[currentRow];
        }
        public int[] GetCurrentRowFromTableResoults()
        {
            return tableForResoults[currentRow];
        }

        public void AddRowIntoTableResoults(int[] individual)
        {
            tableForResoults[currentRow] = individual;
        }

        public void AddSignIntoTableGuessing(int sign, int ordinalNumberOfSign)
        {
            tableForGuessing[currentRow][ordinalNumberOfSign] = sign;
            for (int i = ordinalNumberOfSign + 1; i < numberOfSignsInCombination; i++)
            {
                tableForGuessing[currentRow][i] = 0;

            }
            //uvecamo znak u utility
        }
        public void RemoveSignFromTableGuessing(int ordinalNumberOfSign)
        {
            tableForGuessing[currentRow][ordinalNumberOfSign] = 0;
            for (int i = ordinalNumberOfSign + 1; i < numberOfSignsInCombination; i++)
            {
                tableForGuessing[currentRow][i] = 0;

            }
            //umanjimo znak u utility
        }

        public bool CheckIfSolutionIsFound()
        {
            for (int i = 0; i < numberOfSignsInCombination; i++)
            {
                if (tableForResoults[currentRow][i] != 2)
                    return false;
            }
            return true;
        }

        public int NumberOfSignsInCombination
        {
            get { return numberOfSignsInCombination; }
            set { numberOfSignsInCombination = value; }
        }



        public int NumberOfIterations
        {
            set { numberOfIterations = value; }
            get { return numberOfIterations; }

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
                return parents.FitnessOfBestIndividual;
            }

            set
            {
                parents.FitnessOfBestIndividual = value;
            }
        }

        public float AverageFitness
        {
            get
            {
                return parents.AverageFitness;
            }

            set
            {
                parents.AverageFitness = value;
            }
        }

        public int NumberOfRowsForGuessing
        {
            get
            {
                return numberOfRowsForGuessing;
            }

            set
            {
                numberOfRowsForGuessing = value;
            }
        }
        public int CurrentRow
        {
            get
            {
                return currentRow;
            }

            set
            {
                currentRow = value;
            }
        }

        internal Population[] PastPopulations
        {
            get
            {
                return pastPopulations;
            }

            set
            {
                pastPopulations = value;
            }
        }

       
    }
}
