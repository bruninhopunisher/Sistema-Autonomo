namespace sistema_autonomo
{
    partial class LobbyPartida
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
            this.lblIdJogadorLogado = new System.Windows.Forms.Label();
            this.lblSenhaJogadorLogado = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCartasSorteadas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblStatusPartida = new System.Windows.Forms.Label();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIdJogadorLogado
            // 
            this.lblIdJogadorLogado.AutoSize = true;
            this.lblIdJogadorLogado.Location = new System.Drawing.Point(130, 39);
            this.lblIdJogadorLogado.Name = "lblIdJogadorLogado";
            this.lblIdJogadorLogado.Size = new System.Drawing.Size(44, 16);
            this.lblIdJogadorLogado.TabIndex = 0;
            this.lblIdJogadorLogado.Text = "label1";
            // 
            // lblSenhaJogadorLogado
            // 
            this.lblSenhaJogadorLogado.AutoSize = true;
            this.lblSenhaJogadorLogado.Location = new System.Drawing.Point(130, 102);
            this.lblSenhaJogadorLogado.Name = "lblSenhaJogadorLogado";
            this.lblSenhaJogadorLogado.Size = new System.Drawing.Size(44, 16);
            this.lblSenhaJogadorLogado.TabIndex = 1;
            this.lblSenhaJogadorLogado.Text = "label2";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(27, 154);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(110, 32);
            this.btnIniciarPartida.TabIndex = 2;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha Jogador";
            // 
            // lstCartasSorteadas
            // 
            this.lstCartasSorteadas.FormattingEnabled = true;
            this.lstCartasSorteadas.ItemHeight = 16;
            this.lstCartasSorteadas.Location = new System.Drawing.Point(229, 38);
            this.lstCartasSorteadas.Name = "lstCartasSorteadas";
            this.lstCartasSorteadas.Size = new System.Drawing.Size(168, 148);
            this.lstCartasSorteadas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Minhas Cartas";
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(24, 249);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(44, 16);
            this.lblNomePartida.TabIndex = 8;
            this.lblNomePartida.Text = "label4";
            // 
            // lblStatusPartida
            // 
            this.lblStatusPartida.AutoSize = true;
            this.lblStatusPartida.Location = new System.Drawing.Point(24, 299);
            this.lblStatusPartida.Name = "lblStatusPartida";
            this.lblStatusPartida.Size = new System.Drawing.Size(44, 16);
            this.lblStatusPartida.TabIndex = 9;
            this.lblStatusPartida.Text = "label4";
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Location = new System.Drawing.Point(25, 343);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(44, 16);
            this.lblPontuacao.TabIndex = 10;
            this.lblPontuacao.Text = "label4";
            // 
            // LobbyPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 545);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.lblStatusPartida);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCartasSorteadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblSenhaJogadorLogado);
            this.Controls.Add(this.lblIdJogadorLogado);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1083, 592);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1083, 592);
            this.Name = "LobbyPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LobbyPartida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdJogadorLogado;
        private System.Windows.Forms.Label lblSenhaJogadorLogado;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCartasSorteadas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblStatusPartida;
        private System.Windows.Forms.Label lblPontuacao;
    }
}