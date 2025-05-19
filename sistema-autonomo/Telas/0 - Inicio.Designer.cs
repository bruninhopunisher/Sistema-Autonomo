namespace sistema_autonomo
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnCreditosInicio = new System.Windows.Forms.Button();
            this.btnConfiguracaoInicio = new System.Windows.Forms.Button();
            this.btnAjudaInicio = new System.Windows.Forms.Button();
            this.lblVersaoJogo = new System.Windows.Forms.Label();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.dgvSala = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInicio.BackgroundImage")));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Location = new System.Drawing.Point(497, 313);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(272, 66);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnCreditosInicio
            // 
            this.btnCreditosInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnCreditosInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreditosInicio.BackgroundImage")));
            this.btnCreditosInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditosInicio.FlatAppearance.BorderSize = 0;
            this.btnCreditosInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditosInicio.Location = new System.Drawing.Point(460, 410);
            this.btnCreditosInicio.Name = "btnCreditosInicio";
            this.btnCreditosInicio.Size = new System.Drawing.Size(341, 78);
            this.btnCreditosInicio.TabIndex = 1;
            this.btnCreditosInicio.UseVisualStyleBackColor = false;
            // 
            // btnConfiguracaoInicio
            // 
            this.btnConfiguracaoInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracaoInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfiguracaoInicio.BackgroundImage")));
            this.btnConfiguracaoInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracaoInicio.FlatAppearance.BorderSize = 0;
            this.btnConfiguracaoInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracaoInicio.Location = new System.Drawing.Point(27, 582);
            this.btnConfiguracaoInicio.Name = "btnConfiguracaoInicio";
            this.btnConfiguracaoInicio.Size = new System.Drawing.Size(55, 55);
            this.btnConfiguracaoInicio.TabIndex = 2;
            this.btnConfiguracaoInicio.UseVisualStyleBackColor = false;
            // 
            // btnAjudaInicio
            // 
            this.btnAjudaInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnAjudaInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjudaInicio.BackgroundImage")));
            this.btnAjudaInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjudaInicio.FlatAppearance.BorderSize = 0;
            this.btnAjudaInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjudaInicio.Location = new System.Drawing.Point(1175, 578);
            this.btnAjudaInicio.Name = "btnAjudaInicio";
            this.btnAjudaInicio.Size = new System.Drawing.Size(40, 59);
            this.btnAjudaInicio.TabIndex = 3;
            this.btnAjudaInicio.UseVisualStyleBackColor = false;
            // 
            // lblVersaoJogo
            // 
            this.lblVersaoJogo.AutoSize = true;
            this.lblVersaoJogo.Location = new System.Drawing.Point(1187, 646);
            this.lblVersaoJogo.Name = "lblVersaoJogo";
            this.lblVersaoJogo.Size = new System.Drawing.Size(0, 13);
            this.lblVersaoJogo.TabIndex = 4;
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Location = new System.Drawing.Point(1052, 646);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(0, 13);
            this.lblNomeGrupo.TabIndex = 5;
            // 
            // dgvSala
            // 
            this.dgvSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSala.Location = new System.Drawing.Point(43, 39);
            this.dgvSala.Name = "dgvSala";
            this.dgvSala.Size = new System.Drawing.Size(478, 268);
            this.dgvSala.TabIndex = 6;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dgvSala);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.lblVersaoJogo);
            this.Controls.Add(this.btnAjudaInicio);
            this.Controls.Add(this.btnConfiguracaoInicio);
            this.Controls.Add(this.btnCreditosInicio);
            this.Controls.Add(this.btnInicio);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnCreditosInicio;
        private System.Windows.Forms.Button btnConfiguracaoInicio;
        private System.Windows.Forms.Button btnAjudaInicio;
        private System.Windows.Forms.Label lblVersaoJogo;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.DataGridView dgvSala;
    }
}