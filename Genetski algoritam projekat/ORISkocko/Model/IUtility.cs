using ORISkocko.Genetski_Algoritam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORISkocko.Model
{
    public interface IUtility
    {
        void attach(IModelObserver imo);
        
        void SetNumberOfSignsInCombination(int v);
        int GetNumberOfSignsInCombination();
        void SetNumberOfIterations(int v);
        int GetNumberOfIterations();
        void SetNumberOfRowsForGuessng(int v);
        int GetNumberOfRowsForGuessng();
        void SetPopulationSize(int v);
        int GetPopulationSize();
        void SetMainSolution(int[] solution);
        int[] GetMainSolution();
        int GetOrdinalNumberOfSign();
        void SetOrdinalNumberOfSign(int ordinalNumber);
        void SetCurrentRow(int row);
        int GetCurrentRow();
        float GetFitnessOfBestFitedIndividual();
        void SetFitnessOfBestFitedIndividual(float fitness);
        float GetAverageFitnessOfGeneration();
        void SetAverageFitnessOfGeneration(float fitness);
        void CheckCurrentCombinationWithMainSolution();
        bool GetSolutionFound();
        void SetSolutionFound(bool solutionFound);
        void CleanTableGuessingAndResoults();
        void AddRowIntoTableGuessing(int[] individual);
        void SetRegime(int r);
        int GetRegime();
        void AddSignToSolution(int znak);
        void RemoveSignFromSolution();

        void AddRowIntoTableResoults(int[] individual);
        void AddSignIntoTableGuessing(int sign);
        void RemoveSignFromTableGuessing();
        void InitializeTablesGuessingAndSolutions();
        int[] GetCurrentRowFromTableOfGuessing();
        int[] GetCurrentRowFromTableResoults();
        void CheckIfSolutionIsFound();
        void FindBestIndividualForNextRow();
        void InitializeGeneration();
        void UpdateAverageFitnessOfAllPopulations();
        float[] GetAverageFitnessOfAllPopulations();

        Population[] GetAllPopulations();

    }
    public interface IModelObserver
    {
        void valueIncremented(IUtility model, ModelEventArgs e);
    }

    public delegate void ModelHandler(IUtility sender, ModelEventArgs e);
    public class ModelEventArgs : EventArgs
    {
        public int newval;
        public ModelEventArgs(int v)
        {
            newval = v;
        }
    }
}
