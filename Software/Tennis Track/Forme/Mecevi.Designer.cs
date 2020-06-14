namespace Tennis_Track.Forme
{
    partial class Mecevi
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
            this.btnPopisMeceva = new System.Windows.Forms.Button();
            this.btnDodavanjeMeca = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPopisMeceva
            // 
            this.btnPopisMeceva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPopisMeceva.Location = new System.Drawing.Point(102, 12);
            this.btnPopisMeceva.Name = "btnPopisMeceva";
            this.btnPopisMeceva.Size = new System.Drawing.Size(133, 41);
            this.btnPopisMeceva.TabIndex = 0;
            this.btnPopisMeceva.Text = "Popis mečeva";
            this.btnPopisMeceva.UseVisualStyleBackColor = true;
            // 
            // btnDodavanjeMeca
            // 
            this.btnDodavanjeMeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodavanjeMeca.Location = new System.Drawing.Point(102, 68);
            this.btnDodavanjeMeca.Name = "btnDodavanjeMeca";
            this.btnDodavanjeMeca.Size = new System.Drawing.Size(133, 46);
            this.btnDodavanjeMeca.TabIndex = 1;
            this.btnDodavanjeMeca.Text = "Dodavanje novog meča";
            this.btnDodavanjeMeca.UseVisualStyleBackColor = true;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(198, 150);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(15);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(125, 25);
            this.btnPovratak.TabIndex = 9;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // Mecevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(333, 185);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnDodavanjeMeca);
            this.Controls.Add(this.btnPopisMeceva);
            this.Name = "Mecevi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mecevi";
            this.Load += new System.EventHandler(this.Mecevi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPopisMeceva;
        private System.Windows.Forms.Button btnDodavanjeMeca;
        private System.Windows.Forms.Button btnPovratak;
    }
}