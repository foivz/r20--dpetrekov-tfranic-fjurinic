namespace Tennis_Track.Forme
{
    partial class AdminPanel
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
            this.btnDodajClana = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBrisanjeTurnira = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodajClana
            // 
            this.btnDodajClana.Location = new System.Drawing.Point(275, 98);
            this.btnDodajClana.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.btnDodajClana.Name = "btnDodajClana";
            this.btnDodajClana.Size = new System.Drawing.Size(250, 50);
            this.btnDodajClana.TabIndex = 5;
            this.btnDodajClana.Text = "Dodaj člana";
            this.btnDodajClana.UseVisualStyleBackColor = true;
            this.btnDodajClana.Click += new System.EventHandler(this.btnDodajClana_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Brisanje mečeva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBrisanjeTurnira
            // 
            this.btnBrisanjeTurnira.Location = new System.Drawing.Point(275, 231);
            this.btnBrisanjeTurnira.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.btnBrisanjeTurnira.Name = "btnBrisanjeTurnira";
            this.btnBrisanjeTurnira.Size = new System.Drawing.Size(250, 50);
            this.btnBrisanjeTurnira.TabIndex = 9;
            this.btnBrisanjeTurnira.Text = "Brisanje turnira";
            this.btnBrisanjeTurnira.UseVisualStyleBackColor = true;
            this.btnBrisanjeTurnira.Click += new System.EventHandler(this.btnBrisanjeTurnira_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnBrisanjeTurnira);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnDodajClana);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajClana;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBrisanjeTurnira;
    }
}