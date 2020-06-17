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
            this.btnBrisiMec = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipTerena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Igrac_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeDrugiClan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaTerena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mecDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terenBindingSource)).BeginInit();
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
            this.VrstaTerena,
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
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(216, 330);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(15);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(358, 35);
            this.txtFilter.TabIndex = 11;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ime igrača: ";
            // 
            // txtTipTerena
            // 
            this.txtTipTerena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipTerena.Location = new System.Drawing.Point(216, 395);
            this.txtTipTerena.Margin = new System.Windows.Forms.Padding(15);
            this.txtTipTerena.Name = "txtTipTerena";
            this.txtTipTerena.Size = new System.Drawing.Size(358, 35);
            this.txtTipTerena.TabIndex = 13;
            this.txtTipTerena.TextChanged += new System.EventHandler(this.txtTipTerena_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tip terena:";
            // 
            // mecBindingSource
            // 
            this.mecBindingSource.DataSource = typeof(Tennis_Track.Baza_podataka.Mec);
            // 
            // terenBindingSource
            // 
            this.terenBindingSource.DataSource = typeof(Tennis_Track.Baza_podataka.Teren);
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
            // VrstaTerena
            // 
            this.VrstaTerena.DataPropertyName = "VrstaTerena";
            this.VrstaTerena.HeaderText = "Vrsta terena";
            this.VrstaTerena.Name = "VrstaTerena";
            this.VrstaTerena.ReadOnly = true;
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
            // Brisanje_mečeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 861);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTipTerena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.mecDataGridView);
            this.Controls.Add(this.btnBrisiMec);
            this.Controls.Add(this.btnPovratak);
            this.Name = "Brisanje_mečeva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brisanje mečeva";
            this.Load += new System.EventHandler(this.Brisanje_mečeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mecDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.BindingSource mecBindingSource;
        private System.Windows.Forms.DataGridView mecDataGridView;
        private System.Windows.Forms.Button btnBrisiMec;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource terenBindingSource;
        private System.Windows.Forms.TextBox txtTipTerena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Igrac_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeDrugiClan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaTerena;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}