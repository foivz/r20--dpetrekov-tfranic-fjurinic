using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennis_Track.Baza_podataka;
using Tennis_Track.Forme;

namespace Tennis_Track.Klase
{
    public static class PrijavaClana
    {
        public static Clan PrijavljeniCLan = null;
        public static bool ProvjeriPodatke(string KorisnickoIme, string Lozinka)
        {
            using (var db = new TennisTrackEntities())
            {
                PrijavljeniCLan = (from k in db.Clan where KorisnickoIme == k.KorisnickoIme select k).FirstOrDefault();
            }

            if (PrijavljeniCLan == null)
            {
                MessageBox.Show("Nepostojece korisnničko ime!", "Korisničko ime koje ste unesli ne postoji");
                return false;
            }
            else if (StructuralComparisons.StructuralEqualityComparer.Equals(PrijavljeniCLan.HashLozinke, 
                    EnkripcijaLozinke.GenerateSaltedHash(Lozinka, PrijavljeniCLan.SaltLozinke)))
            {
                return true;
            }
            else
            {
                PrijavljeniCLan = null;
                MessageBox.Show("Pogrešna lozinka!", "Lozinka koju ste unesli je neispravna");
                return false;
            }
        }

    }
}
