namespace Tennis_Track.Forme
{
    partial class Postavke
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.btnPromjeniLozinku = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(277, 160);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 25);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(277, 223);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(250, 25);
            this.txtTelefon.TabIndex = 3;
            this.txtTelefon.Text = "Telefon";
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiPromjene.Location = new System.Drawing.Point(302, 258);
            this.btnSpremiPromjene.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(200, 25);
            this.btnSpremiPromjene.TabIndex = 4;
            this.btnSpremiPromjene.Text = "Spremi promjene";
            this.btnSpremiPromjene.UseVisualStyleBackColor = true;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.btnSpremiPromjene_Click);
            // 
            // btnPromjeniLozinku
            // 
            this.btnPromjeniLozinku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromjeniLozinku.Location = new System.Drawing.Point(302, 291);
            this.btnPromjeniLozinku.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.btnPromjeniLozinku.Name = "btnPromjeniLozinku";
            this.btnPromjeniLozinku.Size = new System.Drawing.Size(200, 25);
            this.btnPromjeniLozinku.TabIndex = 5;
            this.btnPromjeniLozinku.Text = "Promjeni lozinku";
            this.btnPromjeniLozinku.UseVisualStyleBackColor = true;
            this.btnPromjeniLozinku.Click += new System.EventHandler(this.btnPromjeniLozinku_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(651, 401);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(15);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(125, 25);
            this.btnPovratak.TabIndex = 6;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(273, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telefon";
            // 
            // Postavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnPromjeniLozinku);
            this.Controls.Add(this.btnSpremiPromjene);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtEmail);
            this.Name = "Postavke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postavke";
            this.Load += new System.EventHandler(this.Postavke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Button btnPromjeniLozinku;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label2;
    }
}