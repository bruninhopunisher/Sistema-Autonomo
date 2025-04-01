namespace sistema_autonomo
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.lstListaDePartidas = new System.Windows.Forms.ListBox();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lblVersaoJogo = new System.Windows.Forms.Label();
            this.cboFiltrarPartidas = new System.Windows.Forms.ComboBox();
            this.txtInputNomePartida = new System.Windows.Forms.TextBox();
            this.txtInputSenhaPartida = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txtNomeDoJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaEntrarPartida = new System.Windows.Forms.TextBox();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lblStatusPartidaSelecionada = new System.Windows.Forms.Label();
            this.label09 = new System.Windows.Forms.Label();
            this.lblDataPartidaSelecionada = new System.Windows.Forms.Label();
            this.label08 = new System.Windows.Forms.Label();
            this.lblIdPartidaSelecionada = new System.Windows.Forms.Label();
            this.label07 = new System.Windows.Forms.Label();
            this.lblNomePartidaSelecionada = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.BackColor = System.Drawing.Color.Transparent;
            this.btnListarPartidas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListarPartidas.BackgroundImage")));
            this.btnListarPartidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarPartidas.FlatAppearance.BorderSize = 0;
            this.btnListarPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPartidas.ForeColor = System.Drawing.Color.Transparent;
            this.btnListarPartidas.Location = new System.Drawing.Point(201, 229);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(122, 22);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.UseVisualStyleBackColor = false;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lstListaDePartidas
            // 
            this.lstListaDePartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaDePartidas.FormattingEnabled = true;
            this.lstListaDePartidas.ItemHeight = 24;
            this.lstListaDePartidas.Location = new System.Drawing.Point(33, 268);
            this.lstListaDePartidas.Name = "lstListaDePartidas";
            this.lstListaDePartidas.Size = new System.Drawing.Size(311, 100);
            this.lstListaDePartidas.TabIndex = 2;
            this.lstListaDePartidas.SelectedIndexChanged += new System.EventHandler(this.lstListaDePartidas_SelectedIndexChanged);
            // 
            // lstJogadores
            // 
            this.lstJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 24;
            this.lstJogadores.Location = new System.Drawing.Point(61, 433);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(262, 76);
            this.lstJogadores.TabIndex = 14;
            // 
            // lblVersaoJogo
            // 
            this.lblVersaoJogo.AutoSize = true;
            this.lblVersaoJogo.Location = new System.Drawing.Point(1206, 627);
            this.lblVersaoJogo.Name = "lblVersaoJogo";
            this.lblVersaoJogo.Size = new System.Drawing.Size(0, 13);
            this.lblVersaoJogo.TabIndex = 15;
            // 
            // cboFiltrarPartidas
            // 
            this.cboFiltrarPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltrarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltrarPartidas.FormattingEnabled = true;
            this.cboFiltrarPartidas.Location = new System.Drawing.Point(54, 222);
            this.cboFiltrarPartidas.Name = "cboFiltrarPartidas";
            this.cboFiltrarPartidas.Size = new System.Drawing.Size(121, 32);
            this.cboFiltrarPartidas.TabIndex = 16;
            this.cboFiltrarPartidas.Tag = "0";
            // 
            // txtInputNomePartida
            // 
            this.txtInputNomePartida.BackColor = System.Drawing.Color.White;
            this.txtInputNomePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputNomePartida.Location = new System.Drawing.Point(46, 157);
            this.txtInputNomePartida.MaxLength = 15;
            this.txtInputNomePartida.Multiline = true;
            this.txtInputNomePartida.Name = "txtInputNomePartida";
            this.txtInputNomePartida.Size = new System.Drawing.Size(137, 31);
            this.txtInputNomePartida.TabIndex = 2;
            // 
            // txtInputSenhaPartida
            // 
            this.txtInputSenhaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputSenhaPartida.Location = new System.Drawing.Point(215, 157);
            this.txtInputSenhaPartida.MaxLength = 10;
            this.txtInputSenhaPartida.Multiline = true;
            this.txtInputSenhaPartida.Name = "txtInputSenhaPartida";
            this.txtInputSenhaPartida.Size = new System.Drawing.Size(137, 31);
            this.txtInputSenhaPartida.TabIndex = 19;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarPartida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCriarPartida.BackgroundImage")));
            this.btnCriarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarPartida.FlatAppearance.BorderSize = 0;
            this.btnCriarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPartida.Location = new System.Drawing.Point(134, 230);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(118, 36);
            this.btnCriarPartida.TabIndex = 23;
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrarPartida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrarPartida.BackgroundImage")));
            this.btnEntrarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrarPartida.FlatAppearance.BorderSize = 0;
            this.btnEntrarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarPartida.Location = new System.Drawing.Point(136, 560);
            this.btnEntrarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(135, 39);
            this.btnEntrarPartida.TabIndex = 0;
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click_1);
            // 
            // txtNomeDoJogador
            // 
            this.txtNomeDoJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDoJogador.Location = new System.Drawing.Point(38, 148);
            this.txtNomeDoJogador.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeDoJogador.Multiline = true;
            this.txtNomeDoJogador.Name = "txtNomeDoJogador";
            this.txtNomeDoJogador.Size = new System.Drawing.Size(137, 31);
            this.txtNomeDoJogador.TabIndex = 25;
            // 
            // txtSenhaEntrarPartida
            // 
            this.txtSenhaEntrarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaEntrarPartida.Location = new System.Drawing.Point(201, 148);
            this.txtSenhaEntrarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaEntrarPartida.Multiline = true;
            this.txtSenhaEntrarPartida.Name = "txtSenhaEntrarPartida";
            this.txtSenhaEntrarPartida.Size = new System.Drawing.Size(137, 31);
            this.txtSenhaEntrarPartida.TabIndex = 27;
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Location = new System.Drawing.Point(161, 127);
            this.lblIdJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(0, 13);
            this.lblIdJogador.TabIndex = 29;
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(239, 126);
            this.lblSenhaJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(0, 13);
            this.lblSenhaJogador.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtInputNomePartida);
            this.panel1.Controls.Add(this.txtInputSenhaPartida);
            this.panel1.Controls.Add(this.lblSenhaJogador);
            this.panel1.Controls.Add(this.btnCriarPartida);
            this.panel1.Controls.Add(this.lblIdJogador);
            this.panel1.Location = new System.Drawing.Point(102, 168);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 316);
            this.panel1.TabIndex = 34;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(242, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 21);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(78, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 21);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 38);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.lblNomePartidaSelecionada);
            this.panel2.Controls.Add(this.label07);
            this.panel2.Controls.Add(this.lstJogadores);
            this.panel2.Controls.Add(this.lblIdPartidaSelecionada);
            this.panel2.Controls.Add(this.lstListaDePartidas);
            this.panel2.Controls.Add(this.label08);
            this.panel2.Controls.Add(this.btnListarPartidas);
            this.panel2.Controls.Add(this.lblDataPartidaSelecionada);
            this.panel2.Controls.Add(this.btnEntrarPartida);
            this.panel2.Controls.Add(this.label09);
            this.panel2.Controls.Add(this.txtSenhaEntrarPartida);
            this.panel2.Controls.Add(this.lblStatusPartidaSelecionada);
            this.panel2.Controls.Add(this.txtNomeDoJogador);
            this.panel2.Controls.Add(this.cboFiltrarPartidas);
            this.panel2.Location = new System.Drawing.Point(738, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 620);
            this.panel2.TabIndex = 35;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.Location = new System.Drawing.Point(63, 394);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(250, 20);
            this.pictureBox8.TabIndex = 37;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.Location = new System.Drawing.Point(45, 37);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(299, 33);
            this.pictureBox7.TabIndex = 36;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(80, 200);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(215, 16);
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(201, 111);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(143, 16);
            this.pictureBox5.TabIndex = 34;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(54, 111);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(98, 17);
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.Location = new System.Drawing.Point(31, 603);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(221, 29);
            this.pictureBox9.TabIndex = 38;
            this.pictureBox9.TabStop = false;
            // 
            // lblStatusPartidaSelecionada
            // 
            this.lblStatusPartidaSelecionada.AutoSize = true;
            this.lblStatusPartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPartidaSelecionada.Location = new System.Drawing.Point(61, 567);
            this.lblStatusPartidaSelecionada.Name = "lblStatusPartidaSelecionada";
            this.lblStatusPartidaSelecionada.Size = new System.Drawing.Size(44, 16);
            this.lblStatusPartidaSelecionada.TabIndex = 12;
            this.lblStatusPartidaSelecionada.Text = "label2";
            // 
            // label09
            // 
            this.label09.AccessibleDescription = "partida";
            this.label09.AutoSize = true;
            this.label09.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label09.Location = new System.Drawing.Point(4, 583);
            this.label09.Name = "label09";
            this.label09.Size = new System.Drawing.Size(50, 16);
            this.label09.TabIndex = 9;
            this.label09.Text = "DATA: ";
            // 
            // lblDataPartidaSelecionada
            // 
            this.lblDataPartidaSelecionada.AutoSize = true;
            this.lblDataPartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPartidaSelecionada.Location = new System.Drawing.Point(60, 600);
            this.lblDataPartidaSelecionada.Name = "lblDataPartidaSelecionada";
            this.lblDataPartidaSelecionada.Size = new System.Drawing.Size(44, 16);
            this.lblDataPartidaSelecionada.TabIndex = 10;
            this.lblDataPartidaSelecionada.Text = "label2";
            // 
            // label08
            // 
            this.label08.AccessibleDescription = "partida";
            this.label08.AutoSize = true;
            this.label08.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label08.Location = new System.Drawing.Point(4, 567);
            this.label08.Name = "label08";
            this.label08.Size = new System.Drawing.Size(53, 16);
            this.label08.TabIndex = 7;
            this.label08.Text = "NOME: ";
            // 
            // lblIdPartidaSelecionada
            // 
            this.lblIdPartidaSelecionada.AutoSize = true;
            this.lblIdPartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPartidaSelecionada.Location = new System.Drawing.Point(61, 547);
            this.lblIdPartidaSelecionada.Name = "lblIdPartidaSelecionada";
            this.lblIdPartidaSelecionada.Size = new System.Drawing.Size(61, 16);
            this.lblIdPartidaSelecionada.TabIndex = 5;
            this.lblIdPartidaSelecionada.Text = "recebeid";
            // 
            // label07
            // 
            this.label07.AutoSize = true;
            this.label07.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label07.Location = new System.Drawing.Point(4, 551);
            this.label07.Name = "label07";
            this.label07.Size = new System.Drawing.Size(23, 16);
            this.label07.TabIndex = 6;
            this.label07.Text = "ID:";
            // 
            // lblNomePartidaSelecionada
            // 
            this.lblNomePartidaSelecionada.AutoSize = true;
            this.lblNomePartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartidaSelecionada.Location = new System.Drawing.Point(61, 583);
            this.lblNomePartidaSelecionada.Name = "lblNomePartidaSelecionada";
            this.lblNomePartidaSelecionada.Size = new System.Drawing.Size(44, 16);
            this.lblNomePartidaSelecionada.TabIndex = 8;
            this.lblNomePartidaSelecionada.Text = "label2";
            // 
            // label10
            // 
            this.label10.AccessibleDescription = "partida";
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 600);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "STATUS:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblVersaoJogo);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KingMe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ListBox lstListaDePartidas;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label lblVersaoJogo;
        private System.Windows.Forms.ComboBox cboFiltrarPartidas;
        private System.Windows.Forms.TextBox txtInputNomePartida;
        private System.Windows.Forms.TextBox txtInputSenhaPartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.TextBox txtNomeDoJogador;
        private System.Windows.Forms.TextBox txtSenhaEntrarPartida;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNomePartidaSelecionada;
        private System.Windows.Forms.Label label07;
        private System.Windows.Forms.Label lblIdPartidaSelecionada;
        private System.Windows.Forms.Label label08;
        private System.Windows.Forms.Label lblDataPartidaSelecionada;
        private System.Windows.Forms.Label label09;
        private System.Windows.Forms.Label lblStatusPartidaSelecionada;
    }
}
