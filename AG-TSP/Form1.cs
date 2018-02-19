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

namespace AG_TSP
{
    public partial class Form1 : Form
    {
        private Graphics G;// desenhar elementos na tela
        private int Count = 0;//Contador de itens inseridos na tela
        private int PointCount = 0;//Sequenciador para identificar pontos na tela

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            G = CreateGraphics();
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            Console.WriteLine("Point Insert");

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

            Console.WriteLine(TablePoints.Print());
        }

        //private void PlotPoints()
        //{
        //    //verificando se tem pontos na tabela
        //    if (TablePoints.PointCount > 0)
        //    {
        //        for (int i = 0; i < TablePoints.PointCount; i++)
        //        {
        //            Pen blackPen = new Pen(Color.Red, 3);
        //            //vetor de coordenadas
        //            int[] coo = TablePoints.GetCoordinates(i);
        //            Rectangle rect = new Rectangle(coo[0] - 5, coo[1] - 5, 10, 10);
        //            G.DrawEllipse(blackPen, rect);
        //            G.DrawString((i + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, coo[0] + 3, coo[1]);
        //            G.DrawString("X: " + coo[0].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 25);
        //            G.DrawString("Y: " + coo[1].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 18);
        //        }
        //    }
        //}

        //private void PlotLines(Population pop, Color color)
        //{
        //    Pen penBest = new Pen(color, 4);
        //    int genA, genB;

        //    Individual best = pop.GetBest();
        //    for (int i = 0; i < ConfigurationGA.SizeChromosome; i++)
        //    {
        //        if (i < ConfigurationGA.SizeChromosome-1)
        //        {
        //            genA = best.GetGene(i);
        //            genB = best.GetGene(i+1);
        //        }
        //        else
        //        {
        //            genA = best.GetGene(i);
        //            genB = best.GetGene(0);
        //        }

        //        int[] vetA = TablePoints.GetCoordinates(genA);
        //        int[] vetB = TablePoints.GetCoordinates(genB);

        //        G.DrawLine(penBest, vetA[0], vetA[1], vetB[0], vetB[i]);
        //    }
        //}

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
            ConfigurationGA.SizePopulation = 10;
            ConfigurationGA.NumberOfCompetitors = 3;

            Population pop = new Population();
            GeneticAlgorithm ag = new GeneticAlgorithm();
            Console.WriteLine(ag.Tournament(pop));
        }
    }
}
