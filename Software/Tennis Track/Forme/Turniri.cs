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
            rbtnSviTurniri.Checked = true;
            rbtnPrijasnji.Checked = false;
            rbtnNadolazeci.Checked = false;
            DohvatiTurnire();

            for (int i = 0; i < turniriDataGridView.Columns.Count; i++)
            {
                turniriDataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                turniriDataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            Ukljuci_Iskljuci_Tipke();

            if (PrijavaClana.PrijavljeniCLan.TipClana == "Admin")
            {
                btnDodajTurnir.Visible = true;
            }
            else
            {
                btnDodajTurnir.Visible = false;
            }
        }


        

        private void DohvatiTurnire()
        {
            
            if(rbtnPrijasnji.Checked == true)
            {
                var prijasnjiTurniri = from m in tennisTrackEntities.Turnir where m.Datum <= DateTime.Today select m;
                turniriDataGridView.DataSource = prijasnjiTurniri.ToList();
                Ukljuci_Iskljuci_Tipke();
            }
            if (rbtnNadolazeci.Checked == true)
            {
                var nadolazeciTurniri = from m in tennisTrackEntities.Turnir where m.Datum > DateTime.Today select m;
                turniriDataGridView.DataSource = nadolazeciTurniri.ToList();
                Ukljuci_Iskljuci_Tipke();
            }
            if (rbtnSviTurniri.Checked == true)
            {
                var turniri = from t in tennisTrackEntities.Turnir select t;
                turniriDataGridView.DataSource = turniri.ToList();
                Ukljuci_Iskljuci_Tipke();
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

            DohvatiTurnire();
            Ukljuci_Iskljuci_Tipke();
            OsvjeziTurnire();
        }

        private void rbtnSviTurniri_CheckedChanged(object sender, EventArgs e)
        {
            
            DohvatiTurnire();
            Ukljuci_Iskljuci_Tipke();
            OsvjeziTurnire();

        }

        private void rbtnPrijasnji_CheckedChanged(object sender, EventArgs e)
        {
            
            DohvatiTurnire();
            Ukljuci_Iskljuci_Tipke();
            OsvjeziTurnire();

        }

        private void rbtnNadolazeci_CheckedChanged(object sender, EventArgs e)
        {
            
            DohvatiTurnire();
            Ukljuci_Iskljuci_Tipke();
            OsvjeziTurnire();

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
            if (txtTurniri.Text.ToString() == "")
            {
                DohvatiTurnire();
            }
            else
            {
                if(rbtnSviTurniri.Checked == true)
                {
                    turniri = (from turnir in turniri
                               where (turnir.Naziv.ToString().ToLower().Contains(txtTurniri.Text.ToString().ToLower()))
                               select turnir).ToList();

                    turniriDataGridView.DataSource = turniri;
                }
                if(rbtnPrijasnji.Checked == true)
                {
                    turniri = (from turnir in turniri
                               where turnir.Naziv.ToString().ToLower().Contains(txtTurniri.Text.ToString().ToLower()) && turnir.Datum <= DateTime.Today
                               select turnir).ToList();

                    turniriDataGridView.DataSource = turniri;
                }
                if(rbtnNadolazeci.Checked == true)
                {
                    turniri = (from turnir in turniri
                               where turnir.Naziv.ToString().ToLower().Contains(txtTurniri.Text.ToString().ToLower()) && turnir.Datum > DateTime.Today
                               select turnir).ToList();

                    turniriDataGridView.DataSource = turniri;
                }
            }
            Ukljuci_Iskljuci_Tipke();
        }

        private void txtTurniri_TextChanged(object sender, EventArgs e)
        {
            OsvjeziTurnire();
            
        }

        private void Turniri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("Ovdje su prikazani svi turniri. Moguće je pretraživati turnire" +
                    " prema nazivu. S desne strane imamo filter gdje možemo izabrati sve turnire, prijašnje ili nadolazeće." +
                    "Kada odaberete turnir i ako je turnir već odigran, tada možete vidjeti rezultate turnira klikom " +
                    "na tipku 'Prikaži rezultate turnira'." +
                    "Odabirom nadolazećeg turnira, možete kliknuti na tipku 'Prikaži turnir / Prijava' te se tada otvara " +
                    "prozor sa prikazom sudionika turnira i moguće se prijaviti ili odjaviti s turnira.","Help");
            }
        }
    }
}
