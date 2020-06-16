using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennis_Track.Baza_podataka;
using Tennis_Track.Klase;

namespace Tennis_Track.Forme
{
    public partial class Mecevi : Form
    {
        TennisTrackEntities tennisTrackEntities = new TennisTrackEntities();
        private GlavniIzbornik glavniIzbornik;
        public Clan odabraniSuigrac = new Clan();
        public Teren teren = new Teren();
        public Mecevi()
        {
            InitializeComponent();
        }

        public Mecevi(GlavniIzbornik glavniIzbornik)
        {
            this.glavniIzbornik = glavniIzbornik;
            InitializeComponent();
        }

        private void Mecevi_Load(object sender, EventArgs e)
        {
            
            teren.Id = 0;
            teren.Vrsta = "Zemlja";
            tennisTrackEntities.Teren.Add(teren);
            tennisTrackEntities.SaveChanges();
            tennisTrackEntities.Clan.Load();
            clanBindingSource.DataSource = tennisTrackEntities.Clan.Local;
            cmbTeren.DataSource = tennisTrackEntities.Teren.Local;
            txtIgrac.Text = PrijavaClana.PrijavljeniCLan.Ime + " " + PrijavaClana.PrijavljeniCLan.Prezime;
            var mecevi = from m in tennisTrackEntities.Mec select m;
            dgvMecevi.DataSource = mecevi.ToList();
            cmbTermini.DataSource = PopuniTermine();
           
        }

        private List<string> PopuniTermine()
        {
            List<string> terminiString = new List<string>();
            terminiString.Add("08:00:00");
            terminiString.Add("09:00:00");
            terminiString.Add("10:00:00");
            terminiString.Add("11:00:00");
            terminiString.Add("12:00:00");
            terminiString.Add("13:00:00");
            terminiString.Add("14:00:00");
            terminiString.Add("15:00:00");
            terminiString.Add("16:00:00");
            terminiString.Add("17:00:00");
            terminiString.Add("18:00:00");
            terminiString.Add("19:00:00");
            terminiString.Add("20:00:00");
            return terminiString;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            glavniIzbornik.Show();
            this.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var result = from c in tennisTrackEntities.Clan.Local where 
                         (c.Ime.ToLower() + " " + c.Prezime.ToLower()).Contains(txtFilter.Text.ToString().ToLower()) 
                         select c;
            clanBindingSource.DataSource = result.ToList();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            odabraniSuigrac = clanBindingSource.Current as Clan;
            txtSuigrac.Text = odabraniSuigrac.Ime + " " + odabraniSuigrac.Prezime;
        }

        private void btnKreirajMec_Click(object sender, EventArgs e)
        {
            Mec mec = new Mec();
            Set set1 = new Set();
            set1.Rezultat_prvi_clan = int.Parse(txtIgracSet1.Text);
            set1.Rezultat_drugi_clan = int.Parse(txtSuigracSet1.Text);
            Set set2 = new Set();
            set2.Rezultat_prvi_clan = int.Parse(txtIgracSet2.Text);
            set2.Rezultat_drugi_clan = int.Parse(txtSuigracSet2.Text);

            string time = cmbTermini.SelectedItem as string;
            TimeSpan realTime = TimeSpan.Parse(time);

            mec.Prvi_clan_Id = PrijavaClana.PrijavljeniCLan.ID;
            mec.Drugi_clan_Id = odabraniSuigrac.ID;
            mec.Datum = dtpDatumMeca.Value;
            mec.Teren = teren;
            mec.Vrijeme = realTime;
            mec.Sets.Add(set1);
            mec.Sets.Add(set2);
            if (ProvjeriRezultat(set1, set2))
            {
                Set set3 = new Set();
                set3.Rezultat_prvi_clan = int.Parse(txtIgracSet3.Text);
                set3.Rezultat_drugi_clan = int.Parse(txtSuigracSet3.Text);
                mec.Sets.Add(set3);
            }
            
            tennisTrackEntities.Mec.Add(mec);
            tennisTrackEntities.SaveChanges();
            MessageBox.Show("Meč je dodan!");
            dgvMecevi.DataSource = tennisTrackEntities.Mec.Local;

        }

        private bool ProvjeriRezultat(Set set1, Set set2)
        {
            int rezultat1=0, rezultat2=0;
            if (set1.Rezultat_prvi_clan > set1.Rezultat_drugi_clan + 1 || (set1.Rezultat_prvi_clan == 7 && set1.Rezultat_drugi_clan == 6))
                rezultat1++;
            else
                rezultat2++;

            if (set2.Rezultat_prvi_clan > set2.Rezultat_drugi_clan + 1 || (set2.Rezultat_prvi_clan == 7 && set1.Rezultat_drugi_clan == 6))
                rezultat1++;
            else
                rezultat2++;

            if (rezultat1 ==1 && rezultat2==1)
                return true;
            else return false;
        }
    }
}
