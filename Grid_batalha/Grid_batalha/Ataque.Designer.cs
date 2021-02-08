namespace Grid_batalha
{
    partial class Ataque
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_lança = new System.Windows.Forms.Button();
            this.btn_espada_Grande = new System.Windows.Forms.Button();
            this.btn_espada_curta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_arco_flexa = new System.Windows.Forms.Button();
            this.btn_adaga = new System.Windows.Forms.Button();
            this.btn_Flexa_balista = new System.Windows.Forms.Button();
            this.btn_Bola_fogo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Armas Corpo a Corpo";
            // 
            // btn_lança
            // 
            this.btn_lança.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lança.Location = new System.Drawing.Point(12, 56);
            this.btn_lança.Name = "btn_lança";
            this.btn_lança.Size = new System.Drawing.Size(100, 51);
            this.btn_lança.TabIndex = 1;
            this.btn_lança.Text = "Lança";
            this.toolTip1.SetToolTip(this.btn_lança, "Dano: 1 a 6 + bonus.");
            this.btn_lança.UseVisualStyleBackColor = true;
            this.btn_lança.Click += new System.EventHandler(this.btn_lança_Click_1);
            // 
            // btn_espada_Grande
            // 
            this.btn_espada_Grande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_espada_Grande.Location = new System.Drawing.Point(118, 56);
            this.btn_espada_Grande.Name = "btn_espada_Grande";
            this.btn_espada_Grande.Size = new System.Drawing.Size(102, 51);
            this.btn_espada_Grande.TabIndex = 2;
            this.btn_espada_Grande.Text = "Espada Grande";
            this.toolTip1.SetToolTip(this.btn_espada_Grande, "Dano: 1 a 8 + bonus.");
            this.btn_espada_Grande.UseVisualStyleBackColor = true;
            this.btn_espada_Grande.Click += new System.EventHandler(this.btn_espada_Grande_Click_1);
            // 
            // btn_espada_curta
            // 
            this.btn_espada_curta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_espada_curta.Location = new System.Drawing.Point(226, 56);
            this.btn_espada_curta.Name = "btn_espada_curta";
            this.btn_espada_curta.Size = new System.Drawing.Size(102, 51);
            this.btn_espada_curta.TabIndex = 3;
            this.btn_espada_curta.Text = "Espada Curta";
            this.toolTip1.SetToolTip(this.btn_espada_curta, "Dano: 1 a 6 + bonus.");
            this.btn_espada_curta.UseVisualStyleBackColor = true;
            this.btn_espada_curta.Click += new System.EventHandler(this.btn_espada_curta_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Armas a Distância";
            // 
            // btn_arco_flexa
            // 
            this.btn_arco_flexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_arco_flexa.Location = new System.Drawing.Point(12, 166);
            this.btn_arco_flexa.Name = "btn_arco_flexa";
            this.btn_arco_flexa.Size = new System.Drawing.Size(100, 59);
            this.btn_arco_flexa.TabIndex = 5;
            this.btn_arco_flexa.Text = "Arco e flexa.  Range: 2 a 9.";
            this.toolTip1.SetToolTip(this.btn_arco_flexa, "Dano: 1 a 6 + bonus.");
            this.btn_arco_flexa.UseVisualStyleBackColor = true;
            this.btn_arco_flexa.Click += new System.EventHandler(this.btn_arco_flexa_Click_1);
            // 
            // btn_adaga
            // 
            this.btn_adaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adaga.Location = new System.Drawing.Point(118, 166);
            this.btn_adaga.Name = "btn_adaga";
            this.btn_adaga.Size = new System.Drawing.Size(102, 59);
            this.btn_adaga.TabIndex = 6;
            this.btn_adaga.Text = "Adaga.  Range: 1 a 5";
            this.toolTip1.SetToolTip(this.btn_adaga, "Dano: 1 a 5 + bonus");
            this.btn_adaga.UseVisualStyleBackColor = true;
            this.btn_adaga.Click += new System.EventHandler(this.btn_adaga_Click_1);
            // 
            // btn_Flexa_balista
            // 
            this.btn_Flexa_balista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Flexa_balista.Location = new System.Drawing.Point(226, 166);
            this.btn_Flexa_balista.Name = "btn_Flexa_balista";
            this.btn_Flexa_balista.Size = new System.Drawing.Size(102, 59);
            this.btn_Flexa_balista.TabIndex = 7;
            this.btn_Flexa_balista.Text = "Flexa balista. Range: 4 a 15";
            this.toolTip1.SetToolTip(this.btn_Flexa_balista, "Dano: 6 a 13");
            this.btn_Flexa_balista.UseVisualStyleBackColor = true;
            this.btn_Flexa_balista.Click += new System.EventHandler(this.btn_Flexa_balista_Click);
            // 
            // btn_Bola_fogo
            // 
            this.btn_Bola_fogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bola_fogo.Location = new System.Drawing.Point(12, 231);
            this.btn_Bola_fogo.Name = "btn_Bola_fogo";
            this.btn_Bola_fogo.Size = new System.Drawing.Size(102, 59);
            this.btn_Bola_fogo.TabIndex = 8;
            this.btn_Bola_fogo.Text = "Bola de fogo. Range 2 a 8";
            this.toolTip1.SetToolTip(this.btn_Bola_fogo, "Dano: 6 a 13");
            this.btn_Bola_fogo.UseVisualStyleBackColor = true;
            this.btn_Bola_fogo.Click += new System.EventHandler(this.btn_Bola_fogo_Click);
            // 
            // Ataque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 329);
            this.Controls.Add(this.btn_Bola_fogo);
            this.Controls.Add(this.btn_Flexa_balista);
            this.Controls.Add(this.btn_adaga);
            this.Controls.Add(this.btn_arco_flexa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_espada_curta);
            this.Controls.Add(this.btn_espada_Grande);
            this.Controls.Add(this.btn_lança);
            this.Controls.Add(this.label1);
            this.Name = "Ataque";
            this.Text = "Ataque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_lança;
        public System.Windows.Forms.Button btn_espada_Grande;
        public System.Windows.Forms.Button btn_espada_curta;
        public System.Windows.Forms.Button btn_arco_flexa;
        public System.Windows.Forms.Button btn_adaga;
        public System.Windows.Forms.Button btn_Flexa_balista;
        public System.Windows.Forms.Button btn_Bola_fogo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}