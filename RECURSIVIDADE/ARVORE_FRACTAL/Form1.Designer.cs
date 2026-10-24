namespace ARVORE_FRACTAL
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
            this.pnArvore = new System.Windows.Forms.Panel();
            this.btnDesenhar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAngulo = new System.Windows.Forms.Label();
            this.sbAngulo = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCrescimento = new System.Windows.Forms.Label();
            this.sbCrescimento = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // pnArvore
            // 
            this.pnArvore.BackColor = System.Drawing.Color.Honeydew;
            this.pnArvore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnArvore.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnArvore.Location = new System.Drawing.Point(10, 10);
            this.pnArvore.Name = "pnArvore";
            this.pnArvore.Size = new System.Drawing.Size(530, 603);
            this.pnArvore.TabIndex = 0;
            // 
            // btnDesenhar
            // 
            this.btnDesenhar.Location = new System.Drawing.Point(546, 13);
            this.btnDesenhar.Name = "btnDesenhar";
            this.btnDesenhar.Size = new System.Drawing.Size(324, 175);
            this.btnDesenhar.TabIndex = 0;
            this.btnDesenhar.Text = "DESENHAR ARVORE";
            this.btnDesenhar.UseVisualStyleBackColor = true;
            this.btnDesenhar.Click += new System.EventHandler(this.btnDesenhar_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(546, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Angulo inicial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAngulo
            // 
            this.lbAngulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAngulo.Location = new System.Drawing.Point(546, 245);
            this.lbAngulo.Name = "lbAngulo";
            this.lbAngulo.Size = new System.Drawing.Size(324, 111);
            this.lbAngulo.TabIndex = 1;
            this.lbAngulo.Text = "45";
            this.lbAngulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sbAngulo
            // 
            this.sbAngulo.Location = new System.Drawing.Point(543, 356);
            this.sbAngulo.Maximum = 189;
            this.sbAngulo.Minimum = 1;
            this.sbAngulo.Name = "sbAngulo";
            this.sbAngulo.Size = new System.Drawing.Size(324, 30);
            this.sbAngulo.TabIndex = 2;
            this.sbAngulo.Value = 45;
            this.sbAngulo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbAngulo_Scroll);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(543, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Crescimento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCrescimento
            // 
            this.lbCrescimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCrescimento.Location = new System.Drawing.Point(543, 431);
            this.lbCrescimento.Name = "lbCrescimento";
            this.lbCrescimento.Size = new System.Drawing.Size(324, 113);
            this.lbCrescimento.TabIndex = 1;
            this.lbCrescimento.Text = "65";
            this.lbCrescimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sbCrescimento
            // 
            this.sbCrescimento.Location = new System.Drawing.Point(543, 544);
            this.sbCrescimento.Maximum = 79;
            this.sbCrescimento.Minimum = 20;
            this.sbCrescimento.Name = "sbCrescimento";
            this.sbCrescimento.Size = new System.Drawing.Size(324, 29);
            this.sbCrescimento.TabIndex = 2;
            this.sbCrescimento.Value = 65;
            this.sbCrescimento.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbCrescimento_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(883, 623);
            this.Controls.Add(this.sbCrescimento);
            this.Controls.Add(this.sbAngulo);
            this.Controls.Add(this.lbCrescimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAngulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesenhar);
            this.Controls.Add(this.pnArvore);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARVORE FRACTAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnArvore;
        private System.Windows.Forms.Button btnDesenhar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAngulo;
        private System.Windows.Forms.HScrollBar sbAngulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCrescimento;
        private System.Windows.Forms.HScrollBar sbCrescimento;
    }
}

