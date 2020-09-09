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
    public partial class Turniri : Form
    {
        TennisTrackEntities tennisTrackEntities = new TennisTrackEntities();
        private GlavniIzbornik glavniIzbornik;
        public Turniri()
        {
            InitializeComponent();
        }

        public Turniri(GlavniIzbornik glavniIzbornik)
        {
            this.glavniIzbornik = glavniIzbornik;
            InitializeComponent();
        }

        private void Turniri_Load(object sender, EventArgs e)
        {
            turniriDataGridView.DataSource = DohvatiTurnire();

            for (int i = 0; i < turniriDataGridView.Columns.Count; i++)
            {
                turniriDataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                turniriDataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            Ukljuci_Iskljuci_Tipke();
        }

        

        private object DohvatiTurnire()
        {
            using (var context = new TennisTrackEntities())
            {
                return context.Turnir.ToList();
            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            glavniIzbornik.Show();
            this.Close();
        }

        private void btnPrikaziTurnir_Click(object sender, EventArgs e)
        {
            Turnir izabraniTurnir = DohvatiIzabraniTurnir();
            JedanTurnir form = new JedanTurnir(izabraniTurnir);
            form.ShowDialog();
            
        }

        private Turnir DohvatiIzabraniTurnir()
        {
            return turniriDataGridView.CurrentRow.DataBoundItem as Turnir;
        }

        private void btnDodajTurnir_Click(object sender, EventArgs e)
        {
            DodavanjeTurnira dodavanjeTurnira = new DodavanjeTurnira(this);
            dodavanjeTurnira.ShowDialog();

            turniriDataGridView.DataSource = DohvatiTurnire();
            Ukljuci_Iskljuci_Tipke();
        }

        private void rbtnSviTurniri_CheckedChanged(object sender, EventArgs e)
        {
            turniriDataGridView.DataSource = DohvatiTurnire();
            Ukljuci_Iskljuci_Tipke();

        }

        private void rbtnPrijasnji_CheckedChanged(object sender, EventArgs e)
        {
            var prijasnjiTurniri = from m in tennisTrackEntities.Turnir where m.Datum <= DateTime.Today select m;
            turniriDataGridView.DataSource = prijasnjiTurniri.ToList();
            Ukljuci_Iskljuci_Tipke();
        }

        private void rbtnNadolazeci_CheckedChanged(object sender, EventArgs e)
        {
            var nadolazeciTurniri = from m in tennisTrackEntities.Turnir where m.Datum > DateTime.Today select m;
            turniriDataGridView.DataSource = nadolazeciTurniri.ToList();
            Ukljuci_Iskljuci_Tipke();

        }

        private void btnPrikaziRezultateTurnira_Click(object sender, EventArgs e)
        {
            Turnir izabraniTurnir2 = DohvatiIzabraniTurnir();
            RezultatiTurnira form = new RezultatiTurnira(izabraniTurnir2);
            form.ShowDialog();
        }

        private void Ukljuci_Iskljuci_Tipke()
        {
            if (turniriDataGridView.Rows.Count != 0)
            {
                var vrijednost = turniriDataGridView.CurrentRow.Cells[1].Value.ToString();
                var datum = DateTime.Parse(vrijednost);
                var danas = DateTime.Today;
                if (datum <= danas)
                {
                    btnPrikaziRezultateTurnira.Enabled = true;
                    btnPrikaziTurnir.Enabled = false;
                }
                else if (datum > danas)
                {
                    btnPrikaziTurnir.Enabled = true;
                    btnPrikaziRezultateTurnira.Enabled = false;
                }

            }
            else
            {
                btnPrikaziTurnir.Enabled = false;
                btnPrikaziRezultateTurnira.Enabled = false;
            }
        }

        private void turniriDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ukljuci_Iskljuci_Tipke();
        }

        private void OsvjeziTurnire()
        {
            List<Turnir> turniri = new List<Turnir>();
            turniri = tennisTrackEntities.Turnir.ToList();
            if (txtTurniri.Text.ToString() != "")
            {
                turniri = (from turnir in turniri
                           where (turnir.Naziv.ToString().ToLower().Contains(txtTurniri.Text.ToString().ToLower()))
                           select turnir).ToList();
            }
            turniriDataGridView.DataSource = turniri;
            Ukljuci_Iskljuci_Tipke();
        }

        private void txtTurniri_TextChanged(object sender, EventArgs e)
        {
            OsvjeziTurnire();
        }

       
    }
}
