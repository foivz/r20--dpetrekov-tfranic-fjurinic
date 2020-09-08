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
    public partial class JedanTurnir : Form
    {

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
            sudioniciDataGridView.DataSource = DohvatiSudionike();
            sudioniciDataGridView.Columns["ID"].Visible = false;
            sudioniciDataGridView.Columns["KorisnickoIme"].Visible = false;
            sudioniciDataGridView.Columns["Email"].Visible = false;
            sudioniciDataGridView.Columns["HashLozinke"].Visible = false;
            sudioniciDataGridView.Columns["SaltLozinke"].Visible = false;
            sudioniciDataGridView.Columns["TipClana"].Visible = false;
            sudioniciDataGridView.Columns["Mecs"].Visible = false;
            sudioniciDataGridView.Columns["Mecs1"].Visible = false;
            sudioniciDataGridView.Columns["Rezervacijes"].Visible = false;
            sudioniciDataGridView.Columns["Turnirs"].Visible = false;
            sudioniciDataGridView.Columns["UkupnoPobjeda"].Visible = false;
            sudioniciDataGridView.Columns["SluzbenePobjede"].Visible = false;
            sudioniciDataGridView.Columns["BrojBodova"].Visible = false;
        }

        private List<Clan> DohvatiSudionike()
        {
            using (var context = new TennisTrackEntities())
            {
                context.Turnir.Attach(izabraniTurnir);
                return izabraniTurnir.Clans.ToList();
            }
        }

        private void PopuniInformacije()
        {
            txtTurnirNaziv.Text = izabraniTurnir.Naziv.ToString();
            txtTurnirDatum.Text = izabraniTurnir.Datum.ToString();
            txtTurnirVrijeme.Text = izabraniTurnir.Vrijeme.ToString();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
