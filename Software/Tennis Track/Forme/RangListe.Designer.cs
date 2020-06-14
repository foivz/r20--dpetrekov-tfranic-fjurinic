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
            this.txtPrezimeIliImeKorisnika = new System.Windows.Forms.TextBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
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
            // txtPrezimeIliImeKorisnika
            // 
            this.txtPrezimeIliImeKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezimeIliImeKorisnika.Location = new System.Drawing.Point(44, 365);
            this.txtPrezimeIliImeKorisnika.Multiline = true;
            this.txtPrezimeIliImeKorisnika.Name = "txtPrezimeIliImeKorisnika";
            this.txtPrezimeIliImeKorisnika.Size = new System.Drawing.Size(225, 30);
            this.txtPrezimeIliImeKorisnika.TabIndex = 4;
            this.txtPrezimeIliImeKorisnika.Text = "Unesite prezime ili ime";
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
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Location = new System.Drawing.Point(406, 365);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(125, 30);
            this.btnPrikaziSve.TabIndex = 9;
            this.btnPrikaziSve.Text = "Prikaži sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            // 
            // RangListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.txtPrezimeIliImeKorisnika);
            this.Controls.Add(this.dgvRangLista);
            this.Name = "RangListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rang liste";
            this.Load += new System.EventHandler(this.RangListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRangLista;
        private System.Windows.Forms.TextBox txtPrezimeIliImeKorisnika;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnPrikaziSve;
    }
}