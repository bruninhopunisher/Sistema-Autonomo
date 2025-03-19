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
            this.lblConstIdJogadorLogado.Location = new System.Drawing.Point(98, 32);
            this.lblConstIdJogadorLogado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConstIdJogadorLogado.Name = "lblConstIdJogadorLogado";
            this.lblConstIdJogadorLogado.Size = new System.Drawing.Size(0, 13);
            this.lblConstIdJogadorLogado.TabIndex = 0;
            // 
            // lblConstSenhaJogadorLogado
            // 
            this.lblConstSenhaJogadorLogado.AutoSize = true;
            this.lblConstSenhaJogadorLogado.Location = new System.Drawing.Point(98, 58);
            this.lblConstSenhaJogadorLogado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConstSenhaJogadorLogado.Name = "lblConstSenhaJogadorLogado";
            this.lblConstSenhaJogadorLogado.Size = new System.Drawing.Size(0, 13);
            this.lblConstSenhaJogadorLogado.TabIndex = 1;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(15, 85);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(82, 26);
            this.btnIniciarPartida.TabIndex = 2;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha Jogador";
            // 
            // lstCartasSorteadas
            // 
            this.lstCartasSorteadas.FormattingEnabled = true;
            this.lstCartasSorteadas.Location = new System.Drawing.Point(148, 31);
            this.lstCartasSorteadas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCartasSorteadas.Name = "lstCartasSorteadas";
            this.lstCartasSorteadas.Size = new System.Drawing.Size(127, 121);
            this.lstCartasSorteadas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Minhas Cartas";
            // 
            // lblAltNomePartida
            // 
            this.lblAltNomePartida.AutoSize = true;
            this.lblAltNomePartida.Location = new System.Drawing.Point(18, 202);
            this.lblAltNomePartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltNomePartida.Name = "lblAltNomePartida";
            this.lblAltNomePartida.Size = new System.Drawing.Size(68, 13);
            this.lblAltNomePartida.TabIndex = 8;
            this.lblAltNomePartida.Text = "NomePartida";
            // 
            // lblAltStatusPartida
            // 
            this.lblAltStatusPartida.AutoSize = true;
            this.lblAltStatusPartida.Location = new System.Drawing.Point(18, 243);
            this.lblAltStatusPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltStatusPartida.Name = "lblAltStatusPartida";
            this.lblAltStatusPartida.Size = new System.Drawing.Size(70, 13);
            this.lblAltStatusPartida.TabIndex = 9;
            this.lblAltStatusPartida.Text = "StatusPartida";
            // 
            // lblAltPontuacao
            // 
            this.lblAltPontuacao.AutoSize = true;
            this.lblAltPontuacao.Location = new System.Drawing.Point(19, 279);
            this.lblAltPontuacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltPontuacao.Name = "lblAltPontuacao";
            this.lblAltPontuacao.Size = new System.Drawing.Size(59, 13);
            this.lblAltPontuacao.TabIndex = 10;
            this.lblAltPontuacao.Text = "Pontuacao";
            // 
            // dgvPersonagens
            // 
            this.dgvPersonagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonagens.Location = new System.Drawing.Point(375, 31);
            this.dgvPersonagens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPersonagens.Name = "dgvPersonagens";
            this.dgvPersonagens.RowHeadersWidth = 51;
            this.dgvPersonagens.RowTemplate.Height = 24;
            this.dgvPersonagens.Size = new System.Drawing.Size(400, 292);
            this.dgvPersonagens.TabIndex = 11;
            // 
            // btnAltPosicionarPersonagem
            // 
            this.btnAltPosicionarPersonagem.Location = new System.Drawing.Point(558, 327);
            this.btnAltPosicionarPersonagem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAltPosicionarPersonagem.Name = "btnAltPosicionarPersonagem";
            this.btnAltPosicionarPersonagem.Size = new System.Drawing.Size(164, 19);
            this.btnAltPosicionarPersonagem.TabIndex = 12;
            this.btnAltPosicionarPersonagem.Text = "Posicionar Personagem";
            this.btnAltPosicionarPersonagem.UseVisualStyleBackColor = true;
            this.btnAltPosicionarPersonagem.Click += new System.EventHandler(this.btnAltPosicionarPersonagem_Click);
            // 
            // lstSetores
            // 
            this.lstSetores.FormattingEnabled = true;
            this.lstSetores.Location = new System.Drawing.Point(148, 202);
            this.lstSetores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstSetores.Name = "lstSetores";
            this.lstSetores.Size = new System.Drawing.Size(91, 95);
            this.lstSetores.TabIndex = 14;
            // 
            // btnConstVerificarVez
            // 
            this.btnConstVerificarVez.Location = new System.Drawing.Point(441, 327);
            this.btnConstVerificarVez.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConstVerificarVez.Name = "btnConstVerificarVez";
            this.btnConstVerificarVez.Size = new System.Drawing.Size(90, 19);
            this.btnConstVerificarVez.TabIndex = 15;
            this.btnConstVerificarVez.Text = "Verificar vez";
            this.btnConstVerificarVez.UseVisualStyleBackColor = true;
            this.btnConstVerificarVez.Click += new System.EventHandler(this.btnAltAtualizarLista_Click);
            // 
            // lstTabuleiroDoJogo
            // 
            this.lstTabuleiroDoJogo.FormattingEnabled = true;
            this.lstTabuleiroDoJogo.Location = new System.Drawing.Point(263, 202);
            this.lstTabuleiroDoJogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstTabuleiroDoJogo.Name = "lstTabuleiroDoJogo";
            this.lstTabuleiroDoJogo.Size = new System.Drawing.Size(91, 95);
            this.lstTabuleiroDoJogo.TabIndex = 16;
            // 
            // lblConstMostrarVez
            // 
            this.lblConstMostrarVez.AutoSize = true;
            this.lblConstMostrarVez.Location = new System.Drawing.Point(250, 185);
            this.lblConstMostrarVez.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConstMostrarVez.Name = "lblConstMostrarVez";
            this.lblConstMostrarVez.Size = new System.Drawing.Size(0, 13);
            this.lblConstMostrarVez.TabIndex = 17;
            // 
            // LobbyPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 488);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 488);
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