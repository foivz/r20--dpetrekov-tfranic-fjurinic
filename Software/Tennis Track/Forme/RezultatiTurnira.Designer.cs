namespace Tennis_Track.Forme
{
    partial class RezultatiTurnira
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
            this.dgvRezultatiTurnira = new System.Windows.Forms.DataGridView();
            this.imePrviClanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDrugiClanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezultatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezultatiSetovaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNazivTurnira = new System.Windows.Forms.Label();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.txtClan = new System.Windows.Forms.TextBox();
            this.Pretrazi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultatiTurnira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRezultatiTurnira
            // 
            this.dgvRezultatiTurnira.AutoGenerateColumns = false;
            this.dgvRezultatiTurnira.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezultatiTurnira.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imePrviClanDataGridViewTextBoxColumn,
            this.imeDrugiClanDataGridViewTextBoxColumn,
            this.rezultatDataGridViewTextBoxColumn,
            this.rezultatiSetovaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn,
            this.terenDataGridViewTextBoxColumn});
            this.dgvRezultatiTurnira.DataSource = this.mecBindingSource;
            this.dgvRezultatiTurnira.Location = new System.Drawing.Point(12, 55);
            this.dgvRezultatiTurnira.Name = "dgvRezultatiTurnira";
            this.dgvRezultatiTurnira.Size = new System.Drawing.Size(621, 356);
            this.dgvRezultatiTurnira.TabIndex = 0;
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
            // rezultatiSetovaDataGridViewTextBoxColumn
            // 
            this.rezultatiSetovaDataGridViewTextBoxColumn.DataPropertyName = "RezultatiSetova";
            this.rezultatiSetovaDataGridViewTextBoxColumn.HeaderText = "RezultatiSetova";
            this.rezultatiSetovaDataGridViewTextBoxColumn.Name = "rezultatiSetovaDataGridViewTextBoxColumn";
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
            // lblNazivTurnira
            // 
            this.lblNazivTurnira.AutoSize = true;
            this.lblNazivTurnira.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivTurnira.Location = new System.Drawing.Point(12, 19);
            this.lblNazivTurnira.Name = "lblNazivTurnira";
            this.lblNazivTurnira.Size = new System.Drawing.Size(60, 24);
            this.lblNazivTurnira.TabIndex = 1;
            this.lblNazivTurnira.Text = "label1";
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(508, 417);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(15);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(125, 25);
            this.btnPovratak.TabIndex = 38;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // txtClan
            // 
            this.txtClan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClan.Location = new System.Drawing.Point(78, 418);
            this.txtClan.Name = "txtClan";
            this.txtClan.Size = new System.Drawing.Size(151, 22);
            this.txtClan.TabIndex = 40;
            this.txtClan.TextChanged += new System.EventHandler(this.txtClan_TextChanged);
            // 
            // Pretrazi
            // 
            this.Pretrazi.AutoSize = true;
            this.Pretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pretrazi.Location = new System.Drawing.Point(16, 421);
            this.Pretrazi.Name = "Pretrazi";
            this.Pretrazi.Size = new System.Drawing.Size(56, 16);
            this.Pretrazi.TabIndex = 39;
            this.Pretrazi.Text = "Pretraži:";
            // 
            // RezultatiTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtClan);
            this.Controls.Add(this.Pretrazi);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.lblNazivTurnira);
            this.Controls.Add(this.dgvRezultatiTurnira);
            this.Name = "RezultatiTurnira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezultati turnira";
            this.Load += new System.EventHandler(this.RezultatiTurnira_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultatiTurnira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mecBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRezultatiTurnira;
        private System.Windows.Forms.Label lblNazivTurnira;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.BindingSource mecBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrviClanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDrugiClanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezultatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezultatiSetovaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terenDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtClan;
        private System.Windows.Forms.Label Pretrazi;
    }
}