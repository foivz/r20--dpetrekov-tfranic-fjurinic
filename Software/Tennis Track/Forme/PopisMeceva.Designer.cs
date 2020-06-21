namespace Tennis_Track.Forme
{
    partial class PopisMeceva
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
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnMojiMecevi = new System.Windows.Forms.Button();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.dgvPopisMeceva = new System.Windows.Forms.DataGridView();
            this.imePrviClanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDrugiClanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezultatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RezultatiSetova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeTurniraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gboSluzbenost = new System.Windows.Forms.GroupBox();
            this.rbtnNesluzbeni = new System.Windows.Forms.RadioButton();
            this.rbtnSluzbeni = new System.Windows.Forms.RadioButton();
            this.rbtnSviMecevi = new System.Windows.Forms.RadioButton();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.btnDodajMec = new System.Windows.Forms.Button();
            this.mecBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisMeceva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mecBindingSource)).BeginInit();
            this.gboSluzbenost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mecBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Location = new System.Drawing.Point(714, 160);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(130, 30);
            this.btnPrikaziSve.TabIndex = 14;
            this.btnPrikaziSve.Text = "Prikaži sve mečeve";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            this.btnPrikaziSve.Click += new System.EventHandler(this.btnPrikaziSve_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(717, 421);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(15);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(125, 25);
            this.btnPovratak.TabIndex = 13;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnMojiMecevi
            // 
            this.btnMojiMecevi.Location = new System.Drawing.Point(714, 124);
            this.btnMojiMecevi.Name = "btnMojiMecevi";
            this.btnMojiMecevi.Size = new System.Drawing.Size(130, 30);
            this.btnMojiMecevi.TabIndex = 12;
            this.btnMojiMecevi.Text = "Prikaži moje mečeve";
            this.btnMojiMecevi.UseVisualStyleBackColor = true;
            this.btnMojiMecevi.Click += new System.EventHandler(this.btnMojiMecevi_Click);
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretrazivanje.Location = new System.Drawing.Point(34, 380);
            this.txtPretrazivanje.Multiline = true;
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(311, 30);
            this.txtPretrazivanje.TabIndex = 11;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged);
            // 
            // dgvPopisMeceva
            // 
            this.dgvPopisMeceva.AutoGenerateColumns = false;
            this.dgvPopisMeceva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisMeceva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imePrviClanDataGridViewTextBoxColumn,
            this.imeDrugiClanDataGridViewTextBoxColumn,
            this.rezultatDataGridViewTextBoxColumn,
            this.RezultatiSetova,
            this.imeTurniraDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn,
            this.terenDataGridViewTextBoxColumn});
            this.dgvPopisMeceva.DataSource = this.mecBindingSource;
            this.dgvPopisMeceva.Location = new System.Drawing.Point(34, 25);
            this.dgvPopisMeceva.Name = "dgvPopisMeceva";
            this.dgvPopisMeceva.Size = new System.Drawing.Size(674, 318);
            this.dgvPopisMeceva.TabIndex = 10;
            // 
            // imePrviClanDataGridViewTextBoxColumn
            // 
            this.imePrviClanDataGridViewTextBoxColumn.DataPropertyName = "ImePrviClan";
            this.imePrviClanDataGridViewTextBoxColumn.HeaderText = "ImePrviClan";
            this.imePrviClanDataGridViewTextBoxColumn.Name = "imePrviClanDataGridViewTextBoxColumn";
            // 
            // imeDrugiClanDataGridViewTextBoxColumn
            // 
            this.imeDrugiClanDataGridViewTextBoxColumn.DataPropertyName = "ImeDrugiClan";
            this.imeDrugiClanDataGridViewTextBoxColumn.HeaderText = "ImeDrugiClan";
            this.imeDrugiClanDataGridViewTextBoxColumn.Name = "imeDrugiClanDataGridViewTextBoxColumn";
            // 
            // rezultatDataGridViewTextBoxColumn
            // 
            this.rezultatDataGridViewTextBoxColumn.DataPropertyName = "Rezultat";
            this.rezultatDataGridViewTextBoxColumn.HeaderText = "Rezultat";
            this.rezultatDataGridViewTextBoxColumn.Name = "rezultatDataGridViewTextBoxColumn";
            // 
            // RezultatiSetova
            // 
            this.RezultatiSetova.DataPropertyName = "RezultatiSetova";
            this.RezultatiSetova.HeaderText = "RezultatiSetova";
            this.RezultatiSetova.Name = "RezultatiSetova";
            // 
            // imeTurniraDataGridViewTextBoxColumn
            // 
            this.imeTurniraDataGridViewTextBoxColumn.DataPropertyName = "ImeTurnira";
            this.imeTurniraDataGridViewTextBoxColumn.HeaderText = "ImeTurnira";
            this.imeTurniraDataGridViewTextBoxColumn.Name = "imeTurniraDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // vrijemeDataGridViewTextBoxColumn
            // 
            this.vrijemeDataGridViewTextBoxColumn.DataPropertyName = "Vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.HeaderText = "Vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.Name = "vrijemeDataGridViewTextBoxColumn";
            // 
            // terenDataGridViewTextBoxColumn
            // 
            this.terenDataGridViewTextBoxColumn.DataPropertyName = "Teren";
            this.terenDataGridViewTextBoxColumn.HeaderText = "Teren";
            this.terenDataGridViewTextBoxColumn.Name = "terenDataGridViewTextBoxColumn";
            // 
            // mecBindingSource
            // 
            this.mecBindingSource.DataSource = typeof(Tennis_Track.Baza_podataka.Mec);
            // 
            // gboSluzbenost
            // 
            this.gboSluzbenost.Controls.Add(this.rbtnNesluzbeni);
            this.gboSluzbenost.Controls.Add(this.rbtnSluzbeni);
            this.gboSluzbenost.Controls.Add(this.rbtnSviMecevi);
            this.gboSluzbenost.Location = new System.Drawing.Point(714, 25);
            this.gboSluzbenost.Name = "gboSluzbenost";
            this.gboSluzbenost.Size = new System.Drawing.Size(128, 78);
            this.gboSluzbenost.TabIndex = 15;
            this.gboSluzbenost.TabStop = false;
            // 
            // rbtnNesluzbeni
            // 
            this.rbtnNesluzbeni.AutoSize = true;
            this.rbtnNesluzbeni.Location = new System.Drawing.Point(8, 56);
            this.rbtnNesluzbeni.Name = "rbtnNesluzbeni";
            this.rbtnNesluzbeni.Size = new System.Drawing.Size(114, 17);
            this.rbtnNesluzbeni.TabIndex = 2;
            this.rbtnNesluzbeni.Text = "Neslužbeni mečevi";
            this.rbtnNesluzbeni.UseVisualStyleBackColor = true;
            // 
            // rbtnSluzbeni
            // 
            this.rbtnSluzbeni.AutoSize = true;
            this.rbtnSluzbeni.Location = new System.Drawing.Point(7, 33);
            this.rbtnSluzbeni.Name = "rbtnSluzbeni";
            this.rbtnSluzbeni.Size = new System.Drawing.Size(102, 17);
            this.rbtnSluzbeni.TabIndex = 1;
            this.rbtnSluzbeni.Text = "Službeni mečevi";
            this.rbtnSluzbeni.UseVisualStyleBackColor = true;
            // 
            // rbtnSviMecevi
            // 
            this.rbtnSviMecevi.AutoSize = true;
            this.rbtnSviMecevi.Checked = true;
            this.rbtnSviMecevi.Location = new System.Drawing.Point(7, 10);
            this.rbtnSviMecevi.Name = "rbtnSviMecevi";
            this.rbtnSviMecevi.Size = new System.Drawing.Size(77, 17);
            this.rbtnSviMecevi.TabIndex = 0;
            this.rbtnSviMecevi.TabStop = true;
            this.rbtnSviMecevi.Text = "Svi mečevi";
            this.rbtnSviMecevi.UseVisualStyleBackColor = true;
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPretrazivanje.Location = new System.Drawing.Point(34, 361);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(312, 16);
            this.lblPretrazivanje.TabIndex = 16;
            this.lblPretrazivanje.Text = "Pretraživanje po imenu, prezimenu ili turniru:";
            // 
            // btnDodajMec
            // 
            this.btnDodajMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajMec.Location = new System.Drawing.Point(714, 277);
            this.btnDodajMec.Name = "btnDodajMec";
            this.btnDodajMec.Size = new System.Drawing.Size(128, 66);
            this.btnDodajMec.TabIndex = 17;
            this.btnDodajMec.Text = "Dodaj meč";
            this.btnDodajMec.UseVisualStyleBackColor = true;
            this.btnDodajMec.Click += new System.EventHandler(this.btnDodajMec_Click);
            // 
            // mecBindingSource1
            // 
            this.mecBindingSource1.DataSource = typeof(Tennis_Track.Baza_podataka.Mec);
            // 
            // PopisMeceva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 457);
            this.ControlBox = false;
            this.Controls.Add(this.btnDodajMec);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.gboSluzbenost);
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnMojiMecevi);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.dgvPopisMeceva);
            this.Name = "PopisMeceva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis mečeva";
            this.Load += new System.EventHandler(this.PopisMeceva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisMeceva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mecBindingSource)).EndInit();
            this.gboSluzbenost.ResumeLayout(false);
            this.gboSluzbenost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mecBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaziSve;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnMojiMecevi;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.DataGridView dgvPopisMeceva;
        private System.Windows.Forms.GroupBox gboSluzbenost;
        private System.Windows.Forms.RadioButton rbtnNesluzbeni;
        private System.Windows.Forms.RadioButton rbtnSluzbeni;
        private System.Windows.Forms.RadioButton rbtnSviMecevi;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.Button btnDodajMec;
        private System.Windows.Forms.BindingSource mecBindingSource;
        private System.Windows.Forms.BindingSource mecBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrviClanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDrugiClanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezultatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezultatiSetova;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeTurniraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terenDataGridViewTextBoxColumn;
    }
}