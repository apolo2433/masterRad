using ORISkocko.Genetski_Algoritam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORISkocko.Controllers
{
   public interface IUtilityController
    {
        
        void SetNumberOfSignsInCombination(int value);
        int GetNumberOfSignsInCombination();
        void SetNumberOfIterations(int v);
        int GetNumberOfIterations();
        void SetNumberOfRowsForGuessng(int v);
        int GetNumberOfRowsForGuessng();
        void SetPopulationSize(int v);
        int GetPopulationSize();
        void SetMainSolution(int[] resenje);
        int[] GetMainSolution();
        void SetOrdinalNumberOfSign(int ordinalNumber);
        int GetOrdinalNumberOfSign();
        void SetCurrentRow(int row);
        int GetCurrentRow();
        float GetFitnessOfBestFitedIndividual();
        void SetFitnessOfBestFitedIndividual(float fitness);
        float GetAverageFitnessOfGeneration();
        void SetAverageFitnessOfGeneration(float fitness);
        void CheckCurrentCombinationWithMainSolution();
        bool GetSolutionFound();
        void SetSolutionFound(bool solution);
        void SetRegime(int regime);
        int GetRegime();
        void AddSignToSolution(int sign);
        void AddRowIntoTableResoults(int[] individual);
        void RemoveSignFromSolution();
        void AddSignIntoTableGuessing(int sign);
        void InitializeTablesGuessingAndSolutions();
        void RemoveSignFromTableGuessing();
        int[] GetCurrentRowFromTableOfGuessing();
        int[] GetCurrentRowFromTableResoults();
        void CheckIfSolutionIsFound();
        void FindBestIndividualForNextRow();
        void InitializeGeneration();
        void UpdateAverageFitnessOfAllPopulations();
        float[] GetAverageFitnessOfAllPopulations();
        Population[] GetAllPopulations();



    }
}
