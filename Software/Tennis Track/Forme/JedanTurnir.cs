using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennis_Track.Baza_podataka;
using Tennis_Track.Klase;

namespace Tennis_Track.Forme
{
    public partial class JedanTurnir : Form
    {       
        private Turnir izabraniTurnir;
        private Clan prijavljeniClan;

        public JedanTurnir(Turnir turnir)
        {
            InitializeComponent();
            izabraniTurnir = turnir;
            prijavljeniClan = PrijavaClana.PrijavljeniCLan;
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
            using (var context = new TennisTrackEntities())
            {
                var upit = from clan in context.Clan
                           where clan.Turnirs.Any(t => t.Naziv == izabraniTurnir.Naziv)
                           select clan;

                sudioniciDataGridView.DataSource = upit.ToList();
            }
            ProvjeriSudionika();

        }

        private void ProvjeriSudionika()
        {
            if(sudioniciDataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in sudioniciDataGridView.Rows)
                {
                    if((row.Cells[0].Value.ToString() == prijavljeniClan.Ime)  && (row.Cells[1].Value.ToString() == prijavljeniClan.Prezime))
                    {
                        btnPrijava.Enabled = false;
                        btnOdjava.Enabled = true;
                        break;
                    }
                    else
                    {
                        btnOdjava.Enabled = false;
                        btnPrijava.Enabled = true;
                    }
                }
            }
            else
            {
                btnOdjava.Enabled = false;
                btnPrijava.Enabled = true;
            }
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
            using(var context = new TennisTrackEntities())
            {
                var turnir = context.Turnir.Find(izabraniTurnir.Id);
                var clan = context.Clan.Find(prijavljeniClan.ID);
                context.Entry(turnir).Collection("Clans").Load();

                turnir.Clans.Add(clan);
                clan.Turnirs.Add(turnir);

                context.SaveChanges();
            }
            PopuniSudionike();
            MessageBox.Show("Uspješno ste se prijavili na turnir!");
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Odjavit ćete se sa turnira. Želite li nastaviti?", "Upozorenje", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (var context = new TennisTrackEntities())
                {
                    var turnir = context.Turnir.Find(izabraniTurnir.Id);
                    var clan = context.Clan.Find(prijavljeniClan.ID);
                    context.Entry(turnir).Collection("Clans").Load();

                    turnir.Clans.Remove(clan);
                    clan.Turnirs.Remove(turnir);

                    context.SaveChanges();
                }
                PopuniSudionike();
            }
            
        }

        private void JedanTurnir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("Ovdje su prikazani podaci o odabranom turniru te prijavljeni sudionici." +
                    "Klikom na tipku 'Prijava' možete se prijaviti na turnir. Tipka 'Odjava' se ne može " +
                    "kliknuti ako član nije prijavljen, a ako je prijavljen, klikom na tu tipku se može " +
                    "odjaviti s turnira.", "Help");
            }
        }
    }
}
