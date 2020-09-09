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

namespace Tennis_Track.Forme
{
    public partial class BrisanjeTurnira : Form
    {
        private AdminPanel adminPanel;
        private TennisTrackEntities tennisTrackEntities = new TennisTrackEntities();

        public BrisanjeTurnira(AdminPanel adminPanel)
        {
            this.adminPanel = adminPanel;
            InitializeComponent();
        }

        private void BrisanjeTurnira_Load(object sender, EventArgs e)
        {
            dgvTurniri.AllowUserToAddRows = false;
            dgvTurniri.RowHeadersVisible = false;
            dgvTurniri.DataSource = tennisTrackEntities.Turnir.ToList();


            for (int i = 0; i < dgvTurniri.Columns.Count; i++)
            {
                dgvTurniri.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvTurniri.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
                
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            adminPanel.Show();
            this.Close();
        }

        private void btnBrisiTurnir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Obrisati čete turnir. Želite li nastaviti?", "Upozorenje", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Turnir turnirZaObrisati = dgvTurniri.CurrentRow.DataBoundItem as Turnir;
                tennisTrackEntities.Turnir.Remove(turnirZaObrisati);
                tennisTrackEntities.SaveChanges();
                OsvjeziTurnir();
            }
        }

        private void OsvjeziTurnir()
        {
            List<Turnir> turniri = new List<Turnir>();
            turniri = tennisTrackEntities.Turnir.Local.ToList();
            if (txtTurnir.Text.ToString() != "")
            {
                turniri = (from turnir in turniri
                          where (turnir.Naziv.ToString().ToLower().Contains(txtTurnir.Text.ToString()))
                          || (turnir.Naziv.ToString().Contains(txtTurnir.Text.ToString()))
                          || (turnir.Naziv.ToString().ToUpper().Contains(txtTurnir.Text.ToString()))
                           select turnir).ToList();
            }
            dgvTurniri.DataSource = turniri;
        }

        private void txtTurnir_TextChanged(object sender, EventArgs e)
        {
            OsvjeziTurnir();
        }
    }
}
