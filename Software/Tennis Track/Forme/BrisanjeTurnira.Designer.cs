namespace Tennis_Track.Forme
{
    partial class BrisanjeTurnira
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
            this.dgvTurniri = new System.Windows.Forms.DataGridView();
            this.Pretrazi = new System.Windows.Forms.Label();
            this.txtTurnir = new System.Windows.Forms.TextBox();
            this.btnBrisiTurnir = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurniri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurniri
            // 
            this.dgvTurniri.AutoGenerateColumns = false;
            this.dgvTurniri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurniri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn});
            this.dgvTurniri.DataSource = this.turnirBindingSource;
            this.dgvTurniri.Location = new System.Drawing.Point(13, 13);
            this.dgvTurniri.Name = "dgvTurniri";
            this.dgvTurniri.Size = new System.Drawing.Size(452, 317);
            this.dgvTurniri.TabIndex = 0;
            // 
            // Pretrazi
            // 
            this.Pretrazi.AutoSize = true;
            this.Pretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pretrazi.Location = new System.Drawing.Point(14, 340);
            this.Pretrazi.Name = "Pretrazi";
            this.Pretrazi.Size = new System.Drawing.Size(56, 16);
            this.Pretrazi.TabIndex = 1;
            this.Pretrazi.Text = "Pretraži:";
            this.Pretrazi.Click += new System.EventHandler(this.Pretrazi_Click);
            // 
            // txtTurnir
            // 
            this.txtTurnir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurnir.Location = new System.Drawing.Point(76, 337);
            this.txtTurnir.Name = "txtTurnir";
            this.txtTurnir.Size = new System.Drawing.Size(151, 22);
            this.txtTurnir.TabIndex = 2;
            this.txtTurnir.TextChanged += new System.EventHandler(this.txtTurnir_TextChanged);
            // 
            // btnBrisiTurnir
            // 
            this.btnBrisiTurnir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisiTurnir.Location = new System.Drawing.Point(281, 336);
            this.btnBrisiTurnir.Name = "btnBrisiTurnir";
            this.btnBrisiTurnir.Size = new System.Drawing.Size(103, 23);
            this.btnBrisiTurnir.TabIndex = 3;
            this.btnBrisiTurnir.Text = "Obriši turnir";
            this.btnBrisiTurnir.UseVisualStyleBackColor = true;
            this.btnBrisiTurnir.Click += new System.EventHandler(this.btnBrisiTurnir_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(390, 336);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 4;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
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
            // BrisanjeTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 372);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnBrisiTurnir);
            this.Controls.Add(this.txtTurnir);
            this.Controls.Add(this.Pretrazi);
            this.Controls.Add(this.dgvTurniri);
            this.Name = "BrisanjeTurnira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brisanje turnira";
            this.Load += new System.EventHandler(this.BrisanjeTurnira_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurniri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnirBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurniri;
        private System.Windows.Forms.Label Pretrazi;
        private System.Windows.Forms.TextBox txtTurnir;
        private System.Windows.Forms.Button btnBrisiTurnir;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource turnirBindingSource;
    }
}