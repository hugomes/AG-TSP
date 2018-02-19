using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG_TSP.AGClass
{
    public class Population
    {
        public Individual[] PopulationGroup; //grupo de individuos 

        public Population()
        {
            PopulationGroup = new Individual[ConfigurationGA.SizePopulation];
            for (int i = 0; i < ConfigurationGA.SizePopulation; i++)
            {
                PopulationGroup[i] = new Individual();
                PopulationGroup[i].IndexOfVector = i;
            }

            CalculteFitness();
        }

        //calcular o fitness de todos os individuos
        public void CalculteFitness()
        {
            for (int i = 0; i < ConfigurationGA.SizePopulation; i++)
            {
                PopulationGroup[i].CalcFitness();
            }
        }

        //avaliar toda a populacao
        public void Evaluate()
        {
            RefreshIndexOfIndividual();
            CalculteFitness();
        }

        public void RefreshIndexOfIndividual()
        {
            for (int i = 0; i < ConfigurationGA.SizePopulation; i++)
            {
                PopulationGroup[i].IndexOfVector = i;
            }
        }

        //retornar um vetor de individuos
        public Individual[] GetPopulation()
        {
            return PopulationGroup;
        }

        public void SetIndividuals(int position, Individual individual)
        {
            PopulationGroup[position] = individual;
        }

        //media da populacao para saber se o algoritmo esta melhorando ou piorando
        public double GetAveragePopulation()
        {
            double sum = 0;
            foreach (Individual ind in PopulationGroup)
            {
                sum += ind.GetFitness();
            }
            return (sum / ConfigurationGA.SizePopulation);
        }

        //ordenar a populacao do melhor para o pior
        public void OrderPopulation()
        {
            PopulationGroup.OrderBy(p => p.GetFitness());
            Individual aux;

            for (int i = 0; i < ConfigurationGA.SizePopulation; i++)
            {
                for (int j = 0; j < ConfigurationGA.SizePopulation; j++)
                {
                    if (PopulationGroup[i].GetFitness() < PopulationGroup[j].GetFitness())
                    {
                        aux = PopulationGroup[i];
                        PopulationGroup[i] = PopulationGroup[j];
                        PopulationGroup[j] = aux;
                    }
                }
            }
        }

        public Individual GetBest()
        {
            OrderPopulation();
            return PopulationGroup[0];
        }

        public Individual GetBad()
        {
            OrderPopulation();
            return PopulationGroup[ConfigurationGA.SizePopulation-1];
        }

        public override string ToString()
        {
            string result = string.Empty;

            for (int i = 0; i < ConfigurationGA.SizePopulation; i++)
            {
                result += PopulationGroup[i].ToString() + Environment.NewLine;
            }

            return result;
        }
    }
}
