using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennis_Track.Baza_podataka;
using Tennis_Track.Klase;


namespace Tennis_Track.Forme
{
    public partial class PopisMeceva : Form
    {
        TennisTrackEntities tennisTrackEntities = new TennisTrackEntities();
        private GlavniIzbornik glavniIzbornik;
        public PopisMeceva()
        {
            InitializeComponent();
        }

        public PopisMeceva(GlavniIzbornik glavniIzbornik)
        {
            this.glavniIzbornik = glavniIzbornik;
            InitializeComponent();
        }
        private void PopisMeceva_Load(object sender, EventArgs e)
        {
            var mecevi = from m in tennisTrackEntities.Mec select m;//m.ImePrviClan, m.ImeDrugiClan, m.Rezultat, m.Turnir, m.VrstaTerena, m.Datum, m.Vrijeme;
            mecBindingSource.DataSource = mecevi.ToList();
            gboSluzbenost.BackColor = System.Drawing.Color.Transparent;

            for (int i = 0; i < dgvPopisMeceva.Columns.Count; i++)
            {
                dgvPopisMeceva.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                if(i!=dgvPopisMeceva.Columns.Count)
                    dgvPopisMeceva.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            dgvPopisMeceva.AllowUserToAddRows = false;
            dgvPopisMeceva.RowHeadersVisible = false;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            glavniIzbornik.Show();
            this.Close();
        }

        private void btnDodajMec_Click(object sender, EventArgs e)
        {
            Mecevi mecevi = new Mecevi(this);
            this.Hide();
            mecevi.ShowDialog();
        }

        private void txtPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            string pretraga = txtPretrazivanje.Text;
            var pretragaMeceva = from m in tennisTrackEntities.Mec
                                 where m.Clan.Ime.Contains(pretraga) || m.Clan.Prezime.Contains(pretraga) ||
                                 m.Clan1.Ime.Contains(pretraga) || m.Clan1.Prezime.Contains(pretraga) 
                                 || m.Turnir.Naziv.Contains(pretraga)
                                 select m;
            mecBindingSource.DataSource = pretragaMeceva.ToList();
        }
    }
}
