namespace Tennis_Track.Forme
{
    partial class DodavanjeTurnira
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTurnirNaziv = new System.Windows.Forms.TextBox();
            this.Naziv = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dtpDatumTurnira = new System.Windows.Forms.DateTimePicker();
            this.cmbVrijeme = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vrijeme početka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Datum:";
            // 
            // txtTurnirNaziv
            // 
            this.txtTurnirNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurnirNaziv.Location = new System.Drawing.Point(72, 18);
            this.txtTurnirNaziv.Name = "txtTurnirNaziv";
            this.txtTurnirNaziv.Size = new System.Drawing.Size(175, 22);
            this.txtTurnirNaziv.TabIndex = 7;
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naziv.Location = new System.Drawing.Point(12, 21);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(45, 16);
            this.Naziv.TabIndex = 6;
            this.Naziv.Text = "Naziv:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(93, 138);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(91, 23);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj turnir";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dtpDatumTurnira
            // 
            this.dtpDatumTurnira.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumTurnira.Checked = false;
            this.dtpDatumTurnira.Location = new System.Drawing.Point(72, 57);
            this.dtpDatumTurnira.Name = "dtpDatumTurnira";
            this.dtpDatumTurnira.Size = new System.Drawing.Size(175, 20);
            this.dtpDatumTurnira.TabIndex = 13;
            this.dtpDatumTurnira.ValueChanged += new System.EventHandler(this.dtpDatumTurnira_ValueChanged);
            // 
            // cmbVrijeme
            // 
            this.cmbVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVrijeme.FormattingEnabled = true;
            this.cmbVrijeme.Location = new System.Drawing.Point(134, 100);
            this.cmbVrijeme.Name = "cmbVrijeme";
            this.cmbVrijeme.Size = new System.Drawing.Size(113, 24);
            this.cmbVrijeme.TabIndex = 14;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(190, 138);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(59, 23);
            this.btnOdustani.TabIndex = 15;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // DodavanjeTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(261, 173);
            this.ControlBox = false;
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cmbVrijeme);
            this.Controls.Add(this.dtpDatumTurnira);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTurnirNaziv);
            this.Controls.Add(this.Naziv);
            this.Name = "DodavanjeTurnira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje turnira";
            this.Load += new System.EventHandler(this.DodavanjeTurnira_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTurnirNaziv;
        internal System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DateTimePicker dtpDatumTurnira;
        private System.Windows.Forms.ComboBox cmbVrijeme;
        private System.Windows.Forms.Button btnOdustani;
    }
}