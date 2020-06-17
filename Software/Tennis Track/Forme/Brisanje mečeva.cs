using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennis_Track.Baza_podataka;

namespace Tennis_Track.Forme
{
    public partial class Brisanje_mečeva : Form
    {
        private AdminPanel adminPanel;
        private TennisTrackEntities tennisTrackEntities = new TennisTrackEntities();

        public Brisanje_mečeva()
        {
            InitializeComponent();
        }

        public Brisanje_mečeva(AdminPanel adminPanel)
        {
            this.adminPanel = adminPanel;
            InitializeComponent();
        }

        private void Brisanje_mečeva_Load(object sender, EventArgs e)
        {
            mecDataGridView.AllowUserToAddRows = false;
            mecDataGridView.RowHeadersVisible = false;
            OsvjeziMeceve();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            adminPanel.Show();
            this.Close();
        }

        private void btnBrisiMec_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Obrisati čete meč. Želite li nastaviti?","Upozorenje", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Mec mecZaObrisati = mecBindingSource.Current as Mec;
                mecBindingSource.Remove(mecZaObrisati);
                tennisTrackEntities.Mec.Remove(mecZaObrisati);
                tennisTrackEntities.SaveChanges();
                OsvjeziMeceve();
            }
        }

        private void OsvjeziMeceve()
        {
            int ukupnaSirinaStupaca = 0;
            tennisTrackEntities.Mec.Load();
            mecBindingSource.DataSource = tennisTrackEntities.Mec.Local;
            for (int i = 0; i < mecDataGridView.Columns.Count; i++)
            {
                mecDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                ukupnaSirinaStupaca = ukupnaSirinaStupaca + mecDataGridView.Columns[i].Width;
            }

            int razlikaSirine = mecDataGridView.Width - ukupnaSirinaStupaca;

            for (int i = 0; i <= mecDataGridView.Columns.Count - 1; i++)
            {
                mecDataGridView.Columns[i].DefaultCellStyle.Font = new Font("Arial", 18F, GraphicsUnit.Pixel);
                int colw = mecDataGridView.Columns[i].Width + razlikaSirine/8;
                mecDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                mecDataGridView.Columns[i].Width = colw;

                mecDataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            mecDataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
