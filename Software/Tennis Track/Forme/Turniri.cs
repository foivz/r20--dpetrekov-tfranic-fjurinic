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
    }
}
