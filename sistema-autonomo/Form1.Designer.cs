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
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txtNomeDoJogador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaEntrarPartida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(34, 123);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(112, 33);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lstListaDePartidas
            // 
            this.lstListaDePartidas.FormattingEnabled = true;
            this.lstListaDePartidas.ItemHeight = 16;
            this.lstListaDePartidas.Location = new System.Drawing.Point(39, 164);
            this.lstListaDePartidas.Margin = new System.Windows.Forms.Padding(4);
            this.lstListaDePartidas.Name = "lstListaDePartidas";
            this.lstListaDePartidas.Size = new System.Drawing.Size(115, 100);
            this.lstListaDePartidas.TabIndex = 2;
            this.lstListaDePartidas.SelectedIndexChanged += new System.EventHandler(this.lstListaDePartidas_SelectedIndexChanged);
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label04.Location = new System.Drawing.Point(77, 98);
            this.label04.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(177, 24);
            this.label04.TabIndex = 3;
            this.label04.Text = "Selecione a Partida:";
            // 
            // lblIdPartidaSelecionada
            // 
            this.lblIdPartidaSelecionada.AutoSize = true;
            this.lblIdPartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPartidaSelecionada.Location = new System.Drawing.Point(231, 169);
            this.lblIdPartidaSelecionada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPartidaSelecionada.Name = "lblIdPartidaSelecionada";
            this.lblIdPartidaSelecionada.Size = new System.Drawing.Size(73, 20);
            this.lblIdPartidaSelecionada.TabIndex = 5;
            this.lblIdPartidaSelecionada.Text = "recebeid";
            // 
            // label07
            // 
            this.label07.AutoSize = true;
            this.label07.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label07.Location = new System.Drawing.Point(155, 173);
            this.label07.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label07.Name = "label07";
            this.label07.Size = new System.Drawing.Size(31, 20);
            this.label07.TabIndex = 6;
            this.label07.Text = "ID:";
            // 
            // label08
            // 
            this.label08.AccessibleDescription = "partida";
            this.label08.AutoSize = true;
            this.label08.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label08.Location = new System.Drawing.Point(155, 193);
            this.label08.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label08.Name = "label08";
            this.label08.Size = new System.Drawing.Size(69, 20);
            this.label08.TabIndex = 7;
            this.label08.Text = "NOME: ";
            // 
            // lblNomePartidaSelecionada
            // 
            this.lblNomePartidaSelecionada.AutoSize = true;
            this.lblNomePartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartidaSelecionada.Location = new System.Drawing.Point(231, 213);
            this.lblNomePartidaSelecionada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePartidaSelecionada.Name = "lblNomePartidaSelecionada";
            this.lblNomePartidaSelecionada.Size = new System.Drawing.Size(53, 20);
            this.lblNomePartidaSelecionada.TabIndex = 8;
            this.lblNomePartidaSelecionada.Text = "label2";
            // 
            // lblDataPartidaSelecionada
            // 
            this.lblDataPartidaSelecionada.AutoSize = true;
            this.lblDataPartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPartidaSelecionada.Location = new System.Drawing.Point(230, 234);
            this.lblDataPartidaSelecionada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataPartidaSelecionada.Name = "lblDataPartidaSelecionada";
            this.lblDataPartidaSelecionada.Size = new System.Drawing.Size(53, 20);
            this.lblDataPartidaSelecionada.TabIndex = 10;
            this.lblDataPartidaSelecionada.Text = "label2";
            // 
            // label09
            // 
            this.label09.AccessibleDescription = "partida";
            this.label09.AutoSize = true;
            this.label09.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label09.Location = new System.Drawing.Point(154, 213);
            this.label09.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label09.Name = "label09";
            this.label09.Size = new System.Drawing.Size(64, 20);
            this.label09.TabIndex = 9;
            this.label09.Text = "DATA: ";
            // 
            // lblStatusPartidaSelecionada
            // 
            this.lblStatusPartidaSelecionada.AutoSize = true;
            this.lblStatusPartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPartidaSelecionada.Location = new System.Drawing.Point(231, 193);
            this.lblStatusPartidaSelecionada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusPartidaSelecionada.Name = "lblStatusPartidaSelecionada";
            this.lblStatusPartidaSelecionada.Size = new System.Drawing.Size(53, 20);
            this.lblStatusPartidaSelecionada.TabIndex = 12;
            this.lblStatusPartidaSelecionada.Text = "label2";
            // 
            // label10
            // 
            this.label10.AccessibleDescription = "partida";
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(154, 234);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "STATUS:";
            // 
            // label06
            // 
            this.label06.AutoSize = true;
            this.label06.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label06.Location = new System.Drawing.Point(121, 266);
            this.label06.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label06.Name = "label06";
            this.label06.Size = new System.Drawing.Size(105, 25);
            this.label06.TabIndex = 13;
            this.label06.Text = "Jogadores";
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 16;
            this.lstJogadores.Location = new System.Drawing.Point(39, 302);
            this.lstJogadores.Margin = new System.Windows.Forms.Padding(4);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(257, 116);
            this.lstJogadores.TabIndex = 14;
            // 
            // lblVersaoJogo
            // 
            this.lblVersaoJogo.AutoSize = true;
            this.lblVersaoJogo.Location = new System.Drawing.Point(1005, 523);
            this.lblVersaoJogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersaoJogo.Name = "lblVersaoJogo";
            this.lblVersaoJogo.Size = new System.Drawing.Size(0, 16);
            this.lblVersaoJogo.TabIndex = 15;
            // 
            // cboFiltrarPartidas
            // 
            this.cboFiltrarPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltrarPartidas.FormattingEnabled = true;
            this.cboFiltrarPartidas.Location = new System.Drawing.Point(154, 126);
            this.cboFiltrarPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.cboFiltrarPartidas.Name = "cboFiltrarPartidas";
            this.cboFiltrarPartidas.Size = new System.Drawing.Size(127, 24);
            this.cboFiltrarPartidas.TabIndex = 16;
            this.cboFiltrarPartidas.Tag = "0";
            // 
            // txtInputNomePartida
            // 
            this.txtInputNomePartida.Location = new System.Drawing.Point(34, 67);
            this.txtInputNomePartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputNomePartida.MaxLength = 15;
            this.txtInputNomePartida.Name = "txtInputNomePartida";
            this.txtInputNomePartida.Size = new System.Drawing.Size(123, 22);
            this.txtInputNomePartida.TabIndex = 2;
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Location = new System.Drawing.Point(41, 47);
            this.label01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(109, 16);
            this.label01.TabIndex = 18;
            this.label01.Text = "Nome da Partida";
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(170, 47);
            this.label02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(111, 16);
            this.label02.TabIndex = 20;
            this.label02.Text = "Senha da Partida";
            // 
            // txtInputSenhaPartida
            // 
            this.txtInputSenhaPartida.Location = new System.Drawing.Point(165, 67);
            this.txtInputSenhaPartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputSenhaPartida.MaxLength = 10;
            this.txtInputSenhaPartida.Name = "txtInputSenhaPartida";
            this.txtInputSenhaPartida.Size = new System.Drawing.Size(123, 22);
            this.txtInputSenhaPartida.TabIndex = 19;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(102, 97);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(121, 34);
            this.btnCriarPartida.TabIndex = 23;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(92, 434);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(147, 34);
            this.btnEntrarPartida.TabIndex = 24;
            this.btnEntrarPartida.Text = "Entrar Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click_1);
            // 
            // txtNomeDoJogador
            // 
            this.txtNomeDoJogador.Location = new System.Drawing.Point(31, 41);
            this.txtNomeDoJogador.Name = "txtNomeDoJogador";
            this.txtNomeDoJogador.Size = new System.Drawing.Size(123, 22);
            this.txtNomeDoJogador.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nome Jogador";
            // 
            // txtSenhaEntrarPartida
            // 
            this.txtSenhaEntrarPartida.Location = new System.Drawing.Point(173, 41);
            this.txtSenhaEntrarPartida.Name = "txtSenhaEntrarPartida";
            this.txtSenhaEntrarPartida.Size = new System.Drawing.Size(123, 22);
            this.txtSenhaEntrarPartida.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Senha da Partida";
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Location = new System.Drawing.Point(133, 104);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(0, 16);
            this.lblIdJogador.TabIndex = 29;
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(237, 102);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(0, 16);
            this.lblSenhaJogador.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Id Jogador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Senha Jogador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Estudantes Bolonha";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label02);
            this.panel1.Controls.Add(this.txtInputNomePartida);
            this.panel1.Controls.Add(this.label01);
            this.panel1.Controls.Add(this.txtInputSenhaPartida);
            this.panel1.Controls.Add(this.lblSenhaJogador);
            this.panel1.Controls.Add(this.btnCriarPartida);
            this.panel1.Controls.Add(this.lblIdJogador);
            this.panel1.Location = new System.Drawing.Point(105, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 165);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstJogadores);
            this.panel2.Controls.Add(this.label06);
            this.panel2.Controls.Add(this.lstListaDePartidas);
            this.panel2.Controls.Add(this.btnListarPartidas);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnEntrarPartida);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSenhaEntrarPartida);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblStatusPartidaSelecionada);
            this.panel2.Controls.Add(this.txtNomeDoJogador);
            this.panel2.Controls.Add(this.label09);
            this.panel2.Controls.Add(this.cboFiltrarPartidas);
            this.panel2.Controls.Add(this.label04);
            this.panel2.Controls.Add(this.lblDataPartidaSelecionada);
            this.panel2.Controls.Add(this.label08);
            this.panel2.Controls.Add(this.lblIdPartidaSelecionada);
            this.panel2.Controls.Add(this.label07);
            this.panel2.Controls.Add(this.lblNomePartidaSelecionada);
            this.panel2.Location = new System.Drawing.Point(617, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 481);
            this.panel2.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblVersaoJogo);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1083, 592);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1083, 592);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KingMe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ListBox lstListaDePartidas;
        private System.Windows.Forms.Label label04;
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
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.TextBox txtNomeDoJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenhaEntrarPartida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

