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
    public partial class GlavniIzbornik : Form
    {
        private LoginForm loginForm;

        public GlavniIzbornik()
        {
            InitializeComponent();
        }

        public GlavniIzbornik(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
        }

        private void GlavniIzbornik_Load(object sender, EventArgs e)
        {
            lblImePrezimeKorisnika.Text = "Trenutno ste prijavljeni kao" + Environment.NewLine + PrijavaClana.PrijavljeniCLan.Ime + " " + PrijavaClana.PrijavljeniCLan.Prezime;
            lblImePrezimeKorisnika.BackColor = System.Drawing.Color.Transparent;
            if (PrijavaClana.PrijavljeniCLan.TipClana == "Admin")
            {
                btnAdminPanel.Visible = true;
            }
            else
            {
                btnAdminPanel.Visible = false;
            }
        }

        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(this);
            this.Hide();
            adminPanel.ShowDialog();
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            PrijavaClana.PrijavljeniCLan = null;
            this.Close();
        }

        private void btnPostavke_Click(object sender, EventArgs e)
        {
            Postavke postavke = new Postavke(this);
            this.Hide();
            postavke.ShowDialog();
        }

        private void btnRangListe_Click(object sender, EventArgs e)
        {
            RangListe rangListe = new RangListe(this);
            this.Hide();
            rangListe.ShowDialog();
        }

        private void bntMecevi_Click(object sender, EventArgs e)
        {
            PopisMeceva popisMeceva = new PopisMeceva(this);
            this.Hide();
            popisMeceva.ShowDialog();
        }

        private void lblImePrezimeKorisnika_Click(object sender, EventArgs e)
        {
            StatistikaKorisnika statistikaKorisnika = new StatistikaKorisnika(this);
            this.Hide();
            statistikaKorisnika.ShowDialog();
        }
    }
}
