namespace Tennis_Track.Forme
{
    partial class RangListe
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
            this.dgvRangLista = new System.Windows.Forms.DataGridView();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.BrojBodova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SluzbenePobjede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnoPobjeda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboRangiranje = new System.Windows.Forms.GroupBox();
            this.rbtnBodovi = new System.Windows.Forms.RadioButton();
            this.rbtnPobjede = new System.Windows.Forms.RadioButton();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangLista)).BeginInit();
            this.gboRangiranje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRangLista
            // 
            this.dgvRangLista.AutoGenerateColumns = false;
            this.dgvRangLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRangLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.BrojBodova,
            this.SluzbenePobjede,
            this.UkupnoPobjeda,
            this.korisnickoImeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dgvRangLista.DataSource = this.clanBindingSource;
            this.dgvRangLista.Location = new System.Drawing.Point(12, 12);
            this.dgvRangLista.Name = "dgvRangLista";
            this.dgvRangLista.Size = new System.Drawing.Size(776, 346);
            this.dgvRangLista.TabIndex = 3;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(651, 401);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(15);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(125, 25);
            this.btnPovratak.TabIndex = 8;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // BrojBodova
            // 
            this.BrojBodova.DataPropertyName = "BrojBodova";
            this.BrojBodova.HeaderText = "BrojBodova";
            this.BrojBodova.Name = "BrojBodova";
            // 
            // SluzbenePobjede
            // 
            this.SluzbenePobjede.DataPropertyName = "SluzbenePobjede";
            this.SluzbenePobjede.HeaderText = "SluzbenePobjede";
            this.SluzbenePobjede.Name = "SluzbenePobjede";
            // 
            // UkupnoPobjeda
            // 
            this.UkupnoPobjeda.DataPropertyName = "UkupnoPobjeda";
            this.UkupnoPobjeda.HeaderText = "UkupnoPobjeda";
            this.UkupnoPobjeda.Name = "UkupnoPobjeda";
            // 
            // gboRangiranje
            // 
            this.gboRangiranje.Controls.Add(this.rbtnPobjede);
            this.gboRangiranje.Controls.Add(this.rbtnBodovi);
            this.gboRangiranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gboRangiranje.Location = new System.Drawing.Point(12, 364);
            this.gboRangiranje.Name = "gboRangiranje";
            this.gboRangiranje.Size = new System.Drawing.Size(282, 47);
            this.gboRangiranje.TabIndex = 9;
            this.gboRangiranje.TabStop = false;
            this.gboRangiranje.Text = "Rangiraj po:";
            // 
            // rbtnBodovi
            // 
            this.rbtnBodovi.AutoSize = true;
            this.rbtnBodovi.Checked = true;
            this.rbtnBodovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnBodovi.Location = new System.Drawing.Point(7, 22);
            this.rbtnBodovi.Name = "rbtnBodovi";
            this.rbtnBodovi.Size = new System.Drawing.Size(88, 19);
            this.rbtnBodovi.TabIndex = 0;
            this.rbtnBodovi.TabStop = true;
            this.rbtnBodovi.Text = "Bodovima";
            this.rbtnBodovi.UseVisualStyleBackColor = true;
            this.rbtnBodovi.CheckedChanged += new System.EventHandler(this.rbtnBodovi_CheckedChanged);
            // 
            // rbtnPobjede
            // 
            this.rbtnPobjede.AutoSize = true;
            this.rbtnPobjede.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnPobjede.Location = new System.Drawing.Point(122, 22);
            this.rbtnPobjede.Name = "rbtnPobjede";
            this.rbtnPobjede.Size = new System.Drawing.Size(158, 19);
            this.rbtnPobjede.TabIndex = 1;
            this.rbtnPobjede.Text = "Ukupnim pobjedama";
            this.rbtnPobjede.UseVisualStyleBackColor = true;
            this.rbtnPobjede.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // korisnickoImeDataGridViewTextBoxColumn
            // 
            this.korisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "KorisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.HeaderText = "KorisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.Name = "korisnickoImeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // clanBindingSource
            // 
            this.clanBindingSource.DataSource = typeof(Tennis_Track.Baza_podataka.Clan);
            // 
            // RangListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gboRangiranje);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.dgvRangLista);
            this.Name = "RangListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rang liste";
            this.Load += new System.EventHandler(this.RangListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangLista)).EndInit();
            this.gboRangiranje.ResumeLayout(false);
            this.gboRangiranje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRangLista;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.BindingSource clanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojBodova;
        private System.Windows.Forms.DataGridViewTextBoxColumn SluzbenePobjede;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnoPobjeda;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gboRangiranje;
        private System.Windows.Forms.RadioButton rbtnPobjede;
        private System.Windows.Forms.RadioButton rbtnBodovi;
    }
}