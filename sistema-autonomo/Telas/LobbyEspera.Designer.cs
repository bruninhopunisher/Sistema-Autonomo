namespace sistema_autonomo
{
    partial class LobbyEspera
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
            this.lblAltNomePartida = new System.Windows.Forms.Label();
            this.lblAltStatusPartida = new System.Windows.Forms.Label();
            this.lblAltPontuacao = new System.Windows.Forms.Label();
            this.dgvPersonagens = new System.Windows.Forms.DataGridView();
            this.lblVersaoDoJogo = new System.Windows.Forms.Label();
            this.lblNomeDoGrupo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonagens)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConstIdJogadorLogado
            // 
            this.lblConstIdJogadorLogado.AutoSize = true;
            this.lblConstIdJogadorLogado.Location = new System.Drawing.Point(294, 144);
            this.lblConstIdJogadorLogado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConstIdJogadorLogado.Name = "lblConstIdJogadorLogado";
            this.lblConstIdJogadorLogado.Size = new System.Drawing.Size(0, 13);
            this.lblConstIdJogadorLogado.TabIndex = 0;
            // 
            // lblConstSenhaJogadorLogado
            // 
            this.lblConstSenhaJogadorLogado.AutoSize = true;
            this.lblConstSenhaJogadorLogado.Location = new System.Drawing.Point(294, 170);
            this.lblConstSenhaJogadorLogado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConstSenhaJogadorLogado.Name = "lblConstSenhaJogadorLogado";
            this.lblConstSenhaJogadorLogado.Size = new System.Drawing.Size(0, 13);
            this.lblConstSenhaJogadorLogado.TabIndex = 1;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(211, 197);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(2);
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
            this.label1.Location = new System.Drawing.Point(214, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha Jogador";
            // 
            // lblAltNomePartida
            // 
            this.lblAltNomePartida.AutoSize = true;
            this.lblAltNomePartida.Location = new System.Drawing.Point(214, 306);
            this.lblAltNomePartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltNomePartida.Name = "lblAltNomePartida";
            this.lblAltNomePartida.Size = new System.Drawing.Size(68, 13);
            this.lblAltNomePartida.TabIndex = 8;
            this.lblAltNomePartida.Text = "NomePartida";
            // 
            // lblAltStatusPartida
            // 
            this.lblAltStatusPartida.AutoSize = true;
            this.lblAltStatusPartida.Location = new System.Drawing.Point(214, 347);
            this.lblAltStatusPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltStatusPartida.Name = "lblAltStatusPartida";
            this.lblAltStatusPartida.Size = new System.Drawing.Size(70, 13);
            this.lblAltStatusPartida.TabIndex = 9;
            this.lblAltStatusPartida.Text = "StatusPartida";
            // 
            // lblAltPontuacao
            // 
            this.lblAltPontuacao.AutoSize = true;
            this.lblAltPontuacao.Location = new System.Drawing.Point(215, 383);
            this.lblAltPontuacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltPontuacao.Name = "lblAltPontuacao";
            this.lblAltPontuacao.Size = new System.Drawing.Size(59, 13);
            this.lblAltPontuacao.TabIndex = 10;
            this.lblAltPontuacao.Text = "Pontuacao";
            // 
            // dgvPersonagens
            // 
            this.dgvPersonagens.AllowUserToDeleteRows = false;
            this.dgvPersonagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonagens.Location = new System.Drawing.Point(457, 157);
            this.dgvPersonagens.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPersonagens.Name = "dgvPersonagens";
            this.dgvPersonagens.RowHeadersWidth = 51;
            this.dgvPersonagens.RowTemplate.Height = 24;
            this.dgvPersonagens.Size = new System.Drawing.Size(400, 292);
            this.dgvPersonagens.TabIndex = 11;
            // 
            // lblVersaoDoJogo
            // 
            this.lblVersaoDoJogo.AutoSize = true;
            this.lblVersaoDoJogo.Location = new System.Drawing.Point(1153, 634);
            this.lblVersaoDoJogo.Name = "lblVersaoDoJogo";
            this.lblVersaoDoJogo.Size = new System.Drawing.Size(0, 13);
            this.lblVersaoDoJogo.TabIndex = 12;
            // 
            // lblNomeDoGrupo
            // 
            this.lblNomeDoGrupo.AutoSize = true;
            this.lblNomeDoGrupo.Location = new System.Drawing.Point(1015, 634);
            this.lblNomeDoGrupo.Name = "lblNomeDoGrupo";
            this.lblNomeDoGrupo.Size = new System.Drawing.Size(0, 13);
            this.lblNomeDoGrupo.TabIndex = 13;
            // 
            // LobbyEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblNomeDoGrupo);
            this.Controls.Add(this.lblVersaoDoJogo);
            this.Controls.Add(this.dgvPersonagens);
            this.Controls.Add(this.lblAltPontuacao);
            this.Controls.Add(this.lblAltStatusPartida);
            this.Controls.Add(this.lblAltNomePartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblConstSenhaJogadorLogado);
            this.Controls.Add(this.lblConstIdJogadorLogado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 488);
            this.Name = "LobbyEspera";
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
        private System.Windows.Forms.Label lblAltNomePartida;
        private System.Windows.Forms.Label lblAltStatusPartida;
        private System.Windows.Forms.Label lblAltPontuacao;
        private System.Windows.Forms.DataGridView dgvPersonagens;
        private System.Windows.Forms.Label lblVersaoDoJogo;
        private System.Windows.Forms.Label lblNomeDoGrupo;
    }
}