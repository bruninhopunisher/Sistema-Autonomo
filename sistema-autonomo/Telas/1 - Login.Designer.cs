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
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lblVersaoJogo = new System.Windows.Forms.Label();
            this.cboFiltrarPartidas = new System.Windows.Forms.ComboBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txtNomeDoJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaEntrarPartida = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.txtInputSenhaPartida = new System.Windows.Forms.TextBox();
            this.txtInputNomePartida = new System.Windows.Forms.TextBox();
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
            this.btnListarPartidas.Location = new System.Drawing.Point(933, 250);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(122, 22);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.UseVisualStyleBackColor = false;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lstPartidas
            // 
            this.lstPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.ItemHeight = 24;
            this.lstPartidas.Location = new System.Drawing.Point(767, 288);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(311, 100);
            this.lstPartidas.TabIndex = 2;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // lstJogadores
            // 
            this.lstJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 24;
            this.lstJogadores.Location = new System.Drawing.Point(794, 431);
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
            this.cboFiltrarPartidas.Location = new System.Drawing.Point(786, 245);
            this.cboFiltrarPartidas.Name = "cboFiltrarPartidas";
            this.cboFiltrarPartidas.Size = new System.Drawing.Size(121, 32);
            this.cboFiltrarPartidas.TabIndex = 16;
            this.cboFiltrarPartidas.Tag = "0";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrarPartida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrarPartida.BackgroundImage")));
            this.btnEntrarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrarPartida.FlatAppearance.BorderSize = 0;
            this.btnEntrarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarPartida.Location = new System.Drawing.Point(858, 538);
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
            this.txtNomeDoJogador.Location = new System.Drawing.Point(767, 166);
            this.txtNomeDoJogador.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeDoJogador.Multiline = true;
            this.txtNomeDoJogador.Name = "txtNomeDoJogador";
            this.txtNomeDoJogador.Size = new System.Drawing.Size(137, 31);
            this.txtNomeDoJogador.TabIndex = 25;
            // 
            // txtSenhaEntrarPartida
            // 
            this.txtSenhaEntrarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaEntrarPartida.Location = new System.Drawing.Point(944, 166);
            this.txtSenhaEntrarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaEntrarPartida.Multiline = true;
            this.txtSenhaEntrarPartida.Name = "txtSenhaEntrarPartida";
            this.txtSenhaEntrarPartida.Size = new System.Drawing.Size(137, 31);
            this.txtSenhaEntrarPartida.TabIndex = 27;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarPartida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCriarPartida.BackgroundImage")));
            this.btnCriarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarPartida.FlatAppearance.BorderSize = 0;
            this.btnCriarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPartida.Location = new System.Drawing.Point(286, 415);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(118, 36);
            this.btnCriarPartida.TabIndex = 23;
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // txtInputSenhaPartida
            // 
            this.txtInputSenhaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputSenhaPartida.Location = new System.Drawing.Point(357, 341);
            this.txtInputSenhaPartida.MaxLength = 10;
            this.txtInputSenhaPartida.Multiline = true;
            this.txtInputSenhaPartida.Name = "txtInputSenhaPartida";
            this.txtInputSenhaPartida.Size = new System.Drawing.Size(137, 31);
            this.txtInputSenhaPartida.TabIndex = 19;
            // 
            // txtInputNomePartida
            // 
            this.txtInputNomePartida.BackColor = System.Drawing.Color.White;
            this.txtInputNomePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputNomePartida.Location = new System.Drawing.Point(189, 341);
            this.txtInputNomePartida.MaxLength = 15;
            this.txtInputNomePartida.Multiline = true;
            this.txtInputNomePartida.Name = "txtInputNomePartida";
            this.txtInputNomePartida.Size = new System.Drawing.Size(137, 31);
            this.txtInputNomePartida.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.txtSenhaEntrarPartida);
            this.Controls.Add(this.txtInputNomePartida);
            this.Controls.Add(this.txtNomeDoJogador);
            this.Controls.Add(this.cboFiltrarPartidas);
            this.Controls.Add(this.txtInputSenhaPartida);
            this.Controls.Add(this.lblVersaoJogo);
            this.Controls.Add(this.btnCriarPartida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KingMe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label lblVersaoJogo;
        private System.Windows.Forms.ComboBox cboFiltrarPartidas;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.TextBox txtNomeDoJogador;
        private System.Windows.Forms.TextBox txtSenhaEntrarPartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.TextBox txtInputSenhaPartida;
        private System.Windows.Forms.TextBox txtInputNomePartida;
    }
}
