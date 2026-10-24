namespace FOLHA_PAGAMENTO
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pnHolerite = new System.Windows.Forms.Panel();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbSalario = new System.Windows.Forms.Label();
            this.lbSalarioBruto = new System.Windows.Forms.Label();
            this.lbHoras = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Relatorio = new System.Windows.Forms.ListBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.pnHolerite.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO DO FUNCIONÁRIO:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(16, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(273, 29);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Text = "0";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(340, 9);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(166, 59);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // pnHolerite
            // 
            this.pnHolerite.BackColor = System.Drawing.Color.Gainsboro;
            this.pnHolerite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnHolerite.Controls.Add(this.lbTipo);
            this.pnHolerite.Controls.Add(this.lbSalario);
            this.pnHolerite.Controls.Add(this.lbSalarioBruto);
            this.pnHolerite.Controls.Add(this.lbHoras);
            this.pnHolerite.Controls.Add(this.label9);
            this.pnHolerite.Controls.Add(this.label11);
            this.pnHolerite.Controls.Add(this.lbNome);
            this.pnHolerite.Controls.Add(this.label7);
            this.pnHolerite.Controls.Add(this.label5);
            this.pnHolerite.Controls.Add(this.label3);
            this.pnHolerite.Controls.Add(this.label2);
            this.pnHolerite.Location = new System.Drawing.Point(16, 103);
            this.pnHolerite.Name = "pnHolerite";
            this.pnHolerite.Size = new System.Drawing.Size(678, 372);
            this.pnHolerite.TabIndex = 3;
            // 
            // lbTipo
            // 
            this.lbTipo.BackColor = System.Drawing.Color.White;
            this.lbTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTipo.Location = new System.Drawing.Point(355, 64);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(318, 68);
            this.lbTipo.TabIndex = 2;
            this.lbTipo.Text = "TIPO";
            this.lbTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSalario
            // 
            this.lbSalario.BackColor = System.Drawing.Color.White;
            this.lbSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSalario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSalario.Location = new System.Drawing.Point(355, 175);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(318, 68);
            this.lbSalario.TabIndex = 2;
            this.lbSalario.Text = "R$ 0,00";
            this.lbSalario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSalarioBruto
            // 
            this.lbSalarioBruto.BackColor = System.Drawing.Color.White;
            this.lbSalarioBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSalarioBruto.Location = new System.Drawing.Point(3, 284);
            this.lbSalarioBruto.Name = "lbSalarioBruto";
            this.lbSalarioBruto.Size = new System.Drawing.Size(670, 68);
            this.lbSalarioBruto.TabIndex = 2;
            this.lbSalarioBruto.Text = "R$ 0,00";
            this.lbSalarioBruto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHoras
            // 
            this.lbHoras.BackColor = System.Drawing.Color.White;
            this.lbHoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHoras.Location = new System.Drawing.Point(3, 175);
            this.lbHoras.Name = "lbHoras";
            this.lbHoras.Size = new System.Drawing.Size(346, 68);
            this.lbHoras.TabIndex = 2;
            this.lbHoras.Text = "HORAS";
            this.lbHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(404, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "SALARIO HORA";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(269, 29);
            this.label11.TabIndex = 1;
            this.label11.Text = "SALÁRIO BRUTO";
            // 
            // lbNome
            // 
            this.lbNome.BackColor = System.Drawing.Color.White;
            this.lbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNome.Location = new System.Drawing.Point(3, 64);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(346, 68);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "NOME";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "QUANTIDADE HORAS";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(404, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "TIPO";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "NOME DO FUNCIONARIO:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(676, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "HOLERITE FUNCIONARIO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Relatorio
            // 
            this.Relatorio.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.Relatorio.FormattingEnabled = true;
            this.Relatorio.HorizontalScrollbar = true;
            this.Relatorio.ItemHeight = 22;
            this.Relatorio.Location = new System.Drawing.Point(713, 9);
            this.Relatorio.Name = "Relatorio";
            this.Relatorio.Size = new System.Drawing.Size(559, 466);
            this.Relatorio.TabIndex = 4;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(512, 9);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(182, 59);
            this.btnRelatorio.TabIndex = 5;
            this.btnRelatorio.Text = "RELATORIO";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1284, 479);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.Relatorio);
            this.Controls.Add(this.pnHolerite);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOLHA DE PAGAMENTO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnHolerite.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel pnHolerite;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.Label lbSalarioBruto;
        private System.Windows.Forms.Label lbHoras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Relatorio;
        private System.Windows.Forms.Button btnRelatorio;
    }
}

