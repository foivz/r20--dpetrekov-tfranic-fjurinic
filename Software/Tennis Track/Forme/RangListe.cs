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
    public partial class RangListe : Form
    {
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

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            glavniIzbornik.Show();
            this.Close();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            string ime = txtPrezimeIliImeKorisnika.Text;
            using (var db = new TennisTrackEntities())
            {
                var query = from c in db.Clan where c.Prezime.Contains(ime) || c.Ime.Contains(ime) select new 
                { c.Ime, c.Prezime, c.KorisnickoIme, c.Email, c.Telefon, c.TipClana };
                dgvRangLista.DataSource = query.ToList();
            }
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            using (var db = new TennisTrackEntities())
            {
                var query = from c in db.Clan
                            select new
                            { c.Ime, c.Prezime, c.KorisnickoIme, c.Email, c.Telefon, c.TipClana };
                dgvRangLista.DataSource = query.ToList();
            }
        }
    }
}
