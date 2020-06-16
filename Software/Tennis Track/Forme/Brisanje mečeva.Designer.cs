namespace Tennis_Track.Forme
{
    partial class Brisanje_mečeva
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
            this.btnPovratak = new System.Windows.Forms.Button();
            this.mecDataGridView = new System.Windows.Forms.DataGridView();
            this.Igrac_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeDrugiClan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBrisiMec = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mecDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(1630, 787);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(15);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(250, 50);
            this.btnPovratak.TabIndex = 8;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // mecDataGridView
            // 
            this.mecDataGridView.AllowUserToAddRows = false;
            this.mecDataGridView.AllowUserToDeleteRows = false;
            this.mecDataGridView.AutoGenerateColumns = false;
            this.mecDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mecDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Igrac_1,
            this.ImeDrugiClan,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.mecDataGridView.DataSource = this.mecBindingSource;
            this.mecDataGridView.Location = new System.Drawing.Point(24, 12);
            this.mecDataGridView.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.mecDataGridView.Name = "mecDataGridView";
            this.mecDataGridView.ReadOnly = true;
            this.mecDataGridView.Size = new System.Drawing.Size(1856, 300);
            this.mecDataGridView.TabIndex = 9;
            // 
            // Igrac_1
            // 
            this.Igrac_1.DataPropertyName = "ImePrviClan";
            this.Igrac_1.HeaderText = "Igrač 1";
            this.Igrac_1.Name = "Igrac_1";
            this.Igrac_1.ReadOnly = true;
            this.Igrac_1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Igrac_1.Width = 150;
            // 
            // ImeDrugiClan
            // 
            this.ImeDrugiClan.DataPropertyName = "ImeDrugiClan";
            this.ImeDrugiClan.HeaderText = "Igrač 2";
            this.ImeDrugiClan.Name = "ImeDrugiClan";
            this.ImeDrugiClan.ReadOnly = true;
            this.ImeDrugiClan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ImeDrugiClan.Width = 150;
            // 
            // btnBrisiMec
            // 
            this.btnBrisiMec.Location = new System.Drawing.Point(1630, 707);
            this.btnBrisiMec.Margin = new System.Windows.Forms.Padding(15);
            this.btnBrisiMec.Name = "btnBrisiMec";
            this.btnBrisiMec.Size = new System.Drawing.Size(250, 50);
            this.btnBrisiMec.TabIndex = 10;
            this.btnBrisiMec.Text = "Obriši meč";
            this.btnBrisiMec.UseVisualStyleBackColor = true;
            this.btnBrisiMec.Click += new System.EventHandler(this.btnBrisiMec_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "šifra meča";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ImeTurnira";
            this.dataGridViewTextBoxColumn11.HeaderText = "Turnir";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Rezultat";
            this.dataGridViewTextBoxColumn12.HeaderText = "Rezultat";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn6.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Vrijeme";
            this.dataGridViewTextBoxColumn7.HeaderText = "Vrijeme";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // mecBindingSource
            // 
            this.mecBindingSource.DataSource = typeof(Tennis_Track.Baza_podataka.Mec);
            // 
            // Brisanje_mečeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 861);
            this.ControlBox = false;
            this.Controls.Add(this.mecDataGridView);
            this.Controls.Add(this.btnBrisiMec);
            this.Controls.Add(this.btnPovratak);
            this.Name = "Brisanje_mečeva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brisanje mečeva";
            this.Load += new System.EventHandler(this.Brisanje_mečeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mecDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mecBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.BindingSource mecBindingSource;
        private System.Windows.Forms.DataGridView mecDataGridView;
        private System.Windows.Forms.Button btnBrisiMec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Igrac_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeDrugiClan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}