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
            turniriDataGridView.Columns["Mecs"].Visible = false;
            turniriDataGridView.Columns["Clans"].Visible = false;
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
        }

        private void rbtnSviTurniri_CheckedChanged(object sender, EventArgs e)
        {
            turniriDataGridView.DataSource = DohvatiTurnire();
        }

        private void rbtnPrijasnji_CheckedChanged(object sender, EventArgs e)
        {
            var prijasnjiTurniri = from m in tennisTrackEntities.Turnir where m.Datum <= DateTime.Today select m;
            turniriDataGridView.DataSource = prijasnjiTurniri.ToList();
        }

        private void rbtnNadolazeci_CheckedChanged(object sender, EventArgs e)
        {
            var nadolazeciTurniri = from m in tennisTrackEntities.Turnir where m.Datum > DateTime.Today select m;
            turniriDataGridView.DataSource = nadolazeciTurniri.ToList();
        }
    }
}
