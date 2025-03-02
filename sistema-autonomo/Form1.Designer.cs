namespace sistema_autonomo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.lstListaDePartidas = new System.Windows.Forms.ListBox();
            this.label04 = new System.Windows.Forms.Label();
            this.label05 = new System.Windows.Forms.Label();
            this.lblIdPartidaSelecionada = new System.Windows.Forms.Label();
            this.label07 = new System.Windows.Forms.Label();
            this.label08 = new System.Windows.Forms.Label();
            this.lblNomePartidaSelecionada = new System.Windows.Forms.Label();
            this.lblDataPartidaSelecionada = new System.Windows.Forms.Label();
            this.label09 = new System.Windows.Forms.Label();
            this.lblStatusPartidaSelecionada = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label06 = new System.Windows.Forms.Label();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lblVersaoJogo = new System.Windows.Forms.Label();
            this.cboFiltrarPartidas = new System.Windows.Forms.ComboBox();
            this.txtInputNomePartida = new System.Windows.Forms.TextBox();
            this.label01 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.txtInputSenhaPartida = new System.Windows.Forms.TextBox();
            this.label03 = new System.Windows.Forms.Label();
            this.txtInputNomeGrupo = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(38, 241);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(84, 27);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lstListaDePartidas
            // 
            this.lstListaDePartidas.FormattingEnabled = true;
            this.lstListaDePartidas.Location = new System.Drawing.Point(39, 296);
            this.lstListaDePartidas.Name = "lstListaDePartidas";
            this.lstListaDePartidas.Size = new System.Drawing.Size(186, 121);
            this.lstListaDePartidas.TabIndex = 2;
            this.lstListaDePartidas.SelectedIndexChanged += new System.EventHandler(this.lstListaDePartidas_SelectedIndexChanged);
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label04.Location = new System.Drawing.Point(35, 271);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(139, 18);
            this.label04.TabIndex = 3;
            this.label04.Text = "Selecione a Partida:";
            // 
            // label05
            // 
            this.label05.AutoSize = true;
            this.label05.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label05.Location = new System.Drawing.Point(281, 270);
            this.label05.Name = "label05";
            this.label05.Size = new System.Drawing.Size(156, 20);
            this.label05.TabIndex = 4;
            this.label05.Text = "Informações Partida:";
            // 
            // lblIdPartidaSelecionada
            // 
            this.lblIdPartidaSelecionada.AutoSize = true;
            this.lblIdPartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPartidaSelecionada.Location = new System.Drawing.Point(301, 304);
            this.lblIdPartidaSelecionada.Name = "lblIdPartidaSelecionada";
            this.lblIdPartidaSelecionada.Size = new System.Drawing.Size(61, 16);
            this.lblIdPartidaSelecionada.TabIndex = 5;
            this.lblIdPartidaSelecionada.Text = "recebeid";
            // 
            // label07
            // 
            this.label07.AutoSize = true;
            this.label07.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label07.Location = new System.Drawing.Point(281, 304);
            this.label07.Name = "label07";
            this.label07.Size = new System.Drawing.Size(23, 16);
            this.label07.TabIndex = 6;
            this.label07.Text = "ID:";
            // 
            // label08
            // 
            this.label08.AccessibleDescription = "partida";
            this.label08.AutoSize = true;
            this.label08.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label08.Location = new System.Drawing.Point(281, 336);
            this.label08.Name = "label08";
            this.label08.Size = new System.Drawing.Size(53, 16);
            this.label08.TabIndex = 7;
            this.label08.Text = "NOME: ";
            // 
            // lblNomePartidaSelecionada
            // 
            this.lblNomePartidaSelecionada.AutoSize = true;
            this.lblNomePartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartidaSelecionada.Location = new System.Drawing.Point(329, 337);
            this.lblNomePartidaSelecionada.Name = "lblNomePartidaSelecionada";
            this.lblNomePartidaSelecionada.Size = new System.Drawing.Size(44, 16);
            this.lblNomePartidaSelecionada.TabIndex = 8;
            this.lblNomePartidaSelecionada.Text = "label2";
            // 
            // lblDataPartidaSelecionada
            // 
            this.lblDataPartidaSelecionada.AutoSize = true;
            this.lblDataPartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPartidaSelecionada.Location = new System.Drawing.Point(323, 366);
            this.lblDataPartidaSelecionada.Name = "lblDataPartidaSelecionada";
            this.lblDataPartidaSelecionada.Size = new System.Drawing.Size(44, 16);
            this.lblDataPartidaSelecionada.TabIndex = 10;
            this.lblDataPartidaSelecionada.Text = "label2";
            // 
            // label09
            // 
            this.label09.AccessibleDescription = "partida";
            this.label09.AutoSize = true;
            this.label09.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label09.Location = new System.Drawing.Point(281, 365);
            this.label09.Name = "label09";
            this.label09.Size = new System.Drawing.Size(50, 16);
            this.label09.TabIndex = 9;
            this.label09.Text = "DATA: ";
            // 
            // lblStatusPartidaSelecionada
            // 
            this.lblStatusPartidaSelecionada.AutoSize = true;
            this.lblStatusPartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPartidaSelecionada.Location = new System.Drawing.Point(342, 393);
            this.lblStatusPartidaSelecionada.Name = "lblStatusPartidaSelecionada";
            this.lblStatusPartidaSelecionada.Size = new System.Drawing.Size(44, 16);
            this.lblStatusPartidaSelecionada.TabIndex = 12;
            this.lblStatusPartidaSelecionada.Text = "label2";
            // 
            // label10
            // 
            this.label10.AccessibleDescription = "partida";
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(281, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "STATUS:";
            // 
            // label06
            // 
            this.label06.AutoSize = true;
            this.label06.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label06.Location = new System.Drawing.Point(555, 270);
            this.label06.Name = "label06";
            this.label06.Size = new System.Drawing.Size(88, 20);
            this.label06.TabIndex = 13;
            this.label06.Text = "Jogadores:";
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.Location = new System.Drawing.Point(559, 296);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(207, 134);
            this.lstJogadores.TabIndex = 14;
            // 
            // lblVersaoJogo
            // 
            this.lblVersaoJogo.AutoSize = true;
            this.lblVersaoJogo.Location = new System.Drawing.Point(754, 425);
            this.lblVersaoJogo.Name = "lblVersaoJogo";
            this.lblVersaoJogo.Size = new System.Drawing.Size(0, 13);
            this.lblVersaoJogo.TabIndex = 15;
            // 
            // cboFiltrarPartidas
            // 
            this.cboFiltrarPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltrarPartidas.FormattingEnabled = true;
            this.cboFiltrarPartidas.Location = new System.Drawing.Point(129, 244);
            this.cboFiltrarPartidas.Name = "cboFiltrarPartidas";
            this.cboFiltrarPartidas.Size = new System.Drawing.Size(96, 21);
            this.cboFiltrarPartidas.TabIndex = 16;
            this.cboFiltrarPartidas.Tag = "0";
            // 
            // txtInputNomePartida
            // 
            this.txtInputNomePartida.Location = new System.Drawing.Point(40, 37);
            this.txtInputNomePartida.MaxLength = 15;
            this.txtInputNomePartida.Name = "txtInputNomePartida";
            this.txtInputNomePartida.Size = new System.Drawing.Size(147, 20);
            this.txtInputNomePartida.TabIndex = 2;
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Location = new System.Drawing.Point(43, 14);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(86, 13);
            this.label01.TabIndex = 18;
            this.label01.Text = "Nome da Partida";
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(42, 72);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(89, 13);
            this.label02.TabIndex = 20;
            this.label02.Text = "Senha da Partida";
            // 
            // txtInputSenhaPartida
            // 
            this.txtInputSenhaPartida.Location = new System.Drawing.Point(39, 95);
            this.txtInputSenhaPartida.MaxLength = 10;
            this.txtInputSenhaPartida.Name = "txtInputSenhaPartida";
            this.txtInputSenhaPartida.Size = new System.Drawing.Size(147, 20);
            this.txtInputSenhaPartida.TabIndex = 19;
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.Location = new System.Drawing.Point(42, 131);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(82, 13);
            this.label03.TabIndex = 22;
            this.label03.Text = "Nome do Grupo";
            // 
            // txtInputNomeGrupo
            // 
            this.txtInputNomeGrupo.Location = new System.Drawing.Point(39, 154);
            this.txtInputNomeGrupo.MaxLength = 20;
            this.txtInputNomeGrupo.Name = "txtInputNomeGrupo";
            this.txtInputNomeGrupo.Size = new System.Drawing.Size(147, 20);
            this.txtInputNomeGrupo.TabIndex = 21;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(40, 189);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(91, 28);
            this.btnCriarPartida.TabIndex = 23;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 451);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.label03);
            this.Controls.Add(this.txtInputNomeGrupo);
            this.Controls.Add(this.label02);
            this.Controls.Add(this.txtInputSenhaPartida);
            this.Controls.Add(this.label01);
            this.Controls.Add(this.txtInputNomePartida);
            this.Controls.Add(this.cboFiltrarPartidas);
            this.Controls.Add(this.lblVersaoJogo);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.label06);
            this.Controls.Add(this.lblStatusPartidaSelecionada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblDataPartidaSelecionada);
            this.Controls.Add(this.label09);
            this.Controls.Add(this.lblNomePartidaSelecionada);
            this.Controls.Add(this.label08);
            this.Controls.Add(this.label07);
            this.Controls.Add(this.lblIdPartidaSelecionada);
            this.Controls.Add(this.label05);
            this.Controls.Add(this.label04);
            this.Controls.Add(this.lstListaDePartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(817, 490);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(817, 490);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KingMe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ListBox lstListaDePartidas;
        private System.Windows.Forms.Label label04;
        private System.Windows.Forms.Label label05;
        private System.Windows.Forms.Label lblIdPartidaSelecionada;
        private System.Windows.Forms.Label label07;
        private System.Windows.Forms.Label label08;
        private System.Windows.Forms.Label lblNomePartidaSelecionada;
        private System.Windows.Forms.Label lblDataPartidaSelecionada;
        private System.Windows.Forms.Label label09;
        private System.Windows.Forms.Label lblStatusPartidaSelecionada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label06;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label lblVersaoJogo;
        private System.Windows.Forms.ComboBox cboFiltrarPartidas;
        private System.Windows.Forms.TextBox txtInputNomePartida;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.TextBox txtInputSenhaPartida;
        private System.Windows.Forms.Label label03;
        private System.Windows.Forms.TextBox txtInputNomeGrupo;
        private System.Windows.Forms.Button btnCriarPartida;
    }
}

