using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tennis_Track.Forme;
using Tennis_Track.Baza_podataka;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.Entity;

namespace Tennis_Track.Klase
{
    public static class Učlanjenje
    {
        public static void DodajClana(string ime, string prezime, string email, string telefon)
        {
            TennisTrackEntities tennisTrackEntities = new TennisTrackEntities();
            tennisTrackEntities.Clan.Load();
            var result = from c in tennisTrackEntities.Clan.Local
                         where c.KorisnickoIme == (ime[0] + prezime.ToLower())
                         select c;
            if (result.Count()!=0)
            {
                MessageBox.Show("Korisnik je vec registriran.", "Obavijest!");
            }
            else
            {
                Clan clan = new Clan();
                string lozinka = GenerirajLozinku();
                clan.Ime = ime;
                clan.Prezime = prezime;
                clan.Email = email;
                clan.KorisnickoIme = ime[0] + prezime.ToLower();
                clan.SaltLozinke = EnkripcijaLozinke.GenerateSalt();
                clan.HashLozinke = EnkripcijaLozinke.GenerateSaltedHash(lozinka, clan.SaltLozinke);
                clan.Telefon = telefon;
                clan.TipClana = "Clan";
                tennisTrackEntities.Clan.Add(clan);
                tennisTrackEntities.SaveChanges();
                MessageBox.Show("Korisnički podatci poslani su na mail korisnika.", "Obavijest!");
                PosaljiKorisnickePodatke(clan, lozinka);
            }
        }
        public static void ResetirajLozinku(string KorisnickoIme, string email)
        {
            string pass = GenerirajLozinku();
            using (var db = new TennisTrackEntities())
            {
                Clan clan = (from c in db.Clan where c.KorisnickoIme == KorisnickoIme && c.Email == email select c).FirstOrDefault();
                if (clan != null)
                {
                    clan.SaltLozinke = EnkripcijaLozinke.GenerateSalt();
                    clan.HashLozinke = EnkripcijaLozinke.GenerateSaltedHash(pass, clan.SaltLozinke);
                    db.SaveChanges();
                    PosaljiKorisnickePodatke(clan, pass);
                    MessageBox.Show("Lozinka resetirana. Nova lozinka poslana Vam je na Email.", "Obavijest!");
                }
                else
                {
                    MessageBox.Show("Nepostojeći korisnik.", "Obavijest!");
                }
            }
        }

        private static void PosaljiKorisnickePodatke(Clan clan, string lozinka)
        {
            try
            {
                SmtpClient mailServer = new SmtpClient("smtp.gmail.com", 587);
                mailServer.EnableSsl = true;

                mailServer.Credentials = new System.Net.NetworkCredential("tennistrack2020@gmail.com", "PIProjekt2020");

                string from = "tennistrack@gmail.com";
                string to = clan.Email;
                MailMessage msg = new MailMessage(from, to);
                msg.Subject = "Korisnički podatci";
                msg.IsBodyHtml = true;
                msg.Body = @"<p> Poštovani korisniče,<p>
                                    <p>Zahvaljujemo se na korištenju aplikacije Tennis Track. Ispod čete nači Vaše korisičke podatke sa kojima se možete prijaviti u našu aplikaciju.</p>
                                    <p>Ime: " + clan.Ime + " </p>" +
                                    "<p>Prezime: " + clan.Prezime + "</p>" +
                                    "<p>Korisničko ime: " + clan.KorisnickoIme + "</p>" +
                                    "<p>Lozinka: " + lozinka + "</p>" +
                                    "<p>S poštovanjem Tennis Track</p>";
                mailServer.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neuspjesno slanje korisničkih podataka.", ex.ToString());
            }
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
