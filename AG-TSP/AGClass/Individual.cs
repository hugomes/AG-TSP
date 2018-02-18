using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AG_TSP.AGClass
{
    public class Individual
    {
        private int[] Chromosome;   //cromossomo com numeros inteiros - cada gene representa uma cidade
        private double Fitness;     //aptidao do individuo
        public int IndexOfVector = 0;   //posicao dos individuos

        public Individual()
        {
            Chromosome = new int[ConfigurationGA.SizeChromosome];
            List<int> genes = Utils.RandomNumbers(0, ConfigurationGA.SizeChromosome);

            for (int i = 0; i < ConfigurationGA.SizeChromosome; i++)
            {
                Chromosome[i] = genes[i];
            }

            //calculo do fitness
            CalcFitness();
        }

        public void Evaluate()
        {
            CalcFitness();
        }

        public int[] GetChromosome()
        {
            return Chromosome;
        }

        public void CalcFitness()
        {
            double totalDist = 0.0;
            for (int i = 0; i < ConfigurationGA.SizeChromosome; i++)
            {
                if (i < ConfigurationGA.SizeChromosome - 1)
                {
                    totalDist += TablePoints.GetDist(GetGene(i), GetGene(i + 1));
                }
                else
                {
                    totalDist += TablePoints.GetDist(GetGene(i), GetGene(0));
                }
            }
            SetFitness(totalDist);
        }

        public void SetGene(int position, int gene)
        {
            Chromosome[position] = gene;
        }

        public int GetGene(int position)
        {
            return Chromosome[position];
        }

        public void SetFitness(double fitness)
        {
            Fitness = fitness;
        }

        public double GetFitness()
        {
            return Fitness;
        }

        //Swap - troca a posicao dos genes
        public void Mutate(int pointOne, int pointTwo)
        {
            if (pointOne < ConfigurationGA.SizeChromosome &&
                pointTwo < ConfigurationGA.SizeChromosome &&
                pointOne != pointTwo)
            {
                int temp = Chromosome[pointOne];
                Chromosome[pointOne] = pointTwo;
                Chromosome[pointTwo] = temp;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += "Rota: ";
            for (int i = 0; i < ConfigurationGA.SizeChromosome; i++)
            {
                result += (GetGene(i)+1).ToString() + " -> ";
            }

            result += "Distância: " + GetFitness();

            return result;
        }
    }
}
