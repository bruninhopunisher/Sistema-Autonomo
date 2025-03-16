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
            this.lblConstIdJogadorLogado = new System.Windows.Forms.Label();
            this.lblConstSenhaJogadorLogado = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCartasSorteadas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAltNomePartida = new System.Windows.Forms.Label();
            this.lblAltStatusPartida = new System.Windows.Forms.Label();
            this.lblAltPontuacao = new System.Windows.Forms.Label();
            this.dgvPersonagens = new System.Windows.Forms.DataGridView();
            this.btnAltPosicionarPersonagem = new System.Windows.Forms.Button();
            this.lstSetores = new System.Windows.Forms.ListBox();
            this.btnConstVerificarVez = new System.Windows.Forms.Button();
            this.lstTabuleiroDoJogo = new System.Windows.Forms.ListBox();
            this.lblConstMostrarVez = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonagens)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConstIdJogadorLogado
            // 
            this.lblConstIdJogadorLogado.AutoSize = true;
            this.lblConstIdJogadorLogado.Location = new System.Drawing.Point(130, 39);
            this.lblConstIdJogadorLogado.Name = "lblConstIdJogadorLogado";
            this.lblConstIdJogadorLogado.Size = new System.Drawing.Size(0, 16);
            this.lblConstIdJogadorLogado.TabIndex = 0;
            // 
            // lblConstSenhaJogadorLogado
            // 
            this.lblConstSenhaJogadorLogado.AutoSize = true;
            this.lblConstSenhaJogadorLogado.Location = new System.Drawing.Point(130, 71);
            this.lblConstSenhaJogadorLogado.Name = "lblConstSenhaJogadorLogado";
            this.lblConstSenhaJogadorLogado.Size = new System.Drawing.Size(0, 16);
            this.lblConstSenhaJogadorLogado.TabIndex = 1;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(20, 105);
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
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha Jogador";
            // 
            // lstCartasSorteadas
            // 
            this.lstCartasSorteadas.FormattingEnabled = true;
            this.lstCartasSorteadas.ItemHeight = 16;
            this.lstCartasSorteadas.Location = new System.Drawing.Point(197, 38);
            this.lstCartasSorteadas.Name = "lstCartasSorteadas";
            this.lstCartasSorteadas.Size = new System.Drawing.Size(168, 148);
            this.lstCartasSorteadas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Minhas Cartas";
            // 
            // lblAltNomePartida
            // 
            this.lblAltNomePartida.AutoSize = true;
            this.lblAltNomePartida.Location = new System.Drawing.Point(24, 249);
            this.lblAltNomePartida.Name = "lblAltNomePartida";
            this.lblAltNomePartida.Size = new System.Drawing.Size(87, 16);
            this.lblAltNomePartida.TabIndex = 8;
            this.lblAltNomePartida.Text = "NomePartida";
            // 
            // lblAltStatusPartida
            // 
            this.lblAltStatusPartida.AutoSize = true;
            this.lblAltStatusPartida.Location = new System.Drawing.Point(24, 299);
            this.lblAltStatusPartida.Name = "lblAltStatusPartida";
            this.lblAltStatusPartida.Size = new System.Drawing.Size(87, 16);
            this.lblAltStatusPartida.TabIndex = 9;
            this.lblAltStatusPartida.Text = "StatusPartida";
            // 
            // lblAltPontuacao
            // 
            this.lblAltPontuacao.AutoSize = true;
            this.lblAltPontuacao.Location = new System.Drawing.Point(25, 343);
            this.lblAltPontuacao.Name = "lblAltPontuacao";
            this.lblAltPontuacao.Size = new System.Drawing.Size(72, 16);
            this.lblAltPontuacao.TabIndex = 10;
            this.lblAltPontuacao.Text = "Pontuacao";
            // 
            // dgvPersonagens
            // 
            this.dgvPersonagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonagens.Location = new System.Drawing.Point(500, 38);
            this.dgvPersonagens.Name = "dgvPersonagens";
            this.dgvPersonagens.RowHeadersWidth = 51;
            this.dgvPersonagens.RowTemplate.Height = 24;
            this.dgvPersonagens.Size = new System.Drawing.Size(534, 360);
            this.dgvPersonagens.TabIndex = 11;
            // 
            // btnAltPosicionarPersonagem
            // 
            this.btnAltPosicionarPersonagem.Location = new System.Drawing.Point(744, 402);
            this.btnAltPosicionarPersonagem.Name = "btnAltPosicionarPersonagem";
            this.btnAltPosicionarPersonagem.Size = new System.Drawing.Size(219, 23);
            this.btnAltPosicionarPersonagem.TabIndex = 12;
            this.btnAltPosicionarPersonagem.Text = "Posicionar Personagem";
            this.btnAltPosicionarPersonagem.UseVisualStyleBackColor = true;
            this.btnAltPosicionarPersonagem.Click += new System.EventHandler(this.btnAltPosicionarPersonagem_Click);
            // 
            // lstSetores
            // 
            this.lstSetores.FormattingEnabled = true;
            this.lstSetores.ItemHeight = 16;
            this.lstSetores.Location = new System.Drawing.Point(197, 249);
            this.lstSetores.Name = "lstSetores";
            this.lstSetores.Size = new System.Drawing.Size(120, 116);
            this.lstSetores.TabIndex = 14;
            // 
            // btnConstVerificarVez
            // 
            this.btnConstVerificarVez.Location = new System.Drawing.Point(588, 402);
            this.btnConstVerificarVez.Name = "btnConstVerificarVez";
            this.btnConstVerificarVez.Size = new System.Drawing.Size(120, 23);
            this.btnConstVerificarVez.TabIndex = 15;
            this.btnConstVerificarVez.Text = "Verificar vez";
            this.btnConstVerificarVez.UseVisualStyleBackColor = true;
            this.btnConstVerificarVez.Click += new System.EventHandler(this.btnAltAtualizarLista_Click);
            // 
            // lstTabuleiroDoJogo
            // 
            this.lstTabuleiroDoJogo.FormattingEnabled = true;
            this.lstTabuleiroDoJogo.ItemHeight = 16;
            this.lstTabuleiroDoJogo.Location = new System.Drawing.Point(351, 249);
            this.lstTabuleiroDoJogo.Name = "lstTabuleiroDoJogo";
            this.lstTabuleiroDoJogo.Size = new System.Drawing.Size(120, 116);
            this.lstTabuleiroDoJogo.TabIndex = 16;
            // 
            // lblConstMostrarVez
            // 
            this.lblConstMostrarVez.AutoSize = true;
            this.lblConstMostrarVez.Location = new System.Drawing.Point(346, 230);
            this.lblConstMostrarVez.Name = "lblConstMostrarVez";
            this.lblConstMostrarVez.Size = new System.Drawing.Size(0, 16);
            this.lblConstMostrarVez.TabIndex = 17;
            // 
            // LobbyPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 545);
            this.Controls.Add(this.lblConstMostrarVez);
            this.Controls.Add(this.lstTabuleiroDoJogo);
            this.Controls.Add(this.btnConstVerificarVez);
            this.Controls.Add(this.lstSetores);
            this.Controls.Add(this.btnAltPosicionarPersonagem);
            this.Controls.Add(this.dgvPersonagens);
            this.Controls.Add(this.lblAltPontuacao);
            this.Controls.Add(this.lblAltStatusPartida);
            this.Controls.Add(this.lblAltNomePartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCartasSorteadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblConstSenhaJogadorLogado);
            this.Controls.Add(this.lblConstIdJogadorLogado);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1083, 592);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1083, 592);
            this.Name = "LobbyPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LobbyPartida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConstIdJogadorLogado;
        private System.Windows.Forms.Label lblConstSenhaJogadorLogado;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCartasSorteadas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAltNomePartida;
        private System.Windows.Forms.Label lblAltStatusPartida;
        private System.Windows.Forms.Label lblAltPontuacao;
        private System.Windows.Forms.DataGridView dgvPersonagens;
        private System.Windows.Forms.Button btnAltPosicionarPersonagem;
        private System.Windows.Forms.ListBox lstSetores;
        private System.Windows.Forms.Button btnConstVerificarVez;
        private System.Windows.Forms.ListBox lstTabuleiroDoJogo;
        private System.Windows.Forms.Label lblConstMostrarVez;
    }
}