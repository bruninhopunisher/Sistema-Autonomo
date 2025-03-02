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
            this.lblExibirSelecionarPartida = new System.Windows.Forms.Label();
            this.lblPartidaSelecionada = new System.Windows.Forms.Label();
            this.lblIdPartidaSelecionada = new System.Windows.Forms.Label();
            this.lblExibirIDPartida = new System.Windows.Forms.Label();
            this.lblExibirNomePartida = new System.Windows.Forms.Label();
            this.lblNomePartidaSelecionada = new System.Windows.Forms.Label();
            this.lblDataPartidaSelecionada = new System.Windows.Forms.Label();
            this.lblExibirData = new System.Windows.Forms.Label();
            this.lblStatusPartidaSelecionada = new System.Windows.Forms.Label();
            this.lblExibirStatus = new System.Windows.Forms.Label();
            this.lblExibirJogadores = new System.Windows.Forms.Label();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lblVersaoJogo = new System.Windows.Forms.Label();
            this.cboFiltrarPartidas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(41, 104);
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
            this.lstListaDePartidas.Location = new System.Drawing.Point(42, 159);
            this.lstListaDePartidas.Name = "lstListaDePartidas";
            this.lstListaDePartidas.Size = new System.Drawing.Size(186, 121);
            this.lstListaDePartidas.TabIndex = 2;
            this.lstListaDePartidas.SelectedIndexChanged += new System.EventHandler(this.lstListaDePartidas_SelectedIndexChanged);
            // 
            // lblExibirSelecionarPartida
            // 
            this.lblExibirSelecionarPartida.AutoSize = true;
            this.lblExibirSelecionarPartida.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibirSelecionarPartida.Location = new System.Drawing.Point(38, 134);
            this.lblExibirSelecionarPartida.Name = "lblExibirSelecionarPartida";
            this.lblExibirSelecionarPartida.Size = new System.Drawing.Size(171, 18);
            this.lblExibirSelecionarPartida.TabIndex = 3;
            this.lblExibirSelecionarPartida.Text = "Selecione a Partida:";
            // 
            // lblPartidaSelecionada
            // 
            this.lblPartidaSelecionada.AutoSize = true;
            this.lblPartidaSelecionada.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaSelecionada.Location = new System.Drawing.Point(284, 133);
            this.lblPartidaSelecionada.Name = "lblPartidaSelecionada";
            this.lblPartidaSelecionada.Size = new System.Drawing.Size(192, 19);
            this.lblPartidaSelecionada.TabIndex = 4;
            this.lblPartidaSelecionada.Text = "Informações Partida:";
            // 
            // lblIdPartidaSelecionada
            // 
            this.lblIdPartidaSelecionada.AutoSize = true;
            this.lblIdPartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPartidaSelecionada.Location = new System.Drawing.Point(304, 167);
            this.lblIdPartidaSelecionada.Name = "lblIdPartidaSelecionada";
            this.lblIdPartidaSelecionada.Size = new System.Drawing.Size(61, 16);
            this.lblIdPartidaSelecionada.TabIndex = 5;
            this.lblIdPartidaSelecionada.Text = "recebeid";
            // 
            // lblExibirIDPartida
            // 
            this.lblExibirIDPartida.AutoSize = true;
            this.lblExibirIDPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibirIDPartida.Location = new System.Drawing.Point(284, 167);
            this.lblExibirIDPartida.Name = "lblExibirIDPartida";
            this.lblExibirIDPartida.Size = new System.Drawing.Size(23, 16);
            this.lblExibirIDPartida.TabIndex = 6;
            this.lblExibirIDPartida.Text = "ID:";
            // 
            // lblExibirNomePartida
            // 
            this.lblExibirNomePartida.AccessibleDescription = "partida";
            this.lblExibirNomePartida.AutoSize = true;
            this.lblExibirNomePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibirNomePartida.Location = new System.Drawing.Point(284, 199);
            this.lblExibirNomePartida.Name = "lblExibirNomePartida";
            this.lblExibirNomePartida.Size = new System.Drawing.Size(53, 16);
            this.lblExibirNomePartida.TabIndex = 7;
            this.lblExibirNomePartida.Text = "NOME: ";
            // 
            // lblNomePartidaSelecionada
            // 
            this.lblNomePartidaSelecionada.AutoSize = true;
            this.lblNomePartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartidaSelecionada.Location = new System.Drawing.Point(332, 200);
            this.lblNomePartidaSelecionada.Name = "lblNomePartidaSelecionada";
            this.lblNomePartidaSelecionada.Size = new System.Drawing.Size(44, 16);
            this.lblNomePartidaSelecionada.TabIndex = 8;
            this.lblNomePartidaSelecionada.Text = "label2";
            // 
            // lblDataPartidaSelecionada
            // 
            this.lblDataPartidaSelecionada.AutoSize = true;
            this.lblDataPartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPartidaSelecionada.Location = new System.Drawing.Point(326, 229);
            this.lblDataPartidaSelecionada.Name = "lblDataPartidaSelecionada";
            this.lblDataPartidaSelecionada.Size = new System.Drawing.Size(44, 16);
            this.lblDataPartidaSelecionada.TabIndex = 10;
            this.lblDataPartidaSelecionada.Text = "label2";
            // 
            // lblExibirData
            // 
            this.lblExibirData.AccessibleDescription = "partida";
            this.lblExibirData.AutoSize = true;
            this.lblExibirData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibirData.Location = new System.Drawing.Point(284, 228);
            this.lblExibirData.Name = "lblExibirData";
            this.lblExibirData.Size = new System.Drawing.Size(50, 16);
            this.lblExibirData.TabIndex = 9;
            this.lblExibirData.Text = "DATA: ";
            // 
            // lblStatusPartidaSelecionada
            // 
            this.lblStatusPartidaSelecionada.AutoSize = true;
            this.lblStatusPartidaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPartidaSelecionada.Location = new System.Drawing.Point(345, 256);
            this.lblStatusPartidaSelecionada.Name = "lblStatusPartidaSelecionada";
            this.lblStatusPartidaSelecionada.Size = new System.Drawing.Size(44, 16);
            this.lblStatusPartidaSelecionada.TabIndex = 12;
            this.lblStatusPartidaSelecionada.Text = "label2";
            // 
            // lblExibirStatus
            // 
            this.lblExibirStatus.AccessibleDescription = "partida";
            this.lblExibirStatus.AutoSize = true;
            this.lblExibirStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibirStatus.Location = new System.Drawing.Point(284, 256);
            this.lblExibirStatus.Name = "lblExibirStatus";
            this.lblExibirStatus.Size = new System.Drawing.Size(65, 16);
            this.lblExibirStatus.TabIndex = 11;
            this.lblExibirStatus.Text = "STATUS:";
            // 
            // lblExibirJogadores
            // 
            this.lblExibirJogadores.AutoSize = true;
            this.lblExibirJogadores.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibirJogadores.Location = new System.Drawing.Point(558, 133);
            this.lblExibirJogadores.Name = "lblExibirJogadores";
            this.lblExibirJogadores.Size = new System.Drawing.Size(102, 19);
            this.lblExibirJogadores.TabIndex = 13;
            this.lblExibirJogadores.Text = "Jogadores:";
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.Location = new System.Drawing.Point(562, 159);
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
            this.cboFiltrarPartidas.Location = new System.Drawing.Point(132, 107);
            this.cboFiltrarPartidas.Name = "cboFiltrarPartidas";
            this.cboFiltrarPartidas.Size = new System.Drawing.Size(96, 21);
            this.cboFiltrarPartidas.TabIndex = 16;
            this.cboFiltrarPartidas.Tag = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 451);
            this.Controls.Add(this.cboFiltrarPartidas);
            this.Controls.Add(this.lblVersaoJogo);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.lblExibirJogadores);
            this.Controls.Add(this.lblStatusPartidaSelecionada);
            this.Controls.Add(this.lblExibirStatus);
            this.Controls.Add(this.lblDataPartidaSelecionada);
            this.Controls.Add(this.lblExibirData);
            this.Controls.Add(this.lblNomePartidaSelecionada);
            this.Controls.Add(this.lblExibirNomePartida);
            this.Controls.Add(this.lblExibirIDPartida);
            this.Controls.Add(this.lblIdPartidaSelecionada);
            this.Controls.Add(this.lblPartidaSelecionada);
            this.Controls.Add(this.lblExibirSelecionarPartida);
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
        private System.Windows.Forms.Label lblExibirSelecionarPartida;
        private System.Windows.Forms.Label lblPartidaSelecionada;
        private System.Windows.Forms.Label lblIdPartidaSelecionada;
        private System.Windows.Forms.Label lblExibirIDPartida;
        private System.Windows.Forms.Label lblExibirNomePartida;
        private System.Windows.Forms.Label lblNomePartidaSelecionada;
        private System.Windows.Forms.Label lblDataPartidaSelecionada;
        private System.Windows.Forms.Label lblExibirData;
        private System.Windows.Forms.Label lblStatusPartidaSelecionada;
        private System.Windows.Forms.Label lblExibirStatus;
        private System.Windows.Forms.Label lblExibirJogadores;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label lblVersaoJogo;
        private System.Windows.Forms.ComboBox cboFiltrarPartidas;
    }
}

