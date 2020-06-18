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
            var mecevi = from m in tennisTrackEntities.Mec select m;
            mecBindingSource.DataSource = mecevi.ToList();
            gboSluzbenost.BackColor = System.Drawing.Color.Transparent;
            lblPretrazivanje.BackColor = System.Drawing.Color.Transparent;

            for (int i = 0; i < dgvPopisMeceva.Columns.Count; i++)
            {
                dgvPopisMeceva.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvPopisMeceva.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPopisMeceva.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvPopisMeceva.AllowUserToAddRows = false;
            dgvPopisMeceva.RowHeadersVisible = false;
            dgvPopisMeceva.Columns[0].HeaderText = "Prvi igrač";
            dgvPopisMeceva.Columns[1].HeaderText = "Drugi igrač";
            dgvPopisMeceva.Columns[3].HeaderText = "Setovi";
            dgvPopisMeceva.Columns[4].HeaderText = "Ime turnira";

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

        private void btnMojiMecevi_Click(object sender, EventArgs e)
        {
            if(rbtnSviMecevi.Checked)
            {
                var sviMojiMecevi = from m in tennisTrackEntities.Mec
                                    where m.Clan.ID == PrijavaClana.PrijavljeniCLan.ID ||
                                    m.Clan1.ID == PrijavaClana.PrijavljeniCLan.ID
                                    select m;
                mecBindingSource.DataSource = sviMojiMecevi.ToList();
            }

            else if (rbtnSluzbeni.Checked)
            {
                var mojiSluzbeniMecevi = from m in tennisTrackEntities.Mec
                                         where (m.Clan.ID == PrijavaClana.PrijavljeniCLan.ID ||
                                         m.Clan1.ID == PrijavaClana.PrijavljeniCLan.ID) && m.Turnir_Id!=null
                                         select m;
                mecBindingSource.DataSource = mojiSluzbeniMecevi.ToList();
            }
            else
            {
                var mojiNesluzbeniMecevi = from m in tennisTrackEntities.Mec 
                                           where(m.Clan.ID == PrijavaClana.PrijavljeniCLan.ID ||
                                           m.Clan1.ID == PrijavaClana.PrijavljeniCLan.ID) && m.Turnir_Id == null
                                           select m;
                mecBindingSource.DataSource = mojiNesluzbeniMecevi.ToList();
            }
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            if (rbtnSviMecevi.Checked)
            {
                var sviMecevi = from m in tennisTrackEntities.Mec select m;
                mecBindingSource.DataSource = sviMecevi.ToList();
            }
            else if (rbtnSluzbeni.Checked)
            {
                var sviSluzbeniMecevi = from m in tennisTrackEntities.Mec where m.Turnir_Id != null select m;
                mecBindingSource.DataSource = sviSluzbeniMecevi.ToList();
            }
            else
            {
                var sviNesluzbeniMecevi = from m in tennisTrackEntities.Mec where m.Turnir_Id == null select m;
                mecBindingSource.DataSource = sviNesluzbeniMecevi.ToList();
            }
        }
    }
}
