namespace API_CEP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnEndereco = new System.Windows.Forms.Panel();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbIBGE = new System.Windows.Forms.Label();
            this.lbSiaf = new System.Windows.Forms.Label();
            this.lbDDD = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbLogradouro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnProcurar);
            this.panel1.Controls.Add(this.txtCep);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 130);
            this.panel1.TabIndex = 0;
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.ForeColor = System.Drawing.Color.White;
            this.btnProcurar.Location = new System.Drawing.Point(315, 40);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(386, 49);
            this.btnProcurar.TabIndex = 3;
            this.btnProcurar.Text = "PROCURAR ENDEREÇO";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(167, 50);
            this.txtCep.Mask = "99999-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(113, 30);
            this.txtCep.TabIndex = 2;
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "DIGITE O CEP:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSULTA CEP ONLINE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnEndereco
            // 
            this.pnEndereco.Controls.Add(this.lbEstado);
            this.pnEndereco.Controls.Add(this.lbIBGE);
            this.pnEndereco.Controls.Add(this.lbSiaf);
            this.pnEndereco.Controls.Add(this.lbDDD);
            this.pnEndereco.Controls.Add(this.label15);
            this.pnEndereco.Controls.Add(this.lbCidade);
            this.pnEndereco.Controls.Add(this.label13);
            this.pnEndereco.Controls.Add(this.label9);
            this.pnEndereco.Controls.Add(this.label11);
            this.pnEndereco.Controls.Add(this.label7);
            this.pnEndereco.Controls.Add(this.lbBairro);
            this.pnEndereco.Controls.Add(this.label5);
            this.pnEndereco.Controls.Add(this.lbLogradouro);
            this.pnEndereco.Controls.Add(this.label3);
            this.pnEndereco.Location = new System.Drawing.Point(8, 145);
            this.pnEndereco.Name = "pnEndereco";
            this.pnEndereco.Size = new System.Drawing.Size(715, 374);
            this.pnEndereco.TabIndex = 1;
            // 
            // lbEstado
            // 
            this.lbEstado.BackColor = System.Drawing.Color.White;
            this.lbEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEstado.Location = new System.Drawing.Point(425, 238);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(277, 54);
            this.lbEstado.TabIndex = 1;
            this.lbEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIBGE
            // 
            this.lbIBGE.BackColor = System.Drawing.Color.White;
            this.lbIBGE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIBGE.Location = new System.Drawing.Point(486, 320);
            this.lbIBGE.Name = "lbIBGE";
            this.lbIBGE.Size = new System.Drawing.Size(216, 54);
            this.lbIBGE.TabIndex = 1;
            this.lbIBGE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSiaf
            // 
            this.lbSiaf.BackColor = System.Drawing.Color.White;
            this.lbSiaf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSiaf.Location = new System.Drawing.Point(249, 320);
            this.lbSiaf.Name = "lbSiaf";
            this.lbSiaf.Size = new System.Drawing.Size(227, 54);
            this.lbSiaf.TabIndex = 1;
            this.lbSiaf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDDD
            // 
            this.lbDDD.BackColor = System.Drawing.Color.White;
            this.lbDDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDDD.Location = new System.Drawing.Point(16, 320);
            this.lbDDD.Name = "lbDDD";
            this.lbDDD.Size = new System.Drawing.Size(212, 54);
            this.lbDDD.TabIndex = 1;
            this.lbDDD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(482, 292);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 28);
            this.label15.TabIndex = 0;
            this.label15.Text = "IBGE";
            // 
            // lbCidade
            // 
            this.lbCidade.BackColor = System.Drawing.Color.White;
            this.lbCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCidade.Location = new System.Drawing.Point(16, 238);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(403, 54);
            this.lbCidade.TabIndex = 1;
            this.lbCidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(245, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 28);
            this.label13.TabIndex = 0;
            this.label13.Text = "SIAF";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(425, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "ESTADO";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(16, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "DDD";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "CIDADE";
            // 
            // lbBairro
            // 
            this.lbBairro.BackColor = System.Drawing.Color.White;
            this.lbBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBairro.Location = new System.Drawing.Point(16, 146);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(686, 54);
            this.lbBairro.TabIndex = 1;
            this.lbBairro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "BAIRRO";
            // 
            // lbLogradouro
            // 
            this.lbLogradouro.BackColor = System.Drawing.Color.White;
            this.lbLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLogradouro.Location = new System.Drawing.Point(16, 51);
            this.lbLogradouro.Name = "lbLogradouro";
            this.lbLogradouro.Size = new System.Drawing.Size(686, 54);
            this.lbLogradouro.TabIndex = 1;
            this.lbLogradouro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "LOGRADOURO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(734, 531);
            this.Controls.Add(this.pnEndereco);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA CEP ENDEREÇO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnEndereco.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbDDD;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbLogradouro;
        private System.Windows.Forms.Label lbIBGE;
        private System.Windows.Forms.Label lbSiaf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
    }
}

