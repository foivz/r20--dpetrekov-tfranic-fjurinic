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
    public partial class Postavke : Form
    {
        private GlavniIzbornik glavniIzbornik;

        public Postavke()
        {
            InitializeComponent();
        }

        public Postavke(GlavniIzbornik glavniIzbornik)
        {
            this.glavniIzbornik = glavniIzbornik;
            InitializeComponent();
        }

        private void Postavke_Load(object sender, EventArgs e)
        {
            txtEmail.Text = PrijavaClana.PrijavljeniCLan.Email;
            txtTelefon.Text = PrijavaClana.PrijavljeniCLan.Telefon;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            glavniIzbornik.Show();
            this.Hide();
        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {
            if (!(txtEmail.Text.ToString() == PrijavaClana.PrijavljeniCLan.Email && txtTelefon.Text.ToString()==PrijavaClana.PrijavljeniCLan.Telefon))
            {
                MessageBox.Show("Novi podatci su spremljeni", "Obavijest!");
                using (var db = new TennisTrackEntities())
                {
                    Clan clan = (from c in db.Clan where c.Ime == PrijavaClana.PrijavljeniCLan.Ime select c).FirstOrDefault();
                    clan.Telefon = txtTelefon.Text.ToString();
                    clan.Email = txtEmail.Text.ToString();
                    PrijavaClana.PrijavljeniCLan = clan;
                    db.SaveChanges();
                }
            }
        }

        private void btnPromjeniLozinku_Click(object sender, EventArgs e)
        {
            PromjeniLozinku promjeniLozinku = new PromjeniLozinku(this);
            this.Hide();
            promjeniLozinku.ShowDialog();
        }
    }
}
