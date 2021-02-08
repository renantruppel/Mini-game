namespace Grid_batalha
{
    partial class Instruções
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instruções));
            this.txt_historia = new System.Windows.Forms.TextBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_regras = new System.Windows.Forms.Button();
            this.txt_jogador1 = new System.Windows.Forms.Label();
            this.txt_jogador = new System.Windows.Forms.Label();
            this.txtjogador1 = new System.Windows.Forms.TextBox();
            this.txtjogador2 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_recordes = new System.Windows.Forms.Button();
            this.sobre = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_historia
            // 
            this.txt_historia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_historia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_historia.ForeColor = System.Drawing.Color.Black;
            this.txt_historia.Location = new System.Drawing.Point(2, 9);
            this.txt_historia.Multiline = true;
            this.txt_historia.Name = "txt_historia";
            this.txt_historia.ReadOnly = true;
            this.txt_historia.Size = new System.Drawing.Size(425, 163);
            this.txt_historia.TabIndex = 0;
            this.txt_historia.Text = resources.GetString("txt_historia.Text");
            this.txt_historia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(450, 63);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(153, 28);
            this.btn_iniciar.TabIndex = 1;
            this.btn_iniciar.Text = "Iniciar Partida";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_regras
            // 
            this.btn_regras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regras.Location = new System.Drawing.Point(450, 97);
            this.btn_regras.Name = "btn_regras";
            this.btn_regras.Size = new System.Drawing.Size(153, 28);
            this.btn_regras.TabIndex = 3;
            this.btn_regras.Text = "Regras";
            this.btn_regras.UseVisualStyleBackColor = true;
            this.btn_regras.Click += new System.EventHandler(this.btn_regras_Click);
            // 
            // txt_jogador1
            // 
            this.txt_jogador1.AutoSize = true;
            this.txt_jogador1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_jogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jogador1.Location = new System.Drawing.Point(491, 9);
            this.txt_jogador1.Name = "txt_jogador1";
            this.txt_jogador1.Size = new System.Drawing.Size(65, 15);
            this.txt_jogador1.TabIndex = 5;
            this.txt_jogador1.Text = "Jogador 1";
            // 
            // txt_jogador
            // 
            this.txt_jogador.AutoSize = true;
            this.txt_jogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_jogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jogador.Location = new System.Drawing.Point(635, 9);
            this.txt_jogador.Name = "txt_jogador";
            this.txt_jogador.Size = new System.Drawing.Size(65, 15);
            this.txt_jogador.TabIndex = 6;
            this.txt_jogador.Text = "Jogador 2";
            // 
            // txtjogador1
            // 
            this.txtjogador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtjogador1.Location = new System.Drawing.Point(475, 27);
            this.txtjogador1.Name = "txtjogador1";
            this.txtjogador1.Size = new System.Drawing.Size(100, 20);
            this.txtjogador1.TabIndex = 7;
            // 
            // txtjogador2
            // 
            this.txtjogador2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtjogador2.Location = new System.Drawing.Point(619, 27);
            this.txtjogador2.Name = "txtjogador2";
            this.txtjogador2.Size = new System.Drawing.Size(100, 20);
            this.txtjogador2.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_recordes
            // 
            this.btn_recordes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recordes.Location = new System.Drawing.Point(450, 131);
            this.btn_recordes.Name = "btn_recordes";
            this.btn_recordes.Size = new System.Drawing.Size(153, 28);
            this.btn_recordes.TabIndex = 9;
            this.btn_recordes.Text = "Recordes";
            this.btn_recordes.UseVisualStyleBackColor = true;
            this.btn_recordes.Click += new System.EventHandler(this.btn_recordes_Click);
            // 
            // sobre
            // 
            this.sobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobre.Location = new System.Drawing.Point(450, 165);
            this.sobre.Name = "sobre";
            this.sobre.Size = new System.Drawing.Size(153, 28);
            this.sobre.TabIndex = 10;
            this.sobre.Text = "Sobre";
            this.sobre.UseVisualStyleBackColor = true;
            this.sobre.Click += new System.EventHandler(this.sobre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Grid_batalha.Properties.Resources.slogan;
            this.pictureBox1.Location = new System.Drawing.Point(12, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Instruções
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sobre);
            this.Controls.Add(this.btn_recordes);
            this.Controls.Add(this.txtjogador2);
            this.Controls.Add(this.txtjogador1);
            this.Controls.Add(this.txt_jogador);
            this.Controls.Add(this.txt_jogador1);
            this.Controls.Add(this.btn_regras);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.txt_historia);
            this.Name = "Instruções";
            this.Text = "Instruções";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_regras;
        private System.Windows.Forms.Label txt_jogador1;
        private System.Windows.Forms.Label txt_jogador;
        protected System.Windows.Forms.TextBox txt_historia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox txtjogador1;
        public System.Windows.Forms.TextBox txtjogador2;
        private System.Windows.Forms.Button btn_recordes;
        private System.Windows.Forms.Button sobre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}