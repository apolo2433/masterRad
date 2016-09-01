using ORISkocko.Genetski_Algoritam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORISkocko.Model
{


    class Utility : IUtility
    {


        int ordinalNumberOfSign = 0; //redni broj polja u panelu u koji ce se staviti znak
        private Generation generation;

        private bool solutionFound = false;
        private int[] mainSolution;

        private int regime = 1;

        private event ModelHandler changed;
        public void Initialization()
        {
            generation = new Generation();
            generation.InitializeGeneration();

        }

        public Utility()
        {
            Initialization();
        }

        public void SetNumberOfSignsInCombination(int value)
        {
            generation.NumberOfSignsInCombination = value;
        }

        public int GetNumberOfSignsInCombination()
        {
            return generation.NumberOfSignsInCombination;
        }

        public void AddSignToSolution(int sign)
        {
            if (ordinalNumberOfSign < generation.NumberOfSignsInCombination)
            {
                mainSolution[ordinalNumberOfSign] = sign;
                ordinalNumberOfSign++;
            }
        }

        public int OrdinalNumberOfSign
        {
            get { return ordinalNumberOfSign; }
            set { ordinalNumberOfSign = value; }

        }

        public int CurrentRow
        {
            get { return generation.CurrentRow; }
            set { generation.CurrentRow = value; }

        }

        public int NumberOfSignsInCombination
        {
            get { return generation.NumberOfSignsInCombination; }
            set { generation.NumberOfSignsInCombination = value; }

        }



        public int[] MainSolution
        {
            get
            {
                return mainSolution;
            }

            set
            {
                mainSolution = value;
            }
        }

        public void attach(IModelObserver imo)
        {
            changed += new ModelHandler(imo.valueIncremented);
        }


        public void SetNumberOfIterations(int number)
        {
            generation.NumberOfIterations = number;
        }

        public int GetNumberOfIterations()
        {
            return generation.NumberOfIterations;
        }

        public void SetNumberOfRowsForGuessng(int number)
        {
            generation.NumberOfRowsForGuessing = number;
        }

        public int GetNumberOfRowsForGuessng()
        {
            return generation.NumberOfRowsForGuessing;
        }

        public void SetPopulationSize(int size)
        {
            generation.PopulationSize = size;
        }

        public int GetPopulationSize()
        {
            return generation.PopulationSize;
        }

        public void CheckCurrentCombinationWithMainSolution()
        {
            int[] individual = generation.GetCurrentRowFromTableGuessing();
            bool found;
            int[] processedSolution = new int[NumberOfSignsInCombination];
            int[] processedPanel = new int[NumberOfSignsInCombination];
            int[] currentSolution = new int[NumberOfSignsInCombination];
            if (ordinalNumberOfSign == NumberOfSignsInCombination)
            {
                for (int i = 0; i < NumberOfSignsInCombination; i++)
                {
                    processedSolution[i] = 0;
                    processedPanel[i] = 0;
                    currentSolution[i] = 0;
                }
                int indexNumber = 0;
                //provera da li je pravi znak na pravom mestu
                for (int i = 0; i < NumberOfSignsInCombination; i++)
                {
                    if (individual[i] == mainSolution[i])
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
                            if (individual[i] == mainSolution[j])
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
            }
            generation.AddRowIntoTableResoults(currentSolution);
            ordinalNumberOfSign = 0;
        }

        public void SetMainSolution(int[] solution)
        {
            mainSolution = solution;
        }

        public int[] GetMainSolution()
        {
            return mainSolution;
        }

        public int GetOrdinalNumberOfSign()
        {
            return ordinalNumberOfSign;
        }

        public void SetOrdinalNumberOfSign(int ordinalNumber)
        {
            ordinalNumberOfSign = ordinalNumber;
        }

        public void SetCurrentRow(int row)
        {
            generation.CurrentRow = row;
        }

        public int GetCurrentRow()
        {
            return generation.CurrentRow;
        }

        public float GetFitnessOfBestFitedIndividual()
        {
            return generation.FitnessOfBestIndividual;
        }

        public void SetFitnessOfBestFitedIndividual(float fitness)
        {
            generation.FitnessOfBestIndividual = fitness;
        }

        public float GetAverageFitnessOfGeneration()
        {
            return generation.AverageFitness;
        }

        public void SetAverageFitnessOfGeneration(float fitness)
        {
            generation.AverageFitness = fitness;
        }

        public bool GetSolutionFound()
        {
            return solutionFound;
        }

        public void SetSolutionFound(bool found)
        {
            solutionFound = found;
        }

        public void CleanTableGuessingAndResoults()
        {
            generation.InitializeTablesGuessingAndResoults();
        }

        public void AddRowIntoTableGuessing(int[] individual)
        {
            generation.AddRowIntoTableGuessing(individual, generation.CurrentRow);
        }
    

        public void SetRegime(int r)
        {
            regime = r;
        }

        public int GetRegime()
        {
            return regime;
        }

        public void AddRowIntoTableResoults(int[] individual)
        {
            generation.AddRowIntoTableResoults(individual);
        }

        public void RemoveSignFromSolution()
        {
            if (ordinalNumberOfSign > 0)
            {
                ordinalNumberOfSign--;
                mainSolution[ordinalNumberOfSign] = 0;
            }
        }

        public void AddSignIntoTableGuessing(int sign)
        {
            generation.AddSignIntoTableGuessing(sign, ordinalNumberOfSign);
            ordinalNumberOfSign++;
        }
        public void RemoveSignFromTableGuessing()
        {
            ordinalNumberOfSign--;
            generation.RemoveSignFromTableGuessing(ordinalNumberOfSign);

        }

        public void InitializeTablesGuessingAndSolutions()
        {
            generation.InitializeTablesGuessingAndResoults();
        }

        public int[] GetCurrentRowFromTableOfGuessing()
        {
            return generation.GetCurrentRowFromTableGuessing();
        }

        public int[] GetCurrentRowFromTableResoults()
        {
            return generation.GetCurrentRowFromTableResoults();
        }

        public void CheckIfSolutionIsFound()
        {
            solutionFound = generation.CheckIfSolutionIsFound();
        }

        public void FindBestIndividualForNextRow()
        {
            generation.FindBestIndividualForNextRow();
        }

        public void InitializeGeneration()
        {
            generation.InitializeGeneration();
        }

        public void UpdateAverageFitnessOfAllPopulations()
        {
            generation.UpdateAverageFitnessOfAllPopulations() ;
        }

   

        public Population[] GetAllPopulations()
        {
            return generation.PastPopulations;
        }

        public float[] GetAverageFitnessOfAllPopulations()
        {
            throw new NotImplementedException();
        }
    }
}
