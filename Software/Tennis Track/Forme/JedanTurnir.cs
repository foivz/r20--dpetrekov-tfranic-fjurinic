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
    public partial class JedanTurnir : Form
    {
        TennisTrackEntities tennisTrackEntities = new TennisTrackEntities();
        
        private Turnir izabraniTurnir;

        public JedanTurnir(Turnir turnir)
        {
            InitializeComponent();
            izabraniTurnir = turnir;
        }


        private void JedanTurnir_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            PopuniInformacije();
            PopuniSudionike();
        }

        private void PopuniSudionike()
        {
            var upit = from clan in tennisTrackEntities.Clan
                       where clan.Turnirs.Any(t => t.Naziv == izabraniTurnir.Naziv)
                       select clan;

            sudioniciDataGridView.DataSource = upit.ToList();

        }

        private void PopuniInformacije()
        {
            txtTurnirNaziv.Text = izabraniTurnir.Naziv.ToString();
            txtTurnirDatum.Text = izabraniTurnir.Datum.ToShortDateString();
            txtTurnirVrijeme.Text = izabraniTurnir.Vrijeme.ToString();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {

        }
    }
}
