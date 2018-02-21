using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AG_TSP.AGClass;
using ZedGraph;

namespace AG_TSP
{
    public partial class Form1 : Form
    {
        private Graphics G;// desenhar elementos na tela
        private int Count = 0;//Contador de itens inseridos na tela
        private int PointCount = 0;//Sequenciador para identificar pontos na tela
        private Population Pop;

        //zedgraph
        private GraphPane PaneMedia;
        private PointPairList MediaPopulacao = new PointPairList();

        private int Evolucoes = 0;
        private double BestAux;
        private int I = 0;
        private int ITemp = 0; // iteracoes

        public Form1()
        {
            InitializeComponent();

            PaneMedia = zedMedia.GraphPane;
            PaneMedia.Title.Text = "Média da População";
            PaneMedia.XAxis.Title.Text = "Evolução";
            PaneMedia.YAxis.Title.Text = "Média Fitness";
            zedMedia.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            G = CreateGraphics();
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            //Console.WriteLine("Point Insert");

            Pen blackPen = new Pen(Color.Red, 3);
            int x = e.X;
            int y = e.Y;

            TablePoints.AddPoint(x, y);

            Rectangle rect = new Rectangle(x-5, y-5, 10, 10);
            G.DrawEllipse(blackPen, rect);
            G.DrawString((PointCount+1).ToString(), new Font("Arial Black", 11), Brushes.Black, x+3, y);
            G.DrawString("X: "+x.ToString(), new Font("Arial Black", 6), Brushes.Black, x-20, y-25);
            G.DrawString("Y: "+y.ToString(), new Font("Arial Black", 6), Brushes.Black, x-20, y-18);

            PointCount++;

            lbQtdeCidades.Text = PointCount.ToString();
            lbComplex.Text = Fatorial((ulong)PointCount).ToString();

            if (++Count >= 4)
            {
                btnCriarPop.Enabled = true;
            }

            if (++Count >= 1)
            {
                btnLimpar.Enabled = true;
            }
            else
            {
                btnLimpar.Enabled = false;
            }

            //Console.WriteLine(TablePoints.Print());
        }

        private void PlotPoints()
        {
            //verificando se tem pontos na tabela
            if (TablePoints.PointCount > 0)
            {
                for (int i = 0; i < TablePoints.PointCount; i++)
                {
                    Pen blackPen = new Pen(Color.Red, 3);
                    //vetor de coordenadas
                    int[] coo = TablePoints.GetCoordinates(i);
                    Rectangle rect = new Rectangle(coo[0] - 5, coo[1] - 5, 10, 10);
                    G.DrawEllipse(blackPen, rect);
                    G.DrawString((i + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, coo[0] + 3, coo[1]);
                    G.DrawString("X: " + coo[0].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 25);
                    G.DrawString("Y: " + coo[1].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 18);
                }
            }
        }

        private void PlotLines(Population pop, Color color)
        {
            Pen penBest = new Pen(color, 4);
            int genA, genB;

            Individual best = pop.GetBest();
            for (int i = 0; i < ConfigurationGA.SizeChromosome; i++)
            {
                if (i < ConfigurationGA.SizeChromosome - 1)
                {
                    genA = best.GetGene(i);
                    genB = best.GetGene(i + 1);
                }
                else
                {
                    genA = best.GetGene(i);
                    genB = best.GetGene(0);
                }

                int[] vetA = TablePoints.GetCoordinates(genA);
                int[] vetB = TablePoints.GetCoordinates(genB);

                G.DrawLine(penBest, vetA[0], vetA[1], vetB[0], vetB[1]);
            }
        }

        private ulong Fatorial(ulong number)
        {
            if (number <= 1)
                return 1;
            else
            {
                return number * Fatorial(number - 1);
            }
        }

        private void btnCriarPop_Click(object sender, EventArgs e)
        {
            ConfigurationGA.SizePopulation = int.Parse(txtTamanhoPop.Text);
            Pop = new Population();
            btnExecutar.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ConfigurationGA.SizePopulation = 0;
            Count = 0;
            PointCount = 0;

            TablePoints.Clear();

            Pop = null;

            lbQtdeCidades.Text = "--";
            lbComplex.Text = "0";
            btnCriarPop.Enabled = false;
            btnExecutar.Enabled = false;
            btnLimpar.Enabled = false;

            G.Clear(Color.White);

            I = 0;
            ITemp = 0;
            Evolucoes = 0;
            lbEvolucoes.Text = "00";
            lbComplex.Text = "0";

            MediaPopulacao.Clear();
            zedMedia.Refresh();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            btnCriarPop.Enabled = false;

            float taxaMutacao = float.Parse(txtTaxaMutacao.Text);
            float taxaCrossover = float.Parse(txtTaxaCrossover.Text);
            int torneio = int.Parse(txtQtdeTorneio.Text);

            Evolucoes += int.Parse(txtEvolucao.Text);
            BestAux = double.PositiveInfinity;

            //configurar AG
            ConfigurationGA.RateCrossover = taxaCrossover;
            ConfigurationGA.RateMutation = taxaMutacao;
            ConfigurationGA.NumberOfCompetitors = torneio;
            ConfigurationGA.Mutation mutacao = ConfigurationGA.Mutation.NewIndividual;

            if (rbNovoIndividuo.Checked)
                mutacao = ConfigurationGA.Mutation.NewIndividual;
            else if (rbPopulacao.Checked)
                mutacao = ConfigurationGA.Mutation.InPopulation;
            else if (rbGenesPop.Checked)
                mutacao = ConfigurationGA.Mutation.InGenesPopulation;

            ConfigurationGA.MutationType = mutacao;

            //elitismo
            if (chElitismo.Checked)
            {
                ConfigurationGA.Elitism = true;
                ConfigurationGA.SizeElitism = int.Parse(txtQtdeElitismo.Text);
            }
            else
            {
                ConfigurationGA.Elitism = false;
            }

            //Console.WriteLine("---------------------------------------------------------------------------------------");
            //Console.WriteLine("TIPO CROSSOVER: PMX");
            //Console.WriteLine("TIPO MUTACAO: " + ConfigurationGA.MutationType);
            //Console.WriteLine("TIPO SELECAO: Torneio");
            //Console.WriteLine("ELITISMO: " + ConfigurationGA.Elitism +", QTD: "+ConfigurationGA.SizeElitism);
            //Console.WriteLine("TAXA MUTACAO: " + ConfigurationGA.RateMutation);
            //Console.WriteLine("TAXA CROSSOVER: " + ConfigurationGA.RateCrossover);
            //Console.WriteLine("EVOLUCOES: " + Evolucoes.ToString());
            //Console.WriteLine("---------------------------------------------------------------------------------------");


            GeneticAlgorithm AG = new GeneticAlgorithm();

            for (int i = ITemp; i < Evolucoes; i++)
            {
                ITemp++;
                lbEvolucoes.Text = (i+1).ToString();
                lbEvolucoes.Refresh();

                //evolucao do algoritmo genetico
                Pop = AG.ExecuteGA(Pop);

                zedMedia.GraphPane.CurveList.Clear();
                zedMedia.GraphPane.GraphObjList.Clear();

                double mediaPop = Pop.GetAveragePopulation();
                MediaPopulacao.Add(i, mediaPop);
                double bestFitness = Pop.GetBest().GetFitness();
                lbMenorDistancia.Text = bestFitness.ToString();
                lbMenorDistancia.Refresh();

                LineItem media = PaneMedia.AddCurve("Média", MediaPopulacao, Color.Red, SymbolType.None);

                //mostrar a rota a cada 6 evolucoes, se o fitness for menor que o atual
                if (i % 6 == 0 && bestFitness < BestAux)
                {
                    BestAux = bestFitness;
                    G.Clear(Color.White);
                    PlotLines(Pop, Color.Blue);
                    PlotPoints();
                    lbUltimaEvolucao.Text = (i + 1).ToString();
                    lbUltimaEvolucao.Refresh();
                }

                zedMedia.AxisChange();
                zedMedia.Invalidate();
                zedMedia.Refresh();
            }

            G.Clear(Color.White);
            PlotLines(Pop, Color.Blue);
            PlotPoints();
        }
    }
}
