namespace GAME
{
    partial class Game
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pnLetra = new System.Windows.Forms.Panel();
            this.btnJogar = new System.Windows.Forms.Button();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDica = new System.Windows.Forms.Label();
            this.pnPalavra = new System.Windows.Forms.Panel();
            this.pbCadafalso = new System.Windows.Forms.PictureBox();
            this.pbBoneco = new System.Windows.Forms.PictureBox();
            this.lbLetras = new System.Windows.Forms.Label();
            this.lbCronometro = new System.Windows.Forms.Label();
            this.cronometro = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pnLetra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadafalso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoneco)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLetra
            // 
            this.pnLetra.BackColor = System.Drawing.Color.Transparent;
            this.pnLetra.Controls.Add(this.btnJogar);
            this.pnLetra.Controls.Add(this.txtLetra);
            this.pnLetra.Controls.Add(this.label1);
            this.pnLetra.ForeColor = System.Drawing.Color.DarkOrange;
            this.pnLetra.Location = new System.Drawing.Point(11, 21);
            this.pnLetra.Name = "pnLetra";
            this.pnLetra.Size = new System.Drawing.Size(230, 252);
            this.pnLetra.TabIndex = 0;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Black;
            this.btnJogar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnJogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnJogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.ForeColor = System.Drawing.Color.White;
            this.btnJogar.Location = new System.Drawing.Point(13, 159);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(200, 77);
            this.btnJogar.TabIndex = 1;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // txtLetra
            // 
            this.txtLetra.BackColor = System.Drawing.Color.Black;
            this.txtLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLetra.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtLetra.Location = new System.Drawing.Point(12, 89);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(201, 32);
            this.txtLetra.TabIndex = 1;
            this.txtLetra.Text = "A";
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetra_KeyPress);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "LETRA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDica
            // 
            this.lbDica.Location = new System.Drawing.Point(256, 22);
            this.lbDica.Name = "lbDica";
            this.lbDica.Size = new System.Drawing.Size(605, 36);
            this.lbDica.TabIndex = 1;
            this.lbDica.Text = "DICA DA PALAVRA:";
            this.lbDica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnPalavra
            // 
            this.pnPalavra.BackColor = System.Drawing.Color.Transparent;
            this.pnPalavra.Location = new System.Drawing.Point(256, 86);
            this.pnPalavra.Name = "pnPalavra";
            this.pnPalavra.Size = new System.Drawing.Size(605, 187);
            this.pnPalavra.TabIndex = 2;
            // 
            // pbCadafalso
            // 
            this.pbCadafalso.BackColor = System.Drawing.Color.Transparent;
            this.pbCadafalso.Image = ((System.Drawing.Image)(resources.GetObject("pbCadafalso.Image")));
            this.pbCadafalso.Location = new System.Drawing.Point(12, 301);
            this.pbCadafalso.Name = "pbCadafalso";
            this.pbCadafalso.Size = new System.Drawing.Size(198, 288);
            this.pbCadafalso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCadafalso.TabIndex = 3;
            this.pbCadafalso.TabStop = false;
            // 
            // pbBoneco
            // 
            this.pbBoneco.BackColor = System.Drawing.Color.Transparent;
            this.pbBoneco.Location = new System.Drawing.Point(104, 342);
            this.pbBoneco.Name = "pbBoneco";
            this.pbBoneco.Size = new System.Drawing.Size(120, 183);
            this.pbBoneco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBoneco.TabIndex = 8;
            this.pbBoneco.TabStop = false;
            // 
            // lbLetras
            // 
            this.lbLetras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLetras.Font = new System.Drawing.Font("Stencil", 20.75F, System.Drawing.FontStyle.Bold);
            this.lbLetras.Location = new System.Drawing.Point(607, 313);
            this.lbLetras.Name = "lbLetras";
            this.lbLetras.Size = new System.Drawing.Size(254, 61);
            this.lbLetras.TabIndex = 9;
            this.lbLetras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCronometro
            // 
            this.lbCronometro.BackColor = System.Drawing.Color.Transparent;
            this.lbCronometro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCronometro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCronometro.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCronometro.Location = new System.Drawing.Point(681, 392);
            this.lbCronometro.Name = "lbCronometro";
            this.lbCronometro.Size = new System.Drawing.Size(180, 73);
            this.lbCronometro.TabIndex = 10;
            this.lbCronometro.Text = "120";
            this.lbCronometro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cronometro
            // 
            this.cronometro.Enabled = true;
            this.cronometro.Interval = 1000;
            this.cronometro.Tick += new System.EventHandler(this.cronometro_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(256, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 61);
            this.button1.TabIndex = 11;
            this.button1.Text = "Novo jogo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(910, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbCronometro);
            this.Controls.Add(this.lbLetras);
            this.Controls.Add(this.pbBoneco);
            this.Controls.Add(this.pbCadafalso);
            this.Controls.Add(this.pnPalavra);
            this.Controls.Add(this.lbDica);
            this.Controls.Add(this.pnLetra);
            this.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Orange;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOGO DA FORCA";
            this.Load += new System.EventHandler(this.Game1_Load);
            this.pnLetra.ResumeLayout(false);
            this.pnLetra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadafalso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoneco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLetra;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDica;
        private System.Windows.Forms.Panel pnPalavra;
        private System.Windows.Forms.PictureBox pbCadafalso;
        private System.Windows.Forms.PictureBox pbBoneco;
        private System.Windows.Forms.Label lbLetras;
        private System.Windows.Forms.Label lbCronometro;
        private System.Windows.Forms.Timer cronometro;
        private System.Windows.Forms.Button button1;
    }
}

