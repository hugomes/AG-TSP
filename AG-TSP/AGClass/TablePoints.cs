using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace AG_TSP.AGClass
{
    public static class TablePoints
    {
        private static ArrayList X = new ArrayList();   //array de valores dos pontos em x
        private static ArrayList Y = new ArrayList();   //array de valores dos pontos em y
        private static double[,] TableDist;             //tabela com distancia entre pontos
        public static int PointCount = 0;               //qtd pontos da tabela

        //adicionar um ponto 
        public static void AddPoint(int x, int y)
        {
            X.Add(x);
            Y.Add(y);
            PointCount++;
            GenerateTable();
        }

        //gerar tabela com os valores de distancia entre dois pontos
        public static void GenerateTable()
        {
            TableDist = new double[PointCount,PointCount];

            for (int i = 0; i < PointCount; i++)//para x
            {
                for (int j = 0; j < PointCount; j++)//para y
                {
                    //equacao para calcular a distancia entre dois pontos
                    TableDist[i, j] = Math.Sqrt(
                        Math.Pow(int.Parse(X[i].ToString()) - int.Parse(X[j].ToString()), 2) +
                        Math.Pow(int.Parse(Y[i].ToString()) - int.Parse(Y[j].ToString()), 2));
                }
            }

            ConfigurationGA.SizeChromosome = PointCount;
        }

        /// <summary>
        /// Retorna a tabela de distancia
        /// </summary>
        /// <returns>double[,]</returns>
        public static double[,] GetTableDist()
        {
            return TableDist;
        }

        /// <summary>
        /// Retornar a distancia entre dois pontos
        /// </summary>
        /// <param name="pointOne">int</param>
        /// <param name="pointTwo">int</param>
        /// <returns></returns>
        public static double GetDist(int pointOne, int pointTwo)
        {
            return TableDist[pointOne, pointTwo];
        }

        /// <summary>
        /// retornar quantidade de pontos dentro da classe
        /// </summary>
        /// <returns></returns>
        public static int Count()
        {
            return PointCount;
        }

        //mostrar os valores da tabela
        public static string Print()
        {
            string data = string.Empty;

            for (int i = 0; i < PointCount; i++)
            {
                for (int j = 0; j < PointCount; j++)
                {
                    data += string.Format("{0:0.#}", double.Parse(TableDist[i, j].ToString())) + " > ";
                }

                data += Environment.NewLine;
            }
            data += Environment.NewLine+"------------------------------------------------------------"+Environment.NewLine;

            return data;
        }

        /// <summary>
        /// retorna as coordenadas x e y de um ponto
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static int[] GetCoordinates(int point)
        {
            int[] arrayCoordinates = new int[2];
            arrayCoordinates[0] = int.Parse(X[point].ToString());
            arrayCoordinates[1] = int.Parse(Y[point].ToString());
            return arrayCoordinates;
        }

        public static void Clear()
        {
            X.Clear();
            Y.Clear();
            PointCount = 0;
            TableDist = null;
        }
    }
}
