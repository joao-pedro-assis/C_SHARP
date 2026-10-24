namespace PROJETO_CRIPTO
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
            this.FileName = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.btnDecodificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolher arquivo";
            // 
            // FileName
            // 
            this.FileName.BackColor = System.Drawing.Color.White;
            this.FileName.Location = new System.Drawing.Point(8, 54);
            this.FileName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(773, 44);
            this.FileName.TabIndex = 0;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 117);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(389, 64);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "SELECIONAR DOCUMENTO";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Location = new System.Drawing.Point(407, 117);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(374, 64);
            this.btnCriptografar.TabIndex = 1;
            this.btnCriptografar.Text = "CRIPTOGRAFAR";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chave de criptografia(hash):MD5";
            // 
            // txtChave
            // 
            this.txtChave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChave.Location = new System.Drawing.Point(12, 221);
            this.txtChave.MaxLength = 90;
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(389, 30);
            this.txtChave.TabIndex = 2;
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Font = new System.Drawing.Font("Rockwell", 15F);
            this.txtDocumento.Location = new System.Drawing.Point(12, 257);
            this.txtDocumento.Multiline = true;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDocumento.Size = new System.Drawing.Size(769, 518);
            this.txtDocumento.TabIndex = 3;
            // 
            // btnDecodificar
            // 
            this.btnDecodificar.Location = new System.Drawing.Point(407, 187);
            this.btnDecodificar.Name = "btnDecodificar";
            this.btnDecodificar.Size = new System.Drawing.Size(374, 64);
            this.btnDecodificar.TabIndex = 1;
            this.btnDecodificar.Text = "DECODIFICAR";
            this.btnDecodificar.UseVisualStyleBackColor = true;
            this.btnDecodificar.Click += new System.EventHandler(this.btnDecodificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(793, 787);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.btnDecodificar);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criptografar documento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnDecodificar;
    }
}

