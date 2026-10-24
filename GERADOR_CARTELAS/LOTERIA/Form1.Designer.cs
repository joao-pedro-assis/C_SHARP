namespace LOTERIA
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
            this.pnTipo = new System.Windows.Forms.Panel();
            this.rbLoto = new System.Windows.Forms.RadioButton();
            this.rbQuina = new System.Windows.Forms.RadioButton();
            this.rblotofacil = new System.Windows.Forms.RadioButton();
            this.rbMegasena = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnCartela = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.pnTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTipo
            // 
            this.pnTipo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnTipo.Controls.Add(this.rbLoto);
            this.pnTipo.Controls.Add(this.rbQuina);
            this.pnTipo.Controls.Add(this.rblotofacil);
            this.pnTipo.Controls.Add(this.rbMegasena);
            this.pnTipo.Controls.Add(this.label1);
            this.pnTipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTipo.Location = new System.Drawing.Point(5, 5);
            this.pnTipo.Name = "pnTipo";
            this.pnTipo.Size = new System.Drawing.Size(706, 119);
            this.pnTipo.TabIndex = 0;
            // 
            // rbLoto
            // 
            this.rbLoto.AutoSize = true;
            this.rbLoto.Location = new System.Drawing.Point(547, 57);
            this.rbLoto.Name = "rbLoto";
            this.rbLoto.Size = new System.Drawing.Size(146, 29);
            this.rbLoto.TabIndex = 4;
            this.rbLoto.Text = "LOTOMANIA";
            this.rbLoto.UseVisualStyleBackColor = true;
            // 
            // rbQuina
            // 
            this.rbQuina.AutoSize = true;
            this.rbQuina.Location = new System.Drawing.Point(395, 57);
            this.rbQuina.Name = "rbQuina";
            this.rbQuina.Size = new System.Drawing.Size(94, 29);
            this.rbQuina.TabIndex = 3;
            this.rbQuina.Text = "QUINA";
            this.rbQuina.UseVisualStyleBackColor = true;
            // 
            // rblotofacil
            // 
            this.rblotofacil.AutoSize = true;
            this.rblotofacil.Location = new System.Drawing.Point(207, 57);
            this.rblotofacil.Name = "rblotofacil";
            this.rblotofacil.Size = new System.Drawing.Size(137, 29);
            this.rblotofacil.TabIndex = 2;
            this.rblotofacil.Text = "LOTOFACIL";
            this.rblotofacil.UseVisualStyleBackColor = true;
            // 
            // rbMegasena
            // 
            this.rbMegasena.AutoSize = true;
            this.rbMegasena.Checked = true;
            this.rbMegasena.Location = new System.Drawing.Point(17, 57);
            this.rbMegasena.Name = "rbMegasena";
            this.rbMegasena.Size = new System.Drawing.Size(136, 29);
            this.rbMegasena.TabIndex = 1;
            this.rbMegasena.TabStop = true;
            this.rbMegasena.Text = "MEGASENA";
            this.rbMegasena.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipos de cartelas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnCartela
            // 
            this.pnCartela.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnCartela.Location = new System.Drawing.Point(5, 210);
            this.pnCartela.Name = "pnCartela";
            this.pnCartela.Size = new System.Drawing.Size(703, 271);
            this.pnCartela.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(2, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(706, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "CARTELA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(2, 130);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(706, 43);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "GERAR CARTELA";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.pnCartela);
            this.Controls.Add(this.pnTipo);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GERADOR DE CARTELAS";
            this.pnTipo.ResumeLayout(false);
            this.pnTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbLoto;
        private System.Windows.Forms.RadioButton rbQuina;
        private System.Windows.Forms.RadioButton rblotofacil;
        private System.Windows.Forms.RadioButton rbMegasena;
        private System.Windows.Forms.Panel pnCartela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGerar;
    }
}

