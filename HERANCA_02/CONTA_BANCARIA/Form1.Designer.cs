namespace CONTA_BANCARIA
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
            this.txtConta = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimularDepositos = new System.Windows.Forms.Button();
            this.btnSimularSaques = new System.Windows.Forms.Button();
            this.lbOcorrencias = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO DA CONTA:";
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(9, 37);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(305, 31);
            this.txtConta.TabIndex = 1;
            this.txtConta.Text = "0";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(341, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(797, 77);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lbSaldo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbTipo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(9, 127);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1129, 255);
            this.panel1.TabIndex = 3;
            // 
            // lbSaldo
            // 
            this.lbSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSaldo.Location = new System.Drawing.Point(713, 120);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(407, 38);
            this.lbSaldo.TabIndex = 0;
            this.lbSaldo.Text = "R$ 0,00";
            this.lbSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(709, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "SALDO ATUAL:";
            // 
            // lbTipo
            // 
            this.lbTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTipo.Location = new System.Drawing.Point(8, 196);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(1112, 38);
            this.lbTipo.TabIndex = 0;
            this.lbTipo.Text = "TIPO";
            this.lbTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "TIPO DA CONTA:";
            // 
            // lbCliente
            // 
            this.lbCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCliente.Location = new System.Drawing.Point(8, 120);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(699, 38);
            this.lbCliente.TabIndex = 0;
            this.lbCliente.Text = "NOME DO CLIENTE";
            this.lbCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "CLIENTE:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "DADOS DA CONTA";
            // 
            // btnSimularDepositos
            // 
            this.btnSimularDepositos.Location = new System.Drawing.Point(7, 408);
            this.btnSimularDepositos.Name = "btnSimularDepositos";
            this.btnSimularDepositos.Size = new System.Drawing.Size(375, 74);
            this.btnSimularDepositos.TabIndex = 4;
            this.btnSimularDepositos.Text = " SIMULAR DEPÓSITOS";
            this.btnSimularDepositos.UseVisualStyleBackColor = true;
            this.btnSimularDepositos.Click += new System.EventHandler(this.btnSimularDepositos_Click);
            // 
            // btnSimularSaques
            // 
            this.btnSimularSaques.Location = new System.Drawing.Point(670, 408);
            this.btnSimularSaques.Name = "btnSimularSaques";
            this.btnSimularSaques.Size = new System.Drawing.Size(459, 74);
            this.btnSimularSaques.TabIndex = 4;
            this.btnSimularSaques.Text = " SIMULAR SAQUES";
            this.btnSimularSaques.UseVisualStyleBackColor = true;
            this.btnSimularSaques.Click += new System.EventHandler(this.btnSimularSaques_Click);
            // 
            // lbOcorrencias
            // 
            this.lbOcorrencias.BackColor = System.Drawing.Color.LightGray;
            this.lbOcorrencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbOcorrencias.Location = new System.Drawing.Point(9, 485);
            this.lbOcorrencias.Name = "lbOcorrencias";
            this.lbOcorrencias.Size = new System.Drawing.Size(1120, 189);
            this.lbOcorrencias.TabIndex = 5;
            this.lbOcorrencias.Text = "OCORRÊNCIAS";
            this.lbOcorrencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1144, 679);
            this.Controls.Add(this.lbOcorrencias);
            this.Controls.Add(this.btnSimularSaques);
            this.Controls.Add(this.btnSimularDepositos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BANCO SEM NOME SA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSimularDepositos;
        private System.Windows.Forms.Button btnSimularSaques;
        private System.Windows.Forms.Label lbOcorrencias;
    }
}

