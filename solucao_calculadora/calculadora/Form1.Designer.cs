namespace calculadora
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
            this.lbVisor = new System.Windows.Forms.Label();
            this.btSeno = new System.Windows.Forms.Button();
            this.btLog = new System.Windows.Forms.Button();
            this.btTangente = new System.Windows.Forms.Button();
            this.btPi = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btCosseno = new System.Windows.Forms.Button();
            this.btRaiz = new System.Windows.Forms.Button();
            this.btdivisao = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btPorcentagem = new System.Windows.Forms.Button();
            this.btCe = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btMultiplicacao = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btsubtrair = new System.Windows.Forms.Button();
            this.btPonto = new System.Windows.Forms.Button();
            this.btSoma = new System.Windows.Forms.Button();
            this.btFracao = new System.Windows.Forms.Button();
            this.btQuadrado = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.btnInverterSinal = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btBackspace = new System.Windows.Forms.Button();
            this.menuSair = new System.Windows.Forms.MenuStrip();
            this.aRQUIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbVisor
            // 
            this.lbVisor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbVisor.Font = new System.Drawing.Font("Yu Gothic", 30F);
            this.lbVisor.Location = new System.Drawing.Point(3, 29);
            this.lbVisor.Name = "lbVisor";
            this.lbVisor.Size = new System.Drawing.Size(516, 49);
            this.lbVisor.TabIndex = 0;
            this.lbVisor.Text = "0";
            this.lbVisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbVisor.Click += new System.EventHandler(this.lbVisor_Click);
            // 
            // btSeno
            // 
            this.btSeno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSeno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSeno.FlatAppearance.BorderSize = 0;
            this.btSeno.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btSeno.Location = new System.Drawing.Point(351, 82);
            this.btSeno.Name = "btSeno";
            this.btSeno.Size = new System.Drawing.Size(168, 78);
            this.btSeno.TabIndex = 4;
            this.btSeno.Text = "SIN";
            this.btSeno.UseVisualStyleBackColor = false;
            this.btSeno.Click += new System.EventHandler(this.btSeno_Click);
            // 
            // btLog
            // 
            this.btLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btLog.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btLog.FlatAppearance.BorderSize = 0;
            this.btLog.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btLog.Location = new System.Drawing.Point(351, 419);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(168, 78);
            this.btLog.TabIndex = 4;
            this.btLog.Text = "LOG";
            this.btLog.UseVisualStyleBackColor = false;
            this.btLog.Click += new System.EventHandler(this.btLog_Click);
            // 
            // btTangente
            // 
            this.btTangente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btTangente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btTangente.FlatAppearance.BorderSize = 0;
            this.btTangente.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btTangente.Location = new System.Drawing.Point(351, 250);
            this.btTangente.Name = "btTangente";
            this.btTangente.Size = new System.Drawing.Size(168, 78);
            this.btTangente.TabIndex = 4;
            this.btTangente.Text = "TAN";
            this.btTangente.UseVisualStyleBackColor = false;
            this.btTangente.Click += new System.EventHandler(this.btTangente_Click);
            // 
            // btPi
            // 
            this.btPi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btPi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btPi.FlatAppearance.BorderSize = 0;
            this.btPi.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btPi.Location = new System.Drawing.Point(351, 334);
            this.btPi.Name = "btPi";
            this.btPi.Size = new System.Drawing.Size(168, 78);
            this.btPi.TabIndex = 4;
            this.btPi.Text = "π";
            this.btPi.UseVisualStyleBackColor = false;
            this.btPi.Click += new System.EventHandler(this.btPi_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCalcular.FlatAppearance.BorderSize = 0;
            this.btCalcular.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btCalcular.Location = new System.Drawing.Point(351, 503);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(168, 78);
            this.btCalcular.TabIndex = 4;
            this.btCalcular.Text = "=";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btC
            // 
            this.btC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btC.FlatAppearance.BorderSize = 0;
            this.btC.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btC.Location = new System.Drawing.Point(177, 82);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(81, 78);
            this.btC.TabIndex = 4;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = false;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btCosseno
            // 
            this.btCosseno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCosseno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCosseno.FlatAppearance.BorderSize = 0;
            this.btCosseno.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btCosseno.Location = new System.Drawing.Point(351, 166);
            this.btCosseno.Name = "btCosseno";
            this.btCosseno.Size = new System.Drawing.Size(168, 78);
            this.btCosseno.TabIndex = 4;
            this.btCosseno.Text = "COS";
            this.btCosseno.UseVisualStyleBackColor = false;
            this.btCosseno.Click += new System.EventHandler(this.btCosseno_Click);
            // 
            // btRaiz
            // 
            this.btRaiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btRaiz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btRaiz.FlatAppearance.BorderSize = 0;
            this.btRaiz.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btRaiz.Location = new System.Drawing.Point(177, 166);
            this.btRaiz.Name = "btRaiz";
            this.btRaiz.Size = new System.Drawing.Size(168, 78);
            this.btRaiz.TabIndex = 4;
            this.btRaiz.Text = "SORT";
            this.btRaiz.UseVisualStyleBackColor = false;
            this.btRaiz.Click += new System.EventHandler(this.btRaiz_Click);
            // 
            // btdivisao
            // 
            this.btdivisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btdivisao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btdivisao.FlatAppearance.BorderSize = 0;
            this.btdivisao.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btdivisao.Location = new System.Drawing.Point(266, 250);
            this.btdivisao.Name = "btdivisao";
            this.btdivisao.Size = new System.Drawing.Size(79, 78);
            this.btdivisao.TabIndex = 4;
            this.btdivisao.Text = "/";
            this.btdivisao.UseVisualStyleBackColor = false;
            this.btdivisao.Click += new System.EventHandler(this.btdivisao_Click);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt9.FlatAppearance.BorderSize = 0;
            this.bt9.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.bt9.Location = new System.Drawing.Point(177, 250);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(81, 78);
            this.bt9.TabIndex = 3;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btPorcentagem
            // 
            this.btPorcentagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btPorcentagem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btPorcentagem.FlatAppearance.BorderSize = 0;
            this.btPorcentagem.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btPorcentagem.Location = new System.Drawing.Point(3, 82);
            this.btPorcentagem.Name = "btPorcentagem";
            this.btPorcentagem.Size = new System.Drawing.Size(81, 78);
            this.btPorcentagem.TabIndex = 3;
            this.btPorcentagem.Text = "%";
            this.btPorcentagem.UseVisualStyleBackColor = false;
            this.btPorcentagem.Click += new System.EventHandler(this.btPorcentagem_Click);
            // 
            // btCe
            // 
            this.btCe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCe.FlatAppearance.BorderSize = 0;
            this.btCe.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btCe.Location = new System.Drawing.Point(90, 82);
            this.btCe.Name = "btCe";
            this.btCe.Size = new System.Drawing.Size(81, 78);
            this.btCe.TabIndex = 3;
            this.btCe.Text = "CE";
            this.btCe.UseVisualStyleBackColor = false;
            this.btCe.Click += new System.EventHandler(this.btCe_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt6.FlatAppearance.BorderSize = 0;
            this.bt6.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.bt6.Location = new System.Drawing.Point(177, 334);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(81, 78);
            this.bt6.TabIndex = 3;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // btMultiplicacao
            // 
            this.btMultiplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btMultiplicacao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btMultiplicacao.FlatAppearance.BorderSize = 0;
            this.btMultiplicacao.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btMultiplicacao.Location = new System.Drawing.Point(266, 334);
            this.btMultiplicacao.Name = "btMultiplicacao";
            this.btMultiplicacao.Size = new System.Drawing.Size(79, 78);
            this.btMultiplicacao.TabIndex = 4;
            this.btMultiplicacao.Text = "*";
            this.btMultiplicacao.UseVisualStyleBackColor = false;
            this.btMultiplicacao.Click += new System.EventHandler(this.btMultiplicacao_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt3.FlatAppearance.BorderSize = 0;
            this.bt3.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.bt3.Location = new System.Drawing.Point(177, 419);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(81, 78);
            this.bt3.TabIndex = 3;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btsubtrair
            // 
            this.btsubtrair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btsubtrair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btsubtrair.FlatAppearance.BorderSize = 0;
            this.btsubtrair.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btsubtrair.Location = new System.Drawing.Point(266, 419);
            this.btsubtrair.Name = "btsubtrair";
            this.btsubtrair.Size = new System.Drawing.Size(79, 78);
            this.btsubtrair.TabIndex = 4;
            this.btsubtrair.Text = "-";
            this.btsubtrair.UseVisualStyleBackColor = false;
            this.btsubtrair.Click += new System.EventHandler(this.btsubtrair_Click);
            // 
            // btPonto
            // 
            this.btPonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btPonto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btPonto.FlatAppearance.BorderSize = 0;
            this.btPonto.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btPonto.Location = new System.Drawing.Point(177, 503);
            this.btPonto.Name = "btPonto";
            this.btPonto.Size = new System.Drawing.Size(81, 78);
            this.btPonto.TabIndex = 3;
            this.btPonto.Text = ".";
            this.btPonto.UseVisualStyleBackColor = false;
            this.btPonto.Click += new System.EventHandler(this.btPonto_Click);
            // 
            // btSoma
            // 
            this.btSoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSoma.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSoma.FlatAppearance.BorderSize = 0;
            this.btSoma.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btSoma.Location = new System.Drawing.Point(266, 503);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(79, 78);
            this.btSoma.TabIndex = 4;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = false;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // btFracao
            // 
            this.btFracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btFracao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btFracao.FlatAppearance.BorderSize = 0;
            this.btFracao.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btFracao.Location = new System.Drawing.Point(3, 166);
            this.btFracao.Name = "btFracao";
            this.btFracao.Size = new System.Drawing.Size(81, 78);
            this.btFracao.TabIndex = 3;
            this.btFracao.Text = "1/X";
            this.btFracao.UseVisualStyleBackColor = false;
            this.btFracao.Click += new System.EventHandler(this.btFracao_Click);
            // 
            // btQuadrado
            // 
            this.btQuadrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btQuadrado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btQuadrado.FlatAppearance.BorderSize = 0;
            this.btQuadrado.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btQuadrado.Location = new System.Drawing.Point(90, 166);
            this.btQuadrado.Name = "btQuadrado";
            this.btQuadrado.Size = new System.Drawing.Size(81, 78);
            this.btQuadrado.TabIndex = 3;
            this.btQuadrado.Text = "X2";
            this.btQuadrado.UseVisualStyleBackColor = false;
            this.btQuadrado.Click += new System.EventHandler(this.btQuadrado_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt7.FlatAppearance.BorderSize = 0;
            this.bt7.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.bt7.Location = new System.Drawing.Point(3, 250);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(81, 78);
            this.bt7.TabIndex = 3;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt8.FlatAppearance.BorderSize = 0;
            this.bt8.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.bt8.Location = new System.Drawing.Point(90, 250);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(81, 78);
            this.bt8.TabIndex = 3;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt1.FlatAppearance.BorderSize = 0;
            this.bt1.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.bt1.Location = new System.Drawing.Point(3, 418);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(81, 78);
            this.bt1.TabIndex = 3;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt2.FlatAppearance.BorderSize = 0;
            this.bt2.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.bt2.Location = new System.Drawing.Point(90, 418);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(81, 78);
            this.bt2.TabIndex = 3;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt4.FlatAppearance.BorderSize = 0;
            this.bt4.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.bt4.Location = new System.Drawing.Point(3, 334);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(81, 78);
            this.bt4.TabIndex = 3;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt5.FlatAppearance.BorderSize = 0;
            this.bt5.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.bt5.Location = new System.Drawing.Point(90, 334);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(81, 78);
            this.bt5.TabIndex = 3;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // btnInverterSinal
            // 
            this.btnInverterSinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInverterSinal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInverterSinal.FlatAppearance.BorderSize = 0;
            this.btnInverterSinal.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btnInverterSinal.Location = new System.Drawing.Point(3, 502);
            this.btnInverterSinal.Name = "btnInverterSinal";
            this.btnInverterSinal.Size = new System.Drawing.Size(81, 79);
            this.btnInverterSinal.TabIndex = 3;
            this.btnInverterSinal.Text = "±";
            this.btnInverterSinal.UseVisualStyleBackColor = false;
            this.btnInverterSinal.Click += new System.EventHandler(this.btnInverterSinal_Click);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt0.FlatAppearance.BorderSize = 0;
            this.bt0.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.bt0.Location = new System.Drawing.Point(90, 502);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(81, 79);
            this.bt0.TabIndex = 3;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btBackspace
            // 
            this.btBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btBackspace.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btBackspace.FlatAppearance.BorderSize = 0;
            this.btBackspace.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.btBackspace.Location = new System.Drawing.Point(264, 82);
            this.btBackspace.Name = "btBackspace";
            this.btBackspace.Size = new System.Drawing.Size(81, 78);
            this.btBackspace.TabIndex = 4;
            this.btBackspace.Text = "BAK";
            this.btBackspace.UseVisualStyleBackColor = false;
            this.btBackspace.Click += new System.EventHandler(this.btBackspace_Click);
            // 
            // menuSair
            // 
            this.menuSair.BackColor = System.Drawing.Color.Gray;
            this.menuSair.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRQUIVOToolStripMenuItem});
            this.menuSair.Location = new System.Drawing.Point(5, 5);
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(512, 24);
            this.menuSair.TabIndex = 5;
            this.menuSair.Text = "ARQUIVO";
            this.menuSair.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuSair_ItemClicked);
            // 
            // aRQUIVOToolStripMenuItem
            // 
            this.aRQUIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmSair});
            this.aRQUIVOToolStripMenuItem.Name = "aRQUIVOToolStripMenuItem";
            this.aRQUIVOToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aRQUIVOToolStripMenuItem.Text = "ARQUIVO";
            // 
            // mmSair
            // 
            this.mmSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mmSair.Name = "mmSair";
            this.mmSair.Size = new System.Drawing.Size(180, 22);
            this.mmSair.Text = "SAIR";
            this.mmSair.Click += new System.EventHandler(this.mmSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(522, 583);
            this.Controls.Add(this.btTangente);
            this.Controls.Add(this.btPi);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.btLog);
            this.Controls.Add(this.btRaiz);
            this.Controls.Add(this.btCosseno);
            this.Controls.Add(this.btBackspace);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btSeno);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.btsubtrair);
            this.Controls.Add(this.btMultiplicacao);
            this.Controls.Add(this.btPonto);
            this.Controls.Add(this.btdivisao);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btnInverterSinal);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btQuadrado);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btCe);
            this.Controls.Add(this.btFracao);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.btPorcentagem);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.lbVisor);
            this.Controls.Add(this.menuSair);
            this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuSair;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuSair.ResumeLayout(false);
            this.menuSair.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVisor;
        private System.Windows.Forms.Button btSeno;
        private System.Windows.Forms.Button btLog;
        private System.Windows.Forms.Button btTangente;
        private System.Windows.Forms.Button btPi;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btCosseno;
        private System.Windows.Forms.Button btRaiz;
        private System.Windows.Forms.Button btdivisao;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btPorcentagem;
        private System.Windows.Forms.Button btCe;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button btMultiplicacao;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btsubtrair;
        private System.Windows.Forms.Button btPonto;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btFracao;
        private System.Windows.Forms.Button btQuadrado;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button btnInverterSinal;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btBackspace;
        private System.Windows.Forms.MenuStrip menuSair;
        private System.Windows.Forms.ToolStripMenuItem aRQUIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmSair;
    }
}

