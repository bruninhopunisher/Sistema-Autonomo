namespace sistema_autonomo
{
    partial class Lobby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblVersaoDoJogo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblStatusPartida = new System.Windows.Forms.Label();
            this.lstJogadoresLobby = new System.Windows.Forms.ListBox();
            this.btnAtualizarLobby = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblIdPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPartida.ForeColor = System.Drawing.Color.White;
            this.lblIdPartida.Location = new System.Drawing.Point(261, 120);
            this.lblIdPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(55, 24);
            this.lblIdPartida.TabIndex = 0;
            this.lblIdPartida.Text = "texto";
            this.lblIdPartida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarPartida.FlatAppearance.BorderSize = 0;
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.ForeColor = System.Drawing.Color.Transparent;
            this.btnIniciarPartida.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciarPartida.Image")));
            this.btnIniciarPartida.Location = new System.Drawing.Point(660, 552);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(133, 47);
            this.btnIniciarPartida.TabIndex = 2;
            this.btnIniciarPartida.Text = "INICIAR";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // lblVersaoDoJogo
            // 
            this.lblVersaoDoJogo.AutoSize = true;
            this.lblVersaoDoJogo.BackColor = System.Drawing.Color.Transparent;
            this.lblVersaoDoJogo.Location = new System.Drawing.Point(1153, 634);
            this.lblVersaoDoJogo.Name = "lblVersaoDoJogo";
            this.lblVersaoDoJogo.Size = new System.Drawing.Size(30, 13);
            this.lblVersaoDoJogo.TabIndex = 12;
            this.lblVersaoDoJogo.Text = "texto";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(163, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 21);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.Location = new System.Drawing.Point(590, 79);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(299, 26);
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(163, 160);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(79, 19);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // lblStatusPartida
            // 
            this.lblStatusPartida.AutoSize = true;
            this.lblStatusPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPartida.Location = new System.Drawing.Point(247, 157);
            this.lblStatusPartida.Name = "lblStatusPartida";
            this.lblStatusPartida.Size = new System.Drawing.Size(55, 24);
            this.lblStatusPartida.TabIndex = 23;
            this.lblStatusPartida.Text = "texto";
            this.lblStatusPartida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstJogadoresLobby
            // 
            this.lstJogadoresLobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJogadoresLobby.FormattingEnabled = true;
            this.lstJogadoresLobby.ItemHeight = 24;
            this.lstJogadoresLobby.Location = new System.Drawing.Point(466, 137);
            this.lstJogadoresLobby.Name = "lstJogadoresLobby";
            this.lstJogadoresLobby.Size = new System.Drawing.Size(553, 340);
            this.lstJogadoresLobby.TabIndex = 24;
            // 
            // btnAtualizarLobby
            // 
            this.btnAtualizarLobby.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizarLobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarLobby.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizarLobby.Location = new System.Drawing.Point(901, 514);
            this.btnAtualizarLobby.Name = "btnAtualizarLobby";
            this.btnAtualizarLobby.Size = new System.Drawing.Size(144, 37);
            this.btnAtualizarLobby.TabIndex = 25;
            this.btnAtualizarLobby.Text = "Atualizar";
            this.btnAtualizarLobby.UseVisualStyleBackColor = false;
            this.btnAtualizarLobby.Click += new System.EventHandler(this.btnAtualizarLobby_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 397);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 616);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(273, 31);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1155, 673);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAtualizarLobby);
            this.Controls.Add(this.lstJogadoresLobby);
            this.Controls.Add(this.lblStatusPartida);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lblVersaoDoJogo);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 718);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 487);
            this.Name = "Lobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LobbyPartida";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblVersaoDoJogo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblStatusPartida;
        private System.Windows.Forms.ListBox lstJogadoresLobby;
        private System.Windows.Forms.Button btnAtualizarLobby;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}