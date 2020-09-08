namespace Tennis_Track.Forme
{
    partial class JedanTurnir
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTurnirVrijeme = new System.Windows.Forms.TextBox();
            this.txtTurnirDatum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTurnirNaziv = new System.Windows.Forms.TextBox();
            this.Naziv = new System.Windows.Forms.Label();
            this.sudioniciDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sudioniciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTurnirVrijeme);
            this.groupBox1.Controls.Add(this.txtTurnirDatum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTurnirNaziv);
            this.groupBox1.Controls.Add(this.Naziv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 142);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije o turniru";
            // 
            // txtTurnirVrijeme
            // 
            this.txtTurnirVrijeme.Location = new System.Drawing.Point(122, 105);
            this.txtTurnirVrijeme.Name = "txtTurnirVrijeme";
            this.txtTurnirVrijeme.ReadOnly = true;
            this.txtTurnirVrijeme.Size = new System.Drawing.Size(55, 22);
            this.txtTurnirVrijeme.TabIndex = 5;
            // 
            // txtTurnirDatum
            // 
            this.txtTurnirDatum.Location = new System.Drawing.Point(63, 68);
            this.txtTurnirDatum.Name = "txtTurnirDatum";
            this.txtTurnirDatum.ReadOnly = true;
            this.txtTurnirDatum.Size = new System.Drawing.Size(65, 22);
            this.txtTurnirDatum.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vrijeme početka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datum:";
            // 
            // txtTurnirNaziv
            // 
            this.txtTurnirNaziv.Location = new System.Drawing.Point(58, 27);
            this.txtTurnirNaziv.Name = "txtTurnirNaziv";
            this.txtTurnirNaziv.ReadOnly = true;
            this.txtTurnirNaziv.Size = new System.Drawing.Size(175, 22);
            this.txtTurnirNaziv.TabIndex = 1;
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(7, 30);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(45, 16);
            this.Naziv.TabIndex = 0;
            this.Naziv.Text = "Naziv:";
            // 
            // sudioniciDataGridView
            // 
            this.sudioniciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sudioniciDataGridView.Location = new System.Drawing.Point(301, 43);
            this.sudioniciDataGridView.Name = "sudioniciDataGridView";
            this.sudioniciDataGridView.Size = new System.Drawing.Size(349, 192);
            this.sudioniciDataGridView.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Sudionici:";
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(13, 162);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(118, 23);
            this.btnPrijava.TabIndex = 35;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(147, 162);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(118, 23);
            this.btnOdjava.TabIndex = 36;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(525, 241);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(15);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(125, 25);
            this.btnPovratak.TabIndex = 37;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // JedanTurnir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 272);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sudioniciDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "JedanTurnir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnir";
            this.Load += new System.EventHandler(this.JedanTurnir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sudioniciDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTurnirVrijeme;
        private System.Windows.Forms.TextBox txtTurnirDatum;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTurnirNaziv;
        internal System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.DataGridView sudioniciDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnPovratak;
    }
}