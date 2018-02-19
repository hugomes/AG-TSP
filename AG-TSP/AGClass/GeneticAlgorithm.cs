using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG_TSP.AGClass
{
    public class GeneticAlgorithm
    {
        private double RateCrossover;
        private double RateMutation;

        public delegate Individual[] Crossover(Individual father1, Individual father2);

        public Crossover CrossoverDelegateFunction;

        public delegate Individual Selection(Population pop);

        public Selection SelectionDelegateFunction;

        public GeneticAlgorithm()
        {
            CrossoverDelegateFunction = CrossoverPMX;
            SelectionDelegateFunction = Tournament;

            RateCrossover = ConfigurationGA.RateCrossover;
            RateMutation = ConfigurationGA.RateMutation;
        }

        /// <summary>
        /// execucao do ag - faz o elitismo, seleção cruzamento e mutação
        /// </summary>
        /// <param name="pop">Popução atual</param>
        /// <returns>Nova população evoluida</returns>
        public Population ExecuteGA(Population pop)
        {
            //criar a população: vem por parametro
            //Inicio do AG
            //avaliar a população
            Population newPopulation = new Population();
            List<Individual> popTemp = new List<Individual>();

            //atribuir individuos a popTemp
            for (int i = 0; i < ConfigurationGA.SizePopulation; i++)
            {
                popTemp.Add(pop.GetPopulation()[i]);
            }

            //verificar se vai utilizar o elitismo
            Individual[] indElite = new Individual[ConfigurationGA.SizeElitism];
            //caso optar por elitismo
            if (ConfigurationGA.Elitism)
            {
                //ordenar populacao
                pop.OrderPopulation();
                for (int i = 0; i < ConfigurationGA.SizeElitism; i++)
                {
                    indElite[i] = pop.GetPopulation()[i];
                }
            }

            for (int i = 0; i < ConfigurationGA.SizePopulation/2; i++)
            {
                //selecao dos pais
                Individual father1 = SelectionDelegateFunction(pop);
                Individual father2 = SelectionDelegateFunction(pop);

                //cruzamento dos pais
                double sortCrossNum = ConfigurationGA.Random.NextDouble();
                if (sortCrossNum < RateCrossover)
                {
                    Individual[] children = CrossoverDelegateFunction(father1, father2);

                    //mutacao dos filhos
                    if (ConfigurationGA.MutationType == ConfigurationGA.Mutation.NewIndividual)
                    {
                        children[0] = Mutation(children[0]);
                        children[1] = Mutation(children[1]);
                    }

                    //rearanjar os filhos no vetor
                    children[0].IndexOfVector = father1.IndexOfVector;
                    children[1].IndexOfVector = father2.IndexOfVector;

                    popTemp[father1.IndexOfVector] = children[0];
                    popTemp[father2.IndexOfVector] = children[1];
                }
                else
                {
                    popTemp[father1.IndexOfVector] = father1;
                    popTemp[father2.IndexOfVector] = father2;
                }
            }

            //apagar os individuos velhos e inserir os novos
            for (int i = 0; i < ConfigurationGA.SizePopulation; i++)
            {
                newPopulation.SetIndividuals(i, popTemp[i]);
            }

            popTemp = null;

            //aplicar mutacao na populacao
            if (ConfigurationGA.MutationType == ConfigurationGA.Mutation.InPopulation)
            {
                newPopulation = MutationThePopulation(new Population());
            }

            //inserir os filhos na populacao
            //inserindo os individuos do elitismo na nova populacao
            if (ConfigurationGA.Elitism)
            {
                //avaliar novamente a populacao
                newPopulation.Evaluate();
                //ordenar avaliacao
                newPopulation.OrderPopulation();

                int initPoint = ConfigurationGA.SizePopulation - ConfigurationGA.SizeElitism;
                int count = 0;
                for (int i = initPoint; i < ConfigurationGA.SizePopulation; i++)
                {
                    newPopulation.SetIndividuals(i, indElite[count]);
                    count++;
                }
            }

            //avaliacao
            newPopulation.Evaluate();

            return newPopulation;
        }

        //cruzamento
        public Individual[] CrossoverPMX(Individual father1, Individual father2)
        {
            //variavel de retorno
            Individual[] newInd = new Individual[2];
            int[] parent1 = new int[ConfigurationGA.SizeChromosome];
            int[] parent2 = new int[ConfigurationGA.SizeChromosome];

            int[] offSpring1Vector = new int[ConfigurationGA.SizeChromosome];
            int[] offSpring2Vector = new int[ConfigurationGA.SizeChromosome];

            int[] replacement1 = new int[ConfigurationGA.SizeChromosome];
            int[] replacement2 = new int[ConfigurationGA.SizeChromosome];

            //selecao dos pontos para cruzamento
            int firstPoint = ConfigurationGA.Random.Next(0, ConfigurationGA.SizeChromosome - 1);
            int secondPoint = ConfigurationGA.Random.Next(0, ConfigurationGA.SizeChromosome - 1);

            //enquanto os pontos forem iguais, vai gerar um novo secondPoint até ser diferente do firstPoint
            while (firstPoint == secondPoint)
            {
                secondPoint = ConfigurationGA.Random.Next(0, ConfigurationGA.SizeChromosome - 1);
                if (firstPoint != secondPoint)
                    break;
            }

            if (firstPoint > secondPoint)
            {
                int tmpPoint = firstPoint;
                firstPoint = secondPoint;
                secondPoint = tmpPoint;
            }

            //Console.WriteLine("P1: "+firstPoint+" - P2: "+secondPoint);

            newInd[0] = new Individual();
            newInd[1] = new Individual();

            //transferir os genes para um parent
            for (int i = 0; i < ConfigurationGA.SizeChromosome; i++)
            {
                parent1[i] = offSpring1Vector[i] = father1.GetGene(i);
                parent2[i] = offSpring2Vector[i] = father2.GetGene(i);
            }

            //popular um replacement em valores abaixo de 0
            for (int i = 0; i < ConfigurationGA.SizeChromosome; i++)
            {
                replacement1[i] = replacement2[i] = -1;
            }

            //passo de cruzamento
            for (int i = firstPoint; i <= secondPoint; i++)
            {
                offSpring1Vector[i] = parent2[i];
                offSpring2Vector[i] = parent1[i];

                replacement1[parent2[i]] = parent1[i];
                replacement2[parent1[i]] = parent2[i];
            }

            //troca de genes repetidos
            for (int i = 0; i < ConfigurationGA.SizeChromosome; i++)
            {
                if((i >= firstPoint) && (i <= secondPoint))
                    continue;

                //troca os genes
                int n1 = parent1[i];
                int m1 = replacement1[n1];
                int n2 = parent1[i];
                int m2 = replacement1[n2];

                while (m1 != -1)
                {
                    n1 = m1;
                    m1 = replacement1[m1];
                }
                while (m2 != -1)
                {
                    n2 = m2;
                    m2 = replacement2[m2];
                }

                offSpring1Vector[i] = n1;
                offSpring2Vector[i] = n2;
            }

            for (int i = 0; i < ConfigurationGA.SizeChromosome; i++)
            {
                newInd[0].SetGene(i, offSpring1Vector[i]);
                newInd[1].SetGene(i, offSpring2Vector[i]);
            }

            newInd[0].CalcFitness();
            newInd[1].CalcFitness();

            return newInd;
        }

        /// <summary>
        /// mutacao de um individuo
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Individual Mutation(Individual ind)
        {
            if (ConfigurationGA.Random.NextDouble() <= RateMutation)
            {
                int genePosition1 = ConfigurationGA.Random.Next(0, ConfigurationGA.SizeChromosome - 1);
                int genePosition2 = ConfigurationGA.Random.Next(0, ConfigurationGA.SizeChromosome - 1);

                //Console.WriteLine("GP1: " + genePosition1 + " - GP2: " + genePosition2);

                while (genePosition1 == genePosition2)
                {
                    genePosition2 = ConfigurationGA.Random.Next(0, ConfigurationGA.SizeChromosome - 1);
                }
                //Console.WriteLine("NGP1: " + genePosition1 + " - NGP2: " + genePosition2);
                ind.Mutate(genePosition1, genePosition2);
                return ind;
            }

            return ind;
        }

        /// <summary>
        /// mutacao de todos os individuos da populacao, de acordo com a taxa de mutacao
        /// </summary>
        /// <param name="population"></param>
        /// <returns></returns>
        public Population MutationThePopulation(Population population)
        {
            for (int i = 0; i < ConfigurationGA.SizePopulation; i++)
            {
                if (ConfigurationGA.Random.NextDouble() <= RateMutation)
                {
                    int genePosition1 = ConfigurationGA.Random.Next(0, ConfigurationGA.SizeChromosome - 1);
                    int genePosition2 = ConfigurationGA.Random.Next(0, ConfigurationGA.SizeChromosome - 1);

                    //Console.WriteLine("GP1: " + genePosition1 + " - GP2: " + genePosition2);

                    while (genePosition1 == genePosition2)
                    {
                        genePosition2 = ConfigurationGA.Random.Next(0, ConfigurationGA.SizeChromosome - 1);
                    }
                    //Console.WriteLine("NGP1: " + genePosition1 + " - NGP2: " + genePosition2);
                    population.GetPopulation()[i].Mutate(genePosition1, genePosition2);
                }
            }
            return population;
        }

        //selecao por torneio
        public Individual Tournament(Population pop)
        {
            Individual[] competitors = new Individual[ConfigurationGA.NumberOfCompetitors];
            Individual champion = new Individual();
            champion.SetFitness(float.PositiveInfinity);

            //selecao de competidores
            for (int i = 0; i < ConfigurationGA.NumberOfCompetitors; i++)
            {
                competitors[i] = pop.GetPopulation()[ConfigurationGA.Random.Next(0, ConfigurationGA.SizePopulation - 1)];
                //Console.WriteLine(competitors[i]);
                //escolher o vencedor
                if (competitors[i].GetFitness() < champion.GetFitness())
                    champion = competitors[i];
            }

            return champion;
        }

    }
}
