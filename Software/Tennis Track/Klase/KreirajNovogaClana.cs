using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tennis_Track.Forme;
using Tennis_Track.Baza_podataka;
using System.Windows.Forms;

namespace Tennis_Track.Klase
{
    public static class KreirajNovogaClana
    {
        public static DodajClana DodajClana;

        public static void KreirajClana()
        {
            Clan clan = new Clan();
            string lozinka = GenerirajLozinku();
            clan.Ime = DodajClana.txtIme.Text.ToString();
            clan.Prezime = DodajClana.txtPrezime.Text.ToString();
            clan.Email = DodajClana.txtEmail.Text.ToString();
            clan.KorisnickoIme = (DodajClana.txtIme.Text[0].ToString() + DodajClana.txtPrezime.Text.ToString()).ToLower();
            clan.SaltLozinke = EnkripcijaLozinke.GenerateSalt();
            clan.HashLozinke = EnkripcijaLozinke.GenerateSaltedHash(lozinka, clan.SaltLozinke);
            clan.Telefon = DodajClana.txtTelefon.Text.ToString();
            clan.TipClana = "Clan";
            TennisTrackEntities tennisTrackEntities = new TennisTrackEntities();
            tennisTrackEntities.Clan.Add(clan);
            tennisTrackEntities.SaveChanges();
            MessageBox.Show("Korisnicko ime je: " + clan.KorisnickoIme + Environment.NewLine + "Lozinka je: " + lozinka, "Korisnički podatci");
        }

        private static string GenerirajLozinku()
        {
            Random random = new Random();
            string lozinka = "";
            for (int i = 0; i < 8; i++)
            {
                lozinka = lozinka + (char)random.Next(97, 122);
            }
            return lozinka;
        }
    }
}
