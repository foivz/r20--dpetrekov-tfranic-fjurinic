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
    public partial class DodavanjeTurnira : Form
    {
        private Turniri turniri;
        public DodavanjeTurnira(Turniri turniri)
        {
            this.turniri = turniri;
            InitializeComponent();
        }

        private List<string> PopuniVrijeme()
        {
            List<string> vrijemeString = new List<string>();
            vrijemeString.Add("08:00:00");
            vrijemeString.Add("09:00:00");
            vrijemeString.Add("10:00:00");
            vrijemeString.Add("11:00:00");
            vrijemeString.Add("12:00:00");
            vrijemeString.Add("13:00:00");
            return vrijemeString;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (var context = new TennisTrackEntities())
            {
                string naziv = txtTurnirNaziv.Text;
                DateTime datum = dtpDatumTurnira.Value.Date;
                string vrijeme = cmbVrijeme.SelectedItem as string;
                TimeSpan pravoVrijeme = TimeSpan.Parse(vrijeme);


                Turnir noviTurnir = new Turnir
                {
                    
                    Naziv = naziv,
                    Datum = datum,
                    Vrijeme = pravoVrijeme
                };

                if(txtTurnirNaziv.Text.Length != 0)
                {
                    context.Turnir.Add(noviTurnir);
                    context.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("Morate upisati naziv turnira!");
                }
                
            }
        }

        private void DodavanjeTurnira_Load(object sender, EventArgs e)
        {
            dtpDatumTurnira.Value = DateTime.Today.AddDays(1);
            cmbVrijeme.DataSource = PopuniVrijeme();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpDatumTurnira_ValueChanged(object sender, EventArgs e)
        {
            DateTime danas = DateTime.Today.Date;
            DateTime sutra = danas.AddDays(1);

            if(dtpDatumTurnira.Value < danas)
            {
                MessageBox.Show("Ne možete dodati turnir u prošlosti!");
                dtpDatumTurnira.Value = sutra;
            }

            else if(dtpDatumTurnira.Value == danas)
            {
                MessageBox.Show("Ne možete dodati turnir na današnji dan!");
                dtpDatumTurnira.Value = sutra;
            }
            
        }
    }
}
