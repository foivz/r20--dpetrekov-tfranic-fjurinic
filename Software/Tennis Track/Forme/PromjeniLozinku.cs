using System;
using System.Collections;
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
    public partial class PromjeniLozinku : Form
    {
        private Postavke postavke;

        public PromjeniLozinku()
        {
            InitializeComponent();
        }

        public PromjeniLozinku(Postavke postavke)
        {
            this.postavke = postavke;
            InitializeComponent();
        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {
            if (txtNovaLozinka.Text.ToString() == txtPonovljenaLozinka.Text.ToString())
            {
                if (StructuralComparisons.StructuralEqualityComparer.Equals(PrijavaClana.clan.HashLozinke, EnkripcijaLozinke.GenerateSaltedHash(txtStaraLozinka.Text.ToString(), PrijavaClana.clan.SaltLozinke)))
                {
                    using (var db = new TennisTrackEntities())
                    {
                        Clan clan = (from c in db.Clan where c.Ime == PrijavaClana.clan.Ime select c).FirstOrDefault();
                        clan.HashLozinke = EnkripcijaLozinke.GenerateSaltedHash(txtNovaLozinka.Text.ToString(), clan.SaltLozinke);
                        PrijavaClana.clan = clan;
                        db.SaveChanges();
                    }
                    MessageBox.Show("Lozinka uspješno promijenjena.", "Obavijest!");
                    postavke.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unesli ste krivu lozinku.", "Obavijest!");
                }
            }
            else
            {
                MessageBox.Show("Polja lozinka i ponovljena lozinka se ne podudaraju.", "Obavijest!");
            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            postavke.Show();
            this.Close();
        }
    }
}
