namespace Tennis_Track.Forme
{
    partial class Turniri
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
            this.lblPopis = new System.Windows.Forms.Label();
            this.turniriDataGridView = new System.Windows.Forms.DataGridView();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnPrikaziTurnir = new System.Windows.Forms.Button();
            this.btnPrikaziRezultateTurnira = new System.Windows.Forms.Button();
            this.btnDodajTurnir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnNadolazeci = new System.Windows.Forms.RadioButton();
            this.rbtnPrijasnji = new System.Windows.Forms.RadioButton();
            this.rbtnSviTurniri = new System.Windows.Forms.RadioButton();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnirBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.turnirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTurniri = new System.Windows.Forms.TextBox();
            this.Pretrazi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turniriDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnirBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPopis
            // 
            this.lblPopis.AutoSize = true;
            this.lblPopis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPopis.Location = new System.Drawing.Point(12, 25);
            this.lblPopis.Name = "lblPopis";
            this.lblPopis.Size = new System.Drawing.Size(78, 13);
            this.lblPopis.TabIndex = 28;
            this.lblPopis.Text = "Popis turnira";
            // 
            // turniriDataGridView
            // 
            this.turniriDataGridView.AutoGenerateColumns = false;
            this.turniriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turniriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn});
            this.turniriDataGridView.DataSource = this.turnirBindingSource1;
            this.turniriDataGridView.Location = new System.Drawing.Point(13, 42);
            this.turniriDataGridView.Name = "turniriDataGridView";
            this.turniriDataGridView.Size = new System.Drawing.Size(345, 327);
            this.turniriDataGridView.TabIndex = 29;
            this.turniriDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.turniriDataGridView_CellClick);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(366, 372);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(15);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(125, 25);
            this.btnPovratak.TabIndex = 30;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnPrikaziTurnir
            // 
            this.btnPrikaziTurnir.Location = new System.Drawing.Point(364, 183);
            this.btnPrikaziTurnir.Name = "btnPrikaziTurnir";
            this.btnPrikaziTurnir.Size = new System.Drawing.Size(125, 23);
            this.btnPrikaziTurnir.TabIndex = 31;
            this.btnPrikaziTurnir.Text = "Prikaži turnir / Prijava";
            this.btnPrikaziTurnir.UseVisualStyleBackColor = true;
            this.btnPrikaziTurnir.Click += new System.EventHandler(this.btnPrikaziTurnir_Click);
            // 
            // btnPrikaziRezultateTurnira
            // 
            this.btnPrikaziRezultateTurnira.Location = new System.Drawing.Point(364, 212);
            this.btnPrikaziRezultateTurnira.Name = "btnPrikaziRezultateTurnira";
            this.btnPrikaziRezultateTurnira.Size = new System.Drawing.Size(125, 23);
            this.btnPrikaziRezultateTurnira.TabIndex = 32;
            this.btnPrikaziRezultateTurnira.Text = "Prikaži rezultate turnira";
            this.btnPrikaziRezultateTurnira.UseVisualStyleBackColor = true;
            this.btnPrikaziRezultateTurnira.Click += new System.EventHandler(this.btnPrikaziRezultateTurnira_Click);
            // 
            // btnDodajTurnir
            // 
            this.btnDodajTurnir.Location = new System.Drawing.Point(364, 43);
            this.btnDodajTurnir.Name = "btnDodajTurnir";
            this.btnDodajTurnir.Size = new System.Drawing.Size(123, 23);
            this.btnDodajTurnir.TabIndex = 33;
            this.btnDodajTurnir.Text = "Dodaj turnir";
            this.btnDodajTurnir.UseVisualStyleBackColor = true;
            this.btnDodajTurnir.Click += new System.EventHandler(this.btnDodajTurnir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtnNadolazeci);
            this.groupBox1.Controls.Add(this.rbtnPrijasnji);
            this.groupBox1.Controls.Add(this.rbtnSviTurniri);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(366, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 99);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // rbtnNadolazeci
            // 
            this.rbtnNadolazeci.AutoSize = true;
            this.rbtnNadolazeci.Location = new System.Drawing.Point(7, 73);
            this.rbtnNadolazeci.Name = "rbtnNadolazeci";
            this.rbtnNadolazeci.Size = new System.Drawing.Size(95, 20);
            this.rbtnNadolazeci.TabIndex = 2;
            this.rbtnNadolazeci.Text = "Nadolazeći";
            this.rbtnNadolazeci.UseVisualStyleBackColor = true;
            this.rbtnNadolazeci.CheckedChanged += new System.EventHandler(this.rbtnNadolazeci_CheckedChanged);
            // 
            // rbtnPrijasnji
            // 
            this.rbtnPrijasnji.AutoSize = true;
            this.rbtnPrijasnji.Location = new System.Drawing.Point(7, 48);
            this.rbtnPrijasnji.Name = "rbtnPrijasnji";
            this.rbtnPrijasnji.Size = new System.Drawing.Size(73, 20);
            this.rbtnPrijasnji.TabIndex = 1;
            this.rbtnPrijasnji.Text = "Prijašnji";
            this.rbtnPrijasnji.UseVisualStyleBackColor = true;
            this.rbtnPrijasnji.CheckedChanged += new System.EventHandler(this.rbtnPrijasnji_CheckedChanged);
            // 
            // rbtnSviTurniri
            // 
            this.rbtnSviTurniri.AutoSize = true;
            this.rbtnSviTurniri.Checked = true;
            this.rbtnSviTurniri.Location = new System.Drawing.Point(7, 22);
            this.rbtnSviTurniri.Name = "rbtnSviTurniri";
            this.rbtnSviTurniri.Size = new System.Drawing.Size(79, 20);
            this.rbtnSviTurniri.TabIndex = 0;
            this.rbtnSviTurniri.TabStop = true;
            this.rbtnSviTurniri.Text = "Svi turniri";
            this.rbtnSviTurniri.UseVisualStyleBackColor = true;
            this.rbtnSviTurniri.CheckedChanged += new System.EventHandler(this.rbtnSviTurniri_CheckedChanged);
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
            // turnirBindingSource1
            // 
            this.turnirBindingSource1.DataSource = typeof(Tennis_Track.Baza_podataka.Turnir);
            // 
            // turnirBindingSource
            // 
            this.turnirBindingSource.DataSource = typeof(Tennis_Track.Baza_podataka.Turnir);
            // 
            // txtTurniri
            // 
            this.txtTurniri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurniri.Location = new System.Drawing.Point(76, 375);
            this.txtTurniri.Name = "txtTurniri";
            this.txtTurniri.Size = new System.Drawing.Size(151, 22);
            this.txtTurniri.TabIndex = 36;
            this.txtTurniri.TextChanged += new System.EventHandler(this.txtTurniri_TextChanged);
            // 
            // Pretrazi
            // 
            this.Pretrazi.AutoSize = true;
            this.Pretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pretrazi.Location = new System.Drawing.Point(14, 378);
            this.Pretrazi.Name = "Pretrazi";
            this.Pretrazi.Size = new System.Drawing.Size(56, 16);
            this.Pretrazi.TabIndex = 35;
            this.Pretrazi.Text = "Pretraži:";
            // 
            // Turniri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 409);
            this.ControlBox = false;
            this.Controls.Add(this.txtTurniri);
            this.Controls.Add(this.Pretrazi);
            this.Controls.Add(this.btnPrikaziRezultateTurnira);
            this.Controls.Add(this.btnPrikaziTurnir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodajTurnir);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.turniriDataGridView);
            this.Controls.Add(this.lblPopis);
            this.KeyPreview = true;
            this.Name = "Turniri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turniri";
            this.Load += new System.EventHandler(this.Turniri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turniriDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnirBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnirBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPopis;
        private System.Windows.Forms.DataGridView turniriDataGridView;
        private System.Windows.Forms.BindingSource turnirBindingSource;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnPrikaziTurnir;
        private System.Windows.Forms.Button btnPrikaziRezultateTurnira;
        private System.Windows.Forms.Button btnDodajTurnir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnNadolazeci;
        private System.Windows.Forms.RadioButton rbtnPrijasnji;
        private System.Windows.Forms.RadioButton rbtnSviTurniri;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource turnirBindingSource1;
        private System.Windows.Forms.TextBox txtTurniri;
        private System.Windows.Forms.Label Pretrazi;
    }
}