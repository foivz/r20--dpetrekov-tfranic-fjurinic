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
    public partial class RangListe : Form
    {
        TennisTrackEntities tennisTrackEntities = new TennisTrackEntities();
        private GlavniIzbornik glavniIzbornik;

        public RangListe()
        {
            InitializeComponent();
        }

        public RangListe(GlavniIzbornik glavniIzbornik)
        {
            this.glavniIzbornik = glavniIzbornik;
            InitializeComponent();
        }

        private void RangListe_Load(object sender, EventArgs e)
        {
            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Rang";
            dgvRangLista.Columns.Insert(0, col);
            RangiranjePoBodovima();
        }
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            glavniIzbornik.Show();
            this.Close();
        }

        public void RangiranjePoBodovima() 
        {
                List<Clan> clanoviLista = (from c in tennisTrackEntities.Clan select c).ToList();
                List<Clan> sortiranaLista = clanoviLista.OrderByDescending(c => c.BrojBodova).ToList();
                clanBindingSource.DataSource = sortiranaLista.ToList();

                

                for (int i = 0; i < dgvRangLista.Rows.Count; i++)
                {
                    int rang = i + 1;
                    dgvRangLista.Rows[i].Cells[0].Value = rang + ".".ToString();
                }

                for (int i = 0; i < dgvRangLista.Columns.Count; i++)
                {
                    dgvRangLista.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvRangLista.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvRangLista.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                dgvRangLista.AllowUserToAddRows = false;
                dgvRangLista.RowHeadersVisible = false;

                dgvRangLista.Columns[3].HeaderText = "Broj bodova";
                dgvRangLista.Columns[4].HeaderText = "Sluzbenih pobjeda";
                dgvRangLista.Columns[5].HeaderText = "Ukupno pobjeda";
                dgvRangLista.Columns[6].HeaderText = "Korisnicko ime";

                gboRangiranje.BackColor = System.Drawing.Color.Transparent;
        }

        private void rbtnBodovi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBodovi.Checked)
            {
                RangiranjePoBodovima();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPobjede.Checked)
            {
                List<Clan> clanoviLista = (from c in tennisTrackEntities.Clan select c).ToList();
                List<Clan> sortiranaLista = clanoviLista.OrderByDescending(c => c.UkupnoPobjeda).ToList();
                clanBindingSource.DataSource = sortiranaLista.ToList();

                for (int i = 0; i < dgvRangLista.Rows.Count; i++)
                {
                    int rang = i + 1;
                    dgvRangLista.Rows[i].Cells[0].Value = rang + ".".ToString();
                }

                for (int i = 0; i < dgvRangLista.Columns.Count; i++)
                {
                    dgvRangLista.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvRangLista.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvRangLista.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                dgvRangLista.AllowUserToAddRows = false;
                dgvRangLista.RowHeadersVisible = false;

                dgvRangLista.Columns[3].HeaderText = "Broj bodova";
                dgvRangLista.Columns[4].HeaderText = "Sluzbenih pobjeda";
                dgvRangLista.Columns[5].HeaderText = "Ukupno pobjeda";
                dgvRangLista.Columns[6].HeaderText = "Korisnicko ime";

                gboRangiranje.BackColor = System.Drawing.Color.Transparent;
            }
        }
    }
}
