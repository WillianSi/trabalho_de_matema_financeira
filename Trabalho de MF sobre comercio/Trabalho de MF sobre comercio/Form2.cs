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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalDesVista_Click(object sender, EventArgs e)
        {
            double preco = 0.0, porcentagem = 0.0, desconto = 0.0, precoComDesconto = 0.0;

            preco = Convert.ToDouble(txtPreco.Text);
            porcentagem = Convert.ToDouble(txtDesconto.Text);

            desconto = (porcentagem / 100) * preco;
            txtValorDes.Text = desconto.ToString("c");
            precoComDesconto = preco - desconto;
            txtPreDescom.Text = precoComDesconto.ToString("c");
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPreco.Clear();
            txtDesconto.Clear();
            txtPreco.Focus();
        }
    }
}
