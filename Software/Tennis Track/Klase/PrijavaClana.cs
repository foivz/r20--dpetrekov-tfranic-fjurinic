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
        public static Clan clan = null;
        public static bool ProvjeriPodatke(string KorisickoIme, string Lozinka)
        {
            DohvatiKorisnika(KorisickoIme);

            if (clan == null)
            {
                MessageBox.Show("Nepostojece korisnničko ime!", "Korisničko ime koje ste unesli ne postoji");
                return false;
            }
            else if (StructuralComparisons.StructuralEqualityComparer.Equals(clan.HashLozinke, EnkripcijaLozinke.GenerateSaltedHash(Lozinka, clan.SaltLozinke)))
            {
                return true;
            }
            else
            {
                clan = null;
                MessageBox.Show("Pogrešna lozinka!", "Lozinka koju ste unesli je neispravna");
                return false;
            }
        }



        private static void DohvatiKorisnika(string KorisnickoIme)
        {
            using (var db = new TennisTrackEntities())
            {
                clan = (from k in db.Clan where KorisnickoIme == k.KorisnickoIme select k).FirstOrDefault();
            }
        }
    }
}
