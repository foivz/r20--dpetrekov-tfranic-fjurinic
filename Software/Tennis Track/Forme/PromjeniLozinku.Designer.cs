namespace Tennis_Track.Forme
{
    partial class PromjeniLozinku
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
            this.txtNovaLozinka = new System.Windows.Forms.TextBox();
            this.txtPonovljenaLozinka = new System.Windows.Forms.TextBox();
            this.txtStaraLozinka = new System.Windows.Forms.TextBox();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNovaLozinka
            // 
            this.txtNovaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaLozinka.Location = new System.Drawing.Point(275, 160);
            this.txtNovaLozinka.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNovaLozinka.Multiline = true;
            this.txtNovaLozinka.Name = "txtNovaLozinka";
            this.txtNovaLozinka.Size = new System.Drawing.Size(250, 25);
            this.txtNovaLozinka.TabIndex = 1;
            this.txtNovaLozinka.Text = "Nova lozinka";
            // 
            // txtPonovljenaLozinka
            // 
            this.txtPonovljenaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPonovljenaLozinka.Location = new System.Drawing.Point(275, 195);
            this.txtPonovljenaLozinka.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPonovljenaLozinka.Multiline = true;
            this.txtPonovljenaLozinka.Name = "txtPonovljenaLozinka";
            this.txtPonovljenaLozinka.Size = new System.Drawing.Size(250, 25);
            this.txtPonovljenaLozinka.TabIndex = 2;
            this.txtPonovljenaLozinka.Text = "Ponovite novu lozinku";
            // 
            // txtStaraLozinka
            // 
            this.txtStaraLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaraLozinka.Location = new System.Drawing.Point(275, 230);
            this.txtStaraLozinka.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtStaraLozinka.Multiline = true;
            this.txtStaraLozinka.Name = "txtStaraLozinka";
            this.txtStaraLozinka.Size = new System.Drawing.Size(250, 25);
            this.txtStaraLozinka.TabIndex = 3;
            this.txtStaraLozinka.Text = "Stara lozinka";
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiPromjene.Location = new System.Drawing.Point(300, 265);
            this.btnSpremiPromjene.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(200, 25);
            this.btnSpremiPromjene.TabIndex = 5;
            this.btnSpremiPromjene.Text = "Spremi promjene";
            this.btnSpremiPromjene.UseVisualStyleBackColor = true;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.btnSpremiPromjene_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(651, 401);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(15);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(125, 25);
            this.btnPovratak.TabIndex = 7;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // PromjeniLozinku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnSpremiPromjene);
            this.Controls.Add(this.txtStaraLozinka);
            this.Controls.Add(this.txtPonovljenaLozinka);
            this.Controls.Add(this.txtNovaLozinka);
            this.Name = "PromjeniLozinku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PromjeniLozinku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNovaLozinka;
        private System.Windows.Forms.TextBox txtPonovljenaLozinka;
        private System.Windows.Forms.TextBox txtStaraLozinka;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Button btnPovratak;
    }
}