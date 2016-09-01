using ORISkocko.Genetski_Algoritam;
using ORISkocko.Model;
using ORISkocko.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORISkocko.Controllers
{

    public class UtilityController : IUtilityController
    {
        IView view;
        IUtility utility;
        public UtilityController(IView v, IUtility m)
        {
            view = v;
            utility = m;
            view.setController(this);   
        }
      

        public void SetNumberOfSignsInCombination(int value)
        {
            utility.SetNumberOfSignsInCombination(value);
        }
        public int GetNumberOfSignsInCombination()
        {
            return utility.GetNumberOfSignsInCombination();
        }

        public void SetNumberOfIterations(int v)
        {
            utility.SetNumberOfIterations(v);
        }

        public int GetNumberOfIterations()
        {
            return utility.GetNumberOfIterations();
        }

        public void SetNumberOfRowsForGuessng(int v)
        {
            utility.SetNumberOfRowsForGuessng(v);
        }

        public int GetNumberOfRowsForGuessng()
        {
            return utility.GetNumberOfRowsForGuessng();
        }

        public void SetPopulationSize(int v)
        {
            utility.SetPopulationSize(v);
        }

        public int GetPopulationSize()
        {
            return utility.GetPopulationSize();
        }

        public void SetMainSolution(int[] solution)
        {
            utility.SetMainSolution(solution);
        }

        public int[] GetMainSolution()
        {
            return utility.GetMainSolution();
        }

        public void SetOrdinalNumberOfSign(int ordinalNumber)
        {
            utility.SetOrdinalNumberOfSign(ordinalNumber);
        }
        public int GetOrdinalNumberOfSign()
        {
            return utility.GetOrdinalNumberOfSign();
        }

        public void SetCurrentRow(int row)
        {
            utility.SetCurrentRow(row);
        }

        public int GetCurrentRow()
        {
            return utility.GetCurrentRow();
        }

        public float GetFitnessOfBestFitedIndividual()
        {
            return utility.GetFitnessOfBestFitedIndividual();
        }

        public void SetFitnessOfBestFitedIndividual(float fitness)
        {
            utility.SetFitnessOfBestFitedIndividual(fitness);
        }

        public float GetAverageFitnessOfGeneration()
        {
            return utility.GetAverageFitnessOfGeneration();
        }

        public void SetAverageFitnessOfGeneration(float fitness)
        {
            utility.SetAverageFitnessOfGeneration(fitness);
        }

        public void CheckCurrentCombinationWithMainSolution()
        {
            utility.CheckCurrentCombinationWithMainSolution();
        }

        public bool GetSolutionFound()
        {
            return utility.GetSolutionFound();
        }

        public void SetSolutionFound(bool solution)
        {
            utility.SetSolutionFound(solution);
        }

        public void SetRegime(int regime)
        {
            utility.SetRegime(regime);
        }

        public int GetRegime()
        {
            return utility.GetRegime();
        }

        public void AddSignToSolution(int sign)
        {
            utility.AddSignToSolution(sign);
        }

        public void AddRowIntoTableResoults(int[] individual)
        {
            utility.AddRowIntoTableResoults(individual);
        }

        public void RemoveSignFromSolution()
        {
            utility.RemoveSignFromSolution();
        }

        public void AddSignIntoTableGuessing(int sign)
        {
            utility.AddSignIntoTableGuessing(sign);
        }

        public void InitializeTablesGuessingAndSolutions()
        {
            utility.InitializeTablesGuessingAndSolutions();
        }

        public void RemoveSignFromTableGuessing()
        {
            utility.RemoveSignFromTableGuessing();
        }

        public int[] GetCurrentRowFromTableOfGuessing()
        {
            return utility.GetCurrentRowFromTableOfGuessing();
        }

        public int[] GetCurrentRowFromTableResoults()
        {
            return utility.GetCurrentRowFromTableResoults();
        }

        public void CheckIfSolutionIsFound()
        {
            utility.CheckIfSolutionIsFound();
        }

        public void FindBestIndividualForNextRow()
        {
            utility.FindBestIndividualForNextRow();
        }

        public void InitializeGeneration()
        {
            utility.InitializeGeneration();
        }

        public void UpdateAverageFitnessOfAllPopulations()
        {
            utility.UpdateAverageFitnessOfAllPopulations();
        }

        public float[] GetAverageFitnessOfAllPopulations()
        {
            return utility.GetAverageFitnessOfAllPopulations();
        }

        public Population[] GetAllPopulations()
        {
            return utility.GetAllPopulations();
        }
    }
}

