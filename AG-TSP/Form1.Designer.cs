namespace AG_TSP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.lbMenorDistancia = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbEvolucoes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnCriarPop = new System.Windows.Forms.Button();
            this.gbMutacao = new System.Windows.Forms.GroupBox();
            this.rbGenesPop = new System.Windows.Forms.RadioButton();
            this.rbPopulacao = new System.Windows.Forms.RadioButton();
            this.rbNovoIndividuo = new System.Windows.Forms.RadioButton();
            this.txtQtdeTorneio = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtdeElitismo = new System.Windows.Forms.MaskedTextBox();
            this.chElitismo = new System.Windows.Forms.CheckBox();
            this.txtEvolucao = new System.Windows.Forms.MaskedTextBox();
            this.txtTaxaMutacao = new System.Windows.Forms.MaskedTextBox();
            this.txtTaxaCrossover = new System.Windows.Forms.MaskedTextBox();
            this.txtNamePop = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbQtdeCidades = new System.Windows.Forms.Label();
            this.lbComplex = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbMutacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.zedGraphControl1);
            this.panel1.Controls.Add(this.lbMenorDistancia);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbEvolucoes);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnExecutar);
            this.panel1.Controls.Add(this.btnCriarPop);
            this.panel1.Controls.Add(this.gbMutacao);
            this.panel1.Controls.Add(this.txtQtdeTorneio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtQtdeElitismo);
            this.panel1.Controls.Add(this.chElitismo);
            this.panel1.Controls.Add(this.txtEvolucao);
            this.panel1.Controls.Add(this.txtTaxaMutacao);
            this.panel1.Controls.Add(this.txtTaxaCrossover);
            this.panel1.Controls.Add(this.txtNamePop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 462);
            this.panel1.TabIndex = 1;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(15, 263);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(412, 181);
            this.zedGraphControl1.TabIndex = 20;
            // 
            // lbMenorDistancia
            // 
            this.lbMenorDistancia.AutoSize = true;
            this.lbMenorDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenorDistancia.Location = new System.Drawing.Point(183, 238);
            this.lbMenorDistancia.Name = "lbMenorDistancia";
            this.lbMenorDistancia.Size = new System.Drawing.Size(32, 22);
            this.lbMenorDistancia.TabIndex = 19;
            this.lbMenorDistancia.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Menor Distância: ";
            // 
            // lbEvolucoes
            // 
            this.lbEvolucoes.AutoSize = true;
            this.lbEvolucoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvolucoes.Location = new System.Drawing.Point(131, 216);
            this.lbEvolucoes.Name = "lbEvolucoes";
            this.lbEvolucoes.Size = new System.Drawing.Size(32, 22);
            this.lbEvolucoes.TabIndex = 17;
            this.lbEvolucoes.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Evoluções: ";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(268, 169);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(159, 46);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Enabled = false;
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(268, 117);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(159, 46);
            this.btnExecutar.TabIndex = 14;
            this.btnExecutar.Text = "Executar/Continuar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            // 
            // btnCriarPop
            // 
            this.btnCriarPop.Enabled = false;
            this.btnCriarPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPop.Location = new System.Drawing.Point(268, 65);
            this.btnCriarPop.Name = "btnCriarPop";
            this.btnCriarPop.Size = new System.Drawing.Size(159, 46);
            this.btnCriarPop.TabIndex = 13;
            this.btnCriarPop.Text = "Criar População";
            this.btnCriarPop.UseVisualStyleBackColor = true;
            // 
            // gbMutacao
            // 
            this.gbMutacao.Controls.Add(this.rbGenesPop);
            this.gbMutacao.Controls.Add(this.rbPopulacao);
            this.gbMutacao.Controls.Add(this.rbNovoIndividuo);
            this.gbMutacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMutacao.Location = new System.Drawing.Point(15, 128);
            this.gbMutacao.Name = "gbMutacao";
            this.gbMutacao.Size = new System.Drawing.Size(247, 87);
            this.gbMutacao.TabIndex = 12;
            this.gbMutacao.TabStop = false;
            this.gbMutacao.Text = "Mutação";
            // 
            // rbGenesPop
            // 
            this.rbGenesPop.AutoSize = true;
            this.rbGenesPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGenesPop.Location = new System.Drawing.Point(6, 59);
            this.rbGenesPop.Name = "rbGenesPop";
            this.rbGenesPop.Size = new System.Drawing.Size(154, 24);
            this.rbGenesPop.TabIndex = 2;
            this.rbGenesPop.Text = "Genes População";
            this.rbGenesPop.UseVisualStyleBackColor = true;
            // 
            // rbPopulacao
            // 
            this.rbPopulacao.AutoSize = true;
            this.rbPopulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPopulacao.Location = new System.Drawing.Point(6, 39);
            this.rbPopulacao.Name = "rbPopulacao";
            this.rbPopulacao.Size = new System.Drawing.Size(145, 24);
            this.rbPopulacao.TabIndex = 1;
            this.rbPopulacao.Text = "População Geral";
            this.rbPopulacao.UseVisualStyleBackColor = true;
            // 
            // rbNovoIndividuo
            // 
            this.rbNovoIndividuo.AutoSize = true;
            this.rbNovoIndividuo.Checked = true;
            this.rbNovoIndividuo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNovoIndividuo.Location = new System.Drawing.Point(6, 19);
            this.rbNovoIndividuo.Name = "rbNovoIndividuo";
            this.rbNovoIndividuo.Size = new System.Drawing.Size(130, 24);
            this.rbNovoIndividuo.TabIndex = 0;
            this.rbNovoIndividuo.TabStop = true;
            this.rbNovoIndividuo.Text = "Novo Indivíduo";
            this.rbNovoIndividuo.UseVisualStyleBackColor = true;
            // 
            // txtQtdeTorneio
            // 
            this.txtQtdeTorneio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeTorneio.Location = new System.Drawing.Point(386, 36);
            this.txtQtdeTorneio.Mask = "0";
            this.txtQtdeTorneio.Name = "txtQtdeTorneio";
            this.txtQtdeTorneio.Size = new System.Drawing.Size(41, 26);
            this.txtQtdeTorneio.TabIndex = 11;
            this.txtQtdeTorneio.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Torneio";
            // 
            // txtQtdeElitismo
            // 
            this.txtQtdeElitismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeElitismo.Location = new System.Drawing.Point(386, 6);
            this.txtQtdeElitismo.Mask = "0";
            this.txtQtdeElitismo.Name = "txtQtdeElitismo";
            this.txtQtdeElitismo.Size = new System.Drawing.Size(41, 26);
            this.txtQtdeElitismo.TabIndex = 9;
            this.txtQtdeElitismo.Text = "3";
            // 
            // chElitismo
            // 
            this.chElitismo.AutoSize = true;
            this.chElitismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chElitismo.Location = new System.Drawing.Point(300, 9);
            this.chElitismo.Name = "chElitismo";
            this.chElitismo.Size = new System.Drawing.Size(80, 22);
            this.chElitismo.TabIndex = 8;
            this.chElitismo.Text = "Elitismo";
            this.chElitismo.UseVisualStyleBackColor = true;
            // 
            // txtEvolucao
            // 
            this.txtEvolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvolucao.Location = new System.Drawing.Point(162, 96);
            this.txtEvolucao.Mask = "0000";
            this.txtEvolucao.Name = "txtEvolucao";
            this.txtEvolucao.Size = new System.Drawing.Size(100, 26);
            this.txtEvolucao.TabIndex = 7;
            this.txtEvolucao.Text = "100";
            // 
            // txtTaxaMutacao
            // 
            this.txtTaxaMutacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaMutacao.Location = new System.Drawing.Point(162, 65);
            this.txtTaxaMutacao.Mask = "0.0000";
            this.txtTaxaMutacao.Name = "txtTaxaMutacao";
            this.txtTaxaMutacao.Size = new System.Drawing.Size(100, 26);
            this.txtTaxaMutacao.TabIndex = 6;
            this.txtTaxaMutacao.Text = "0001";
            // 
            // txtTaxaCrossover
            // 
            this.txtTaxaCrossover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaCrossover.Location = new System.Drawing.Point(162, 36);
            this.txtTaxaCrossover.Mask = "0.000";
            this.txtTaxaCrossover.Name = "txtTaxaCrossover";
            this.txtTaxaCrossover.Size = new System.Drawing.Size(100, 26);
            this.txtTaxaCrossover.TabIndex = 5;
            this.txtTaxaCrossover.Text = "0600";
            // 
            // txtNamePop
            // 
            this.txtNamePop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePop.Location = new System.Drawing.Point(162, 6);
            this.txtNamePop.Mask = "00000";
            this.txtNamePop.Name = "txtNamePop";
            this.txtNamePop.Size = new System.Drawing.Size(100, 26);
            this.txtNamePop.TabIndex = 4;
            this.txtNamePop.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qtd Evoluções: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taxa Mutação: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taxa Crossover: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamanho Pop: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Quantidade de Cidades: ";
            // 
            // lbQtdeCidades
            // 
            this.lbQtdeCidades.AutoSize = true;
            this.lbQtdeCidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdeCidades.Location = new System.Drawing.Point(628, 6);
            this.lbQtdeCidades.Name = "lbQtdeCidades";
            this.lbQtdeCidades.Size = new System.Drawing.Size(19, 20);
            this.lbQtdeCidades.TabIndex = 3;
            this.lbQtdeCidades.Text = "--";
            // 
            // lbComplex
            // 
            this.lbComplex.AutoSize = true;
            this.lbComplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplex.Location = new System.Drawing.Point(549, 427);
            this.lbComplex.Name = "lbComplex";
            this.lbComplex.Size = new System.Drawing.Size(16, 17);
            this.lbComplex.TabIndex = 5;
            this.lbComplex.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(439, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Complexidade: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(973, 456);
            this.Controls.Add(this.lbComplex);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbQtdeCidades);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbMutacao.ResumeLayout(false);
            this.gbMutacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtNamePop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtQtdeElitismo;
        private System.Windows.Forms.CheckBox chElitismo;
        private System.Windows.Forms.MaskedTextBox txtEvolucao;
        private System.Windows.Forms.MaskedTextBox txtTaxaMutacao;
        private System.Windows.Forms.MaskedTextBox txtTaxaCrossover;
        private System.Windows.Forms.MaskedTextBox txtQtdeTorneio;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnCriarPop;
        private System.Windows.Forms.GroupBox gbMutacao;
        private System.Windows.Forms.RadioButton rbGenesPop;
        private System.Windows.Forms.RadioButton rbPopulacao;
        private System.Windows.Forms.RadioButton rbNovoIndividuo;
        private System.Windows.Forms.Label lbMenorDistancia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbEvolucoes;
        private System.Windows.Forms.Label label6;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbQtdeCidades;
        private System.Windows.Forms.Label lbComplex;
        private System.Windows.Forms.Label label10;
    }
}

