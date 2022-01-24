namespace Trabalho_de_MF_sobre_comercio
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.voltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fechar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalDesVista = new System.Windows.Forms.Button();
            this.txtValorDes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreDescom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.voltar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.fechar);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 105);
            this.panel1.TabIndex = 0;
            // 
            // voltar
            // 
            this.voltar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.voltar.FlatAppearance.BorderSize = 0;
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar.Image = ((System.Drawing.Image)(resources.GetObject("voltar.Image")));
            this.voltar.Location = new System.Drawing.Point(770, 0);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(101, 80);
            this.voltar.TabIndex = 6;
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(366, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // fechar
            // 
            this.fechar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.fechar.FlatAppearance.BorderSize = 0;
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar.Image = ((System.Drawing.Image)(resources.GetObject("fechar.Image")));
            this.fechar.Location = new System.Drawing.Point(845, 0);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(101, 80);
            this.fechar.TabIndex = 4;
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(396, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "CALCULAR DESCONTO DA COMPRA A VISTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "PREÇO :";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(338, 218);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(190, 20);
            this.txtPreco.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "DESCONTO :";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(367, 269);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(134, 20);
            this.txtDesconto.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "%";
            // 
            // btnCalDesVista
            // 
            this.btnCalDesVista.FlatAppearance.BorderSize = 0;
            this.btnCalDesVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalDesVista.Image = ((System.Drawing.Image)(resources.GetObject("btnCalDesVista.Image")));
            this.btnCalDesVista.Location = new System.Drawing.Point(278, 324);
            this.btnCalDesVista.Name = "btnCalDesVista";
            this.btnCalDesVista.Size = new System.Drawing.Size(78, 74);
            this.btnCalDesVista.TabIndex = 17;
            this.btnCalDesVista.UseVisualStyleBackColor = true;
            this.btnCalDesVista.Click += new System.EventHandler(this.btnCalDesVista_Click);
            // 
            // txtValorDes
            // 
            this.txtValorDes.Location = new System.Drawing.Point(628, 332);
            this.txtValorDes.Name = "txtValorDes";
            this.txtValorDes.Size = new System.Drawing.Size(232, 20);
            this.txtValorDes.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "VALOR DO DESCONTO :";
            // 
            // txtPreDescom
            // 
            this.txtPreDescom.Location = new System.Drawing.Point(643, 372);
            this.txtPreDescom.Name = "txtPreDescom";
            this.txtPreDescom.Size = new System.Drawing.Size(217, 20);
            this.txtPreDescom.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "PREÇO COM DESCONTO :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(1, 463);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(950, 21);
            this.panel6.TabIndex = 24;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(385, 332);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(66, 58);
            this.btnLimpar.TabIndex = 35;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 485);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtPreDescom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorDes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalDesVista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalDesVista;
        private System.Windows.Forms.TextBox txtValorDes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreDescom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnLimpar;
    }
}