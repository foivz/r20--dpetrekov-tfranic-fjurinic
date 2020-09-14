using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennis_Track.Baza_podataka;
using Tennis_Track.Klase;

namespace Tennis_Track.Forme
{
    public partial class Rezervacije : Form
    {
        private GlavniIzbornik glavniIzbornik;
        TennisTrackEntities tennisTrackEntities = new TennisTrackEntities();

        SqlConnection con = new SqlConnection(@"Data Source = 31.147.204.119\PISERVER,1433; Initial Catalog = PI20_035_DB; User = PI20_035_User; Password = 3eRH6r4!;");
        public Rezervacije()
        {
            InitializeComponent();
        }

        public Rezervacije(GlavniIzbornik glavniIzbornik)
        {
            this.glavniIzbornik = glavniIzbornik;
            InitializeComponent();
        }

        private void Rezervacije_Load(object sender, EventArgs e)
        {
            lblDatum.Text = DateTime.Today.Date.ToShortDateString();
            DateTime datum = DateTime.Today.Date;
            PopuniRezervacije(datum);
        }

        private void PopuniRezervacije(DateTime datum)
        {
            PopuniSve("08:00", lblTvrda8, datum, 1);
            PopuniSve("09:00", lblTvrda9, datum, 1);
            PopuniSve("10:00", lblTvrda10, datum, 1);
            PopuniSve("11:00", lblTvrda11, datum, 1);
            PopuniSve("12:00", lblTvrda12, datum, 1);
            PopuniSve("13:00", lblTvrda13, datum, 1);
            PopuniSve("14:00", lblTvrda14, datum, 1);
            PopuniSve("15:00", lblTvrda15, datum, 1);
            PopuniSve("16:00", lblTvrda16, datum, 1);
            PopuniSve("17:00", lblTvrda17, datum, 1);
            PopuniSve("18:00", lblTvrda18, datum, 1);
            PopuniSve("19:00", lblTvrda19, datum, 1);
            PopuniSve("20:00", lblTvrda20, datum, 1);

            PopuniSve("08:00", lblTrava8, datum, 22);
            PopuniSve("09:00", lblTrava9, datum, 22);
            PopuniSve("10:00", lblTrava10, datum, 22);
            PopuniSve("11:00", lblTrava11, datum, 22);
            PopuniSve("12:00", lblTrava12, datum, 22);
            PopuniSve("13:00", lblTrava13, datum, 22);
            PopuniSve("14:00", lblTrava14, datum, 22);
            PopuniSve("15:00", lblTrava15, datum, 22);
            PopuniSve("16:00", lblTrava16, datum, 22);
            PopuniSve("17:00", lblTrava17, datum, 22);
            PopuniSve("18:00", lblTrava18, datum, 22);
            PopuniSve("19:00", lblTrava19, datum, 22);
            PopuniSve("20:00", lblTrava20, datum, 22);

            PopuniSve("08:00", lblZemlja8, datum, 23);
            PopuniSve("09:00", lblZemlja9, datum, 23);
            PopuniSve("10:00", lblZemlja10, datum, 23);
            PopuniSve("11:00", lblZemlja11, datum, 23);
            PopuniSve("12:00", lblZemlja12, datum, 23);
            PopuniSve("13:00", lblZemlja13, datum, 23);
            PopuniSve("14:00", lblZemlja14, datum, 23);
            PopuniSve("15:00", lblZemlja15, datum, 23);
            PopuniSve("16:00", lblZemlja16, datum, 23);
            PopuniSve("17:00", lblZemlja17, datum, 23);
            PopuniSve("18:00", lblZemlja18, datum, 23);
            PopuniSve("19:00", lblZemlja19, datum, 23);
            PopuniSve("20:00", lblZemlja20, datum, 23);
        }


        private void PopuniSve(string vrijeme, Label label, DateTime datum, int teren)
        {
            var termin = TimeSpan.Parse(vrijeme);
            var clan = from c in tennisTrackEntities.Rezervacije where c.Teren_Id == teren && c.Vrijeme == termin && c.Datum == datum select c.Clan_Id;
            var iip = from i in tennisTrackEntities.Clan where (clan.FirstOrDefault() == i.ID) select new { i.Ime, i.Prezime };
            if (clan.FirstOrDefault() != 0)
            {
                label.BackColor = Color.LightPink;
                label.Text = iip.FirstOrDefault().Ime + " " + iip.FirstOrDefault().Prezime;
            }
            else
            {
                label.BackColor = Color.LightGreen;
                label.Text = "Slobodno";
            }
        }

        private void UpisiObrisiRezervaciju(string vrijeme, int teren, Label label)
        {
            var date = DateTime.Parse(lblDatum.Text);
            var datum = date.ToString("yyyy-MM-dd");

            if (label.Text == "Slobodno")
            {
                if (ProvjeriRezervacije() == true && ProvjeriVrijeme(vrijeme) == false)
                {
                    if (MessageBox.Show("Želite rezervirati odabrani termin?", "Rezervacija", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Rezervacije (Datum, Vrijeme, Clan_Id, Teren_Id) VALUES ('" + datum + "','" + vrijeme + "'," + PrijavaClana.PrijavljeniCLan.ID + ", " + teren + ")", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (datum == DateTime.Today.ToString("yyyy-MM-dd"))
                    {
                        PopuniRezervacije(DateTime.Today.Date);
                    }
                    else if (datum == DateTime.Today.AddDays(1).ToString("yyyy-MM-dd"))
                    {
                        PopuniRezervacije(DateTime.Today.AddDays(1));
                    }
                    else
                    {
                        PopuniRezervacije(DateTime.Today.AddDays(2));
                    }

                }
            }
            else if (label.Text == PrijavaClana.PrijavljeniCLan.ImeIPrezime)
            {
                if (MessageBox.Show("Želite obrisati odabrani termin?", "Brisanje rezervacije", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Rezervacije where Datum = '" + datum + "' AND Vrijeme = '" + vrijeme + "' AND Clan_Id =" + PrijavaClana.PrijavljeniCLan.ID + " AND Teren_Id = " + teren + "", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (datum == DateTime.Today.ToString("yyyy-MM-dd"))
                {
                    PopuniRezervacije(DateTime.Today.Date);
                }
                else if (datum == DateTime.Today.AddDays(1).ToString("yyyy-MM-dd"))
                {
                    PopuniRezervacije(DateTime.Today.AddDays(1));
                }
                else
                {
                    PopuniRezervacije(DateTime.Today.AddDays(2));
                }
            }
            else
            {
                MessageBox.Show("Termin je zauzet. Odaberite neki drugi termin!");
            }
        }

        private bool ProvjeriRezervacije()
        {
            var date = DateTime.Parse(lblDatum.Text);
            var datum = date.ToString("yyyy-MM-dd");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Rezervacije WHERE Clan_Id =" + PrijavaClana.PrijavljeniCLan.ID + " AND Datum = '" + datum + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            int brojRedova = dt.Rows.Count;
            if (brojRedova == 2)
            {
                MessageBox.Show("Već ste rezervirali maksimalan broj sati (max. 2 sata)!");
                con.Close();
                return false;
            }
            else
            {
                con.Close();
                return true;
            }
        }

        private bool ProvjeriVrijeme(string vrijeme)
        {
            var date = DateTime.Parse(lblDatum.Text);
            var datum = date.ToString("yyyy-MM-dd");
            var time = DateTime.Now;
            DateTime vrijeme1 = DateTime.Parse(vrijeme);

            if (datum == DateTime.Today.ToString("yyyy-MM-dd") && vrijeme1 <= time)
            {
                MessageBox.Show("Ne možete rezervirati termin u prošlosti!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnDanas_Click(object sender, EventArgs e)
        {
            lblDatum.Text = DateTime.Today.Date.ToShortDateString();
            DateTime datum = DateTime.Today.Date;
            PopuniRezervacije(datum);
        }

        private void btnSutra_Click(object sender, EventArgs e)
        {
            lblDatum.Text = DateTime.Today.AddDays(1).ToShortDateString();
            PopuniRezervacije(DateTime.Today.AddDays(1));
        }

        private void btnPreksutra_Click(object sender, EventArgs e)
        {
            lblDatum.Text = DateTime.Today.AddDays(2).ToShortDateString();
            PopuniRezervacije(DateTime.Today.AddDays(2));
        }


        private void btnPovratak_Click(object sender, EventArgs e)
        {
            glavniIzbornik.Show();
            this.Close();
        }


        //Tvrda
        private void lblTvrda8_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("08:00", 1, lblTvrda8);
        }

        private void lblTvrda9_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("09:00", 1, lblTvrda9);
        }

        private void lblTvrda10_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("10:00", 1, lblTvrda10);
        }

        private void lblTvrda11_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("11:00", 1, lblTvrda11);
        }

        private void lblTvrda12_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("12:00", 1, lblTvrda12);
        }

        private void lblTvrda13_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("13:00", 1, lblTvrda13);
        }

        private void lblTvrda14_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("14:00", 1, lblTvrda14);
        }

        private void lblTvrda15_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("15:00", 1, lblTvrda15);
        }

        private void lblTvrda16_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("16:00", 1, lblTvrda16);
        }

        private void lblTvrda17_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("17:00", 1, lblTvrda17);
        }

        private void lblTvrda18_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("18:00", 1, lblTvrda18);
        }

        private void lblTvrda19_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("19:00", 1, lblTvrda19);
        }

        private void lblTvrda20_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("20:00", 1, lblTvrda20);
        }

        //Trava
        private void lblTrava8_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("08:00", 22, lblTrava8);
        }

        private void lblTrava9_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("09:00", 22, lblTrava9);
        }

        private void lblTrava10_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("10:00", 22, lblTrava10);
        }

        private void lblTrava11_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("11:00", 22, lblTrava11);
        }

        private void lblTrava12_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("12:00", 22, lblTrava12);
        }

        private void lblTrava13_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("13:00", 22, lblTrava13);
        }

        private void lblTrava14_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("14:00", 22, lblTrava14);
        }

        private void lblTrava15_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("15:00", 22, lblTrava15);
        }

        private void lblTrava16_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("16:00", 22, lblTrava16);
        }

        private void lblTrava17_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("17:00", 22, lblTrava17);
        }

        private void lblTrava18_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("18:00", 22, lblTrava18);
        }

        private void lblTrava19_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("19:00", 22, lblTrava19);
        }

        private void lblTrava20_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("20:00", 22, lblTrava20);
        }

        //Zemlja
        private void lblZemlja8_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("08:00", 23, lblZemlja8);
        }

        private void lblZemlja9_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("09:00", 23, lblZemlja9);
        }

        private void lblZemlja10_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("10:00", 23, lblZemlja10);
        }

        private void lblZemlja11_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("11:00", 23, lblZemlja11);
        }

        private void lblZemlja12_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("12:00", 23, lblZemlja12);
        }

        private void lblZemlja13_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("13:00", 23, lblZemlja13);
        }

        private void lblZemlja14_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("14:00", 23, lblZemlja14);
        }

        private void lblZemlja15_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("15:00", 23, lblZemlja15);
        }

        private void lblZemlja16_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("16:00", 23, lblZemlja16);
        }

        private void lblZemlja17_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("17:00", 23, lblZemlja17);
        }

        private void lblZemlja18_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("18:00", 23, lblZemlja18);
        }

        private void lblZemlja19_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("19:00", 23, lblZemlja19);
        }

        private void lblZemlja20_Click(object sender, EventArgs e)
        {
            UpisiObrisiRezervaciju("20:00", 23, lblZemlja20);
        }
    }
}

