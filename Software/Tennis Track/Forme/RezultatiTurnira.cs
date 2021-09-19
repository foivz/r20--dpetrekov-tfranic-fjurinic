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

    public partial class RezultatiTurnira : Form
    {
        TennisTrackEntities tennisTrackEntities = new TennisTrackEntities();

        private Turnir izabraniTurnir1;

        public RezultatiTurnira(Turnir turnir)
        {
            InitializeComponent();
            izabraniTurnir1 = turnir;
        }

        private void RezultatiTurnira_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            lblNazivTurnira.Text = izabraniTurnir1.Naziv;
            DohvatiRezultateTurnira();
        }

        private void DohvatiRezultateTurnira()
        {
                var mecevi = from m in tennisTrackEntities.Mec where izabraniTurnir1.Id == m.Turnir_Id select m;
                dgvRezultatiTurnira.DataSource = mecevi.ToList();

                for (int i = 0; i < dgvRezultatiTurnira.Columns.Count; i++)
                {
                    dgvRezultatiTurnira.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvRezultatiTurnira.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvRezultatiTurnira.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                dgvRezultatiTurnira.AllowUserToAddRows = false;
                dgvRezultatiTurnira.RowHeadersVisible = false;
                dgvRezultatiTurnira.Columns[0].HeaderText = "Prvi igrač";
                dgvRezultatiTurnira.Columns[1].HeaderText = "Drugi igrač";
                dgvRezultatiTurnira.Columns[3].HeaderText = "Setovi";
               
        }


        private void OsvjeziRezultate()
        {
            List<Mec> mecevi = new List<Mec>();
            mecevi = tennisTrackEntities.Mec.Local.ToList();
            if (txtClan.Text.ToString() != "")
            {
                mecevi = (from r in mecevi
                          where r.ImePrviClan.ToString().ToLower().Contains(txtClan.Text.ToString().ToLower()) ||
                          r.ImeDrugiClan.ToString().ToLower().Contains(txtClan.Text.ToString().ToLower())
                          select r).ToList();
            }
            dgvRezultatiTurnira.DataSource = mecevi;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtClan_TextChanged(object sender, EventArgs e)
        {
            OsvjeziRezultate();
        }

        private void RezultatiTurnira_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("Ovdje su prikazani svi rezultati odabranog turnira. " +
                    "Moguće je pretraživati rezultate prema imenu i prezimenu prvog ili drugog igrača." ,"Help");
            }
        }
    }
}
