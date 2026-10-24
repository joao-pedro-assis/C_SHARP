namespace BUSCA_LIVRO
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnResultado = new System.Windows.Forms.Panel();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbEditora = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbCapa = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            this.pnResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.CadetBlue;
            this.pnTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTop.Controls.Add(this.btnBuscar);
            this.pnTop.Controls.Add(this.txtCodigo);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.ForeColor = System.Drawing.Color.White;
            this.pnTop.Location = new System.Drawing.Point(8, 7);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(886, 115);
            this.pnTop.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(476, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(274, 69);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(32, 60);
            this.txtCodigo.Mask = "9999999999999";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(285, 27);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO DE BARRAS DO LIVRO ISBN";
            // 
            // pnResultado
            // 
            this.pnResultado.BackColor = System.Drawing.Color.CadetBlue;
            this.pnResultado.Controls.Add(this.txtSinopse);
            this.pnResultado.Controls.Add(this.txtPreco);
            this.pnResultado.Controls.Add(this.txtPais);
            this.pnResultado.Controls.Add(this.txtPaginas);
            this.pnResultado.Controls.Add(this.txtAno);
            this.pnResultado.Controls.Add(this.txtEditora);
            this.pnResultado.Controls.Add(this.label6);
            this.pnResultado.Controls.Add(this.txtAutor);
            this.pnResultado.Controls.Add(this.label4);
            this.pnResultado.Controls.Add(this.txtTitulo);
            this.pnResultado.Controls.Add(this.label9);
            this.pnResultado.Controls.Add(this.label11);
            this.pnResultado.Controls.Add(this.lbEditora);
            this.pnResultado.Controls.Add(this.label7);
            this.pnResultado.Controls.Add(this.label5);
            this.pnResultado.Controls.Add(this.pbCapa);
            this.pnResultado.Controls.Add(this.label3);
            this.pnResultado.Controls.Add(this.label2);
            this.pnResultado.Location = new System.Drawing.Point(11, 128);
            this.pnResultado.Name = "pnResultado";
            this.pnResultado.Size = new System.Drawing.Size(883, 513);
            this.pnResultado.TabIndex = 1;
            // 
            // txtSinopse
            // 
            this.txtSinopse.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtSinopse.Location = new System.Drawing.Point(17, 398);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSinopse.Size = new System.Drawing.Size(854, 95);
            this.txtSinopse.TabIndex = 2;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtPreco.Location = new System.Drawing.Point(672, 213);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(199, 32);
            this.txtPreco.TabIndex = 2;
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtPais.Location = new System.Drawing.Point(672, 292);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(199, 32);
            this.txtPais.TabIndex = 2;
            // 
            // txtPaginas
            // 
            this.txtPaginas.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtPaginas.Location = new System.Drawing.Point(456, 292);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(183, 32);
            this.txtPaginas.TabIndex = 2;
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtAno.Location = new System.Drawing.Point(234, 292);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(186, 32);
            this.txtAno.TabIndex = 2;
            // 
            // txtEditora
            // 
            this.txtEditora.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtEditora.Location = new System.Drawing.Point(234, 213);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(405, 32);
            this.txtEditora.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(667, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "PREÇO(R$)";
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtAutor.Location = new System.Drawing.Point(234, 132);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(637, 32);
            this.txtAutor.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(667, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "PAÍS";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtTitulo.Location = new System.Drawing.Point(234, 47);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(637, 32);
            this.txtTitulo.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(451, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "PÁGINAS";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "SINOPSE";
            // 
            // lbEditora
            // 
            this.lbEditora.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbEditora.ForeColor = System.Drawing.Color.White;
            this.lbEditora.Location = new System.Drawing.Point(229, 177);
            this.lbEditora.Name = "lbEditora";
            this.lbEditora.Size = new System.Drawing.Size(203, 23);
            this.lbEditora.TabIndex = 0;
            this.lbEditora.Text = "EDITORA";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(229, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "ANO";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(229, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "AUTOR";
            // 
            // pbCapa
            // 
            this.pbCapa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbCapa.Location = new System.Drawing.Point(17, 47);
            this.pbCapa.Name = "pbCapa";
            this.pbCapa.Size = new System.Drawing.Size(193, 317);
            this.pbCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCapa.TabIndex = 1;
            this.pbCapa.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(234, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "TITULO ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "CAPA DO LIVRO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(902, 651);
            this.Controls.Add(this.pnResultado);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA LIVRO GOOGLE";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnResultado.ResumeLayout(false);
            this.pnResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbCapa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label lbEditora;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label6;
    }
}

