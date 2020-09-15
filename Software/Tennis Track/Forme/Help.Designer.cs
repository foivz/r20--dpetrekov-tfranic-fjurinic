namespace Tennis_Track.Forme
{
    partial class Help
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
            this.btnPovratak = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.lblPostavke = new System.Windows.Forms.Label();
            this.lblRezervacijaTerena = new System.Windows.Forms.Label();
            this.lblMecevi = new System.Windows.Forms.Label();
            this.lblTurniri = new System.Windows.Forms.Label();
            this.lblRangListe = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdminPanel);
            this.groupBox1.Controls.Add(this.lblPostavke);
            this.groupBox1.Controls.Add(this.lblRezervacijaTerena);
            this.groupBox1.Controls.Add(this.lblMecevi);
            this.groupBox1.Controls.Add(this.lblTurniri);
            this.groupBox1.Controls.Add(this.lblRangListe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 371);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.Location = new System.Drawing.Point(8, 211);
            this.lblAdminPanel.Margin = new System.Windows.Forms.Padding(5);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(647, 50);
            this.lblAdminPanel.TabIndex = 14;
            this.lblAdminPanel.Text = "Admin panel - dodavanje novih članova, brisanje mečeva i brisanje turnira\r\n(samo " +
    "za zaposlenike)";
            // 
            // lblPostavke
            // 
            this.lblPostavke.AutoSize = true;
            this.lblPostavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostavke.Location = new System.Drawing.Point(8, 172);
            this.lblPostavke.Margin = new System.Windows.Forms.Padding(5);
            this.lblPostavke.Name = "lblPostavke";
            this.lblPostavke.Size = new System.Drawing.Size(409, 25);
            this.lblPostavke.TabIndex = 13;
            this.lblPostavke.Text = "Postavke - promjena Emaila, telefona i lozinke";
            // 
            // lblRezervacijaTerena
            // 
            this.lblRezervacijaTerena.AutoSize = true;
            this.lblRezervacijaTerena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezervacijaTerena.Location = new System.Drawing.Point(8, 133);
            this.lblRezervacijaTerena.Margin = new System.Windows.Forms.Padding(5);
            this.lblRezervacijaTerena.Name = "lblRezervacijaTerena";
            this.lblRezervacijaTerena.Size = new System.Drawing.Size(682, 25);
            this.lblRezervacijaTerena.TabIndex = 12;
            this.lblRezervacijaTerena.Text = "Rezervacija terana - rezerviranje terena na određeni datum i određeno vrijeme";
            // 
            // lblMecevi
            // 
            this.lblMecevi.AutoSize = true;
            this.lblMecevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMecevi.Location = new System.Drawing.Point(8, 94);
            this.lblMecevi.Margin = new System.Windows.Forms.Padding(5);
            this.lblMecevi.Name = "lblMecevi";
            this.lblMecevi.Size = new System.Drawing.Size(499, 25);
            this.lblMecevi.TabIndex = 11;
            this.lblMecevi.Text = "Mečevi - pregled svih mečeva te unos odigranih mečeva";
            // 
            // lblTurniri
            // 
            this.lblTurniri.AutoSize = true;
            this.lblTurniri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurniri.Location = new System.Drawing.Point(8, 55);
            this.lblTurniri.Margin = new System.Windows.Forms.Padding(5);
            this.lblTurniri.Name = "lblTurniri";
            this.lblTurniri.Size = new System.Drawing.Size(645, 25);
            this.lblTurniri.TabIndex = 10;
            this.lblTurniri.Text = "Turniri - dodavanje turnira (samo za zaposlenike kluba) i prijave na turnire";
            // 
            // lblRangListe
            // 
            this.lblRangListe.AutoSize = true;
            this.lblRangListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangListe.Location = new System.Drawing.Point(6, 16);
            this.lblRangListe.Margin = new System.Windows.Forms.Padding(5);
            this.lblRangListe.Name = "lblRangListe";
            this.lblRangListe.Size = new System.Drawing.Size(568, 25);
            this.lblRangListe.TabIndex = 9;
            this.lblRangListe.Text = "Rang liste - prikaz svih korisnika te njihovih rangova unutar kluba";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPovratak);
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTurniri;
        private System.Windows.Forms.Label lblRangListe;
        private System.Windows.Forms.Label lblMecevi;
        private System.Windows.Forms.Label lblRezervacijaTerena;
        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.Label lblPostavke;
    }
}