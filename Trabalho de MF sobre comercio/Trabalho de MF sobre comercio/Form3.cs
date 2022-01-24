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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void btnCalAntDupli_Click(object sender, EventArgs e)
        {
            double A = 0, N = 0, i = 0, n = 0;

            N = double.Parse(txtNominal.Text);
            i = double.Parse(txtTaxa.Text);
            n = double.Parse(txtTempo.Text);
            A = N * Math.Pow(1 + i, -n);
            txtResultado.Text = A.ToString("c");
            //Convert.ToString(Math.Round(A, 2));
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNominal.Clear();
            txtTaxa.Clear();
            txtTempo.Clear();
            txtResultado.Text = "";
        }
    }
}
