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
            this.dgvRangLista = new System.Windows.Forms.DataGridView();
            this.txtPrezimeKorisnika = new System.Windows.Forms.TextBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRangLista
            // 
            this.dgvRangLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRangLista.Location = new System.Drawing.Point(44, 56);
            this.dgvRangLista.Name = "dgvRangLista";
            this.dgvRangLista.Size = new System.Drawing.Size(712, 303);
            this.dgvRangLista.TabIndex = 3;
            // 
            // txtPrezimeKorisnika
            // 
            this.txtPrezimeKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezimeKorisnika.Location = new System.Drawing.Point(44, 365);
            this.txtPrezimeKorisnika.Multiline = true;
            this.txtPrezimeKorisnika.Name = "txtPrezimeKorisnika";
            this.txtPrezimeKorisnika.Size = new System.Drawing.Size(225, 30);
            this.txtPrezimeKorisnika.TabIndex = 4;
            this.txtPrezimeKorisnika.Text = "Unesite prezime korisnika";
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(275, 364);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(125, 30);
            this.btnFiltriraj.TabIndex = 5;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
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
            // 
            // RangListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.txtPrezimeKorisnika);
            this.Controls.Add(this.dgvRangLista);
            this.Name = "RangListe";
            this.Text = "Rang liste";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRangLista;
        private System.Windows.Forms.TextBox txtPrezimeKorisnika;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnPovratak;
    }
}