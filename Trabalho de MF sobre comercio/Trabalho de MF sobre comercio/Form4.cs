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
    public partial class Form4 : Form
    {
        public Form4()
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

        private void btnCalFinan_Click(object sender, EventArgs e)
        {
            limpar();

            int mes = 0, m = 0;
            mes = Convert.ToInt32(txtPeriodo.Text);

            for (int i = 0; i < mes; i++)
            {
                m++;
                lblMes.Items.Add(m);
            }

            double A = 0.0, SD = 0.0, IC = 0.0, I = 0.0, J = 0.0, PMT = 0.0;
            int N = 0;

            SD = Convert.ToDouble(txtValor.Text);
            N = Convert.ToInt32(txtPeriodo.Text);

            for (int i = 0; i < mes; i++)
            {
                A = SD / N;
                lblAmortizacao.Items.Add(A.ToString("c"));
            }

            for (int i = 0; i < mes; i++)
            {
                IC = Convert.ToDouble(txtTaxa.Text);
                I = IC / 100;

                J = SD * I;
                lblJuros.Items.Add(J.ToString("c"));

                PMT = A + J;
                lblPrestacao.Items.Add(PMT.ToString("c"));

                SD = SD - A;
                lblSadoDevedor.Items.Add(SD.ToString("c"));
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblMes.Items.Clear();
            lblAmortizacao.Items.Clear();
            lblJuros.Items.Clear();
            lblPrestacao.Items.Clear();
            lblSadoDevedor.Items.Clear();
            txtPeriodo.Clear();
            txtTaxa.Clear();
            txtValor.Clear();
            txtValor.Focus();
        }
        void limpar()
        {
            lblMes.Items.Clear();
            lblAmortizacao.Items.Clear();
            lblJuros.Items.Clear();
            lblPrestacao.Items.Clear();
            lblSadoDevedor.Items.Clear();
        }
    }
}
