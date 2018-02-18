using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG_TSP.AGClass
{
    public static class ConfigurationGA
    {
        public static int SizeChromosome = 0;   //tamanho do cromossomo, aumenta de acordo com a quantidade de cidades
        public static int SizePopulation = 100; //tamanho da populacao
        public static Random Random = new Random((int)DateTime.Now.Ticks);
        public static bool Elitism = false;     //definir se ira usar elitismo
        public static int SizeElitism = 3;      //quantidade de individuos para elistismo
        public static double RateCrossover = 0.8;   //taxa de crossover
        public static double RateMutation = 0.01;   //taxa de mutacao
        public static int NumberOfCompetitors = 3;  //numeros de competidores para o torneio

        public static Mutation MutationType = Mutation.NewIndividual;

        public enum Mutation
        {
            NewIndividual,
            InPopulation,
            InGenesPopulation
        }
    }
}
