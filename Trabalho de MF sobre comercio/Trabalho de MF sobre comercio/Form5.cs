using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_de_MF_sobre_comercio
{
    public partial class Form5 : Form
    {
        Stack<double> pilha = new Stack<double>();

        public Form5()
        {
            InitializeComponent();
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        void somar()
        {
            double RE = 0.0;
            foreach (double pv in pilha)
            {
                RE += pv;
                txtResultado.Text = RE.ToString("c");
            }
        }

        void limpar()
        {
            txtNominal.Clear();
            txtTaxa.Clear();
            txtTempo.Clear();
            txtNominal.Focus();
        }

            private void btnCalAntDupli_Click(object sender, EventArgs e)
        {
            double FV = 0.0, I = 0.0, ID = 0.0, PV = 0.0, X = 0.0;
            int n;

            FV = Convert.ToDouble(txtNominal.Text);
            n = Convert.ToInt32(txtTempo.Text);
            ID = Convert.ToDouble(txtTaxa.Text);
            I = ID / 100;

            X = I + 1;
            PV = FV / (Math.Pow(X, n));

            pilha.Push(PV);
            somar();
            limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
            txtResultado.Clear();
            do
            {
                pilha.Pop();
            } while (pilha.Count > 0);
        }
    }
}
