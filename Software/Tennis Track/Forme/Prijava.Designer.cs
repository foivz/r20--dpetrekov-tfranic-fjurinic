namespace Tennis_Track
{
    partial class LoginForm
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
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnPrijaviSe = new System.Windows.Forms.Button();
            this.btnResetirajLozinku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TxtUsername.Location = new System.Drawing.Point(275, 161);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.TxtUsername.Multiline = true;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(250, 30);
            this.TxtUsername.TabIndex = 0;
            this.TxtUsername.Text = "Korisničko ime";
            this.TxtUsername.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TxtUsername_MouseDoubleClick);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtPassword.Location = new System.Drawing.Point(275, 204);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(250, 30);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.Text = "Lozinka";
            this.TxtPassword.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TxtPassword_MouseDoubleClick);
            // 
            // BtnPrijaviSe
            // 
            this.BtnPrijaviSe.Location = new System.Drawing.Point(324, 247);
            this.BtnPrijaviSe.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.BtnPrijaviSe.Name = "BtnPrijaviSe";
            this.BtnPrijaviSe.Size = new System.Drawing.Size(153, 43);
            this.BtnPrijaviSe.TabIndex = 2;
            this.BtnPrijaviSe.Text = "Prijavi se";
            this.BtnPrijaviSe.UseVisualStyleBackColor = true;
            this.BtnPrijaviSe.Click += new System.EventHandler(this.BtnPrijaviSe_Click);
            // 
            // btnResetirajLozinku
            // 
            this.btnResetirajLozinku.Location = new System.Drawing.Point(324, 303);
            this.btnResetirajLozinku.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnResetirajLozinku.Name = "btnResetirajLozinku";
            this.btnResetirajLozinku.Size = new System.Drawing.Size(153, 43);
            this.btnResetirajLozinku.TabIndex = 3;
            this.btnResetirajLozinku.Text = "Resetiraj lozinku";
            this.btnResetirajLozinku.UseVisualStyleBackColor = true;
            this.btnResetirajLozinku.Click += new System.EventHandler(this.btnResetirajLozinku_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResetirajLozinku);
            this.Controls.Add(this.BtnPrijaviSe);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TennisTrack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnPrijaviSe;
        private System.Windows.Forms.Button btnResetirajLozinku;
    }
}

