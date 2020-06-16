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
        private Set set1 = new Set();
        private Set set2 = new Set();
        private Set set3 = new Set();
        private Set set4 = new Set();
        private Set set5 = new Set();
        bool cetvrtiSetPotreban = true;


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
            tennisTrackEntities.Clan.Load();
            clanBindingSource.DataSource = tennisTrackEntities.Clan.Local;
            cmbTeren.DataSource = tennisTrackEntities.Teren.Local;
            txtIgrac.Text = PrijavaClana.PrijavljeniCLan.Ime + " " + PrijavaClana.PrijavljeniCLan.Prezime;
            var mecevi = from m in tennisTrackEntities.Mec select m;
            dgvMecevi.DataSource = mecevi.ToList();
            var tereni = (from m in tennisTrackEntities.Teren select m.Vrsta).Distinct();
            cmbTeren.DataSource = tereni.ToList();
            cmbTermini.DataSource = PopuniTermine();
            gboBrojDobivenih.BackColor = System.Drawing.Color.Transparent;
            txtSuigrac.Enabled = false;
            txtIgrac.Enabled = false;
           
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
            if (odabraniSuigrac.ID == PrijavaClana.PrijavljeniCLan.ID)
            {
                MessageBox.Show("Igrač i suigrač ne mogu biti ista osoba!");
            }
            else
            {
                txtSuigrac.Text = odabraniSuigrac.Ime + " " + odabraniSuigrac.Prezime;
            }
        }

        private void btnKreirajMec_Click(object sender, EventArgs e)
        {
            Mec mec = new Mec();

            PopuniSetove();

            string time = cmbTermini.SelectedItem as string;
            TimeSpan realTime = TimeSpan.Parse(time);
            teren = OdaberiTeren();
            

            mec.Prvi_clan_Id = PrijavaClana.PrijavljeniCLan.ID;
            mec.Drugi_clan_Id = odabraniSuigrac.ID;
            mec.Datum = dtpDatumMeca.Value;
            mec.Teren = teren;
            mec.Vrijeme = realTime;
            mec.Sets.Add(set1);
            mec.Sets.Add(set2);
            if (rbtn2Dobivena.Checked && ProvjeriRezultatMecaNaDvaDobivena())
            {
                
                set3.Rezultat_prvi_clan = int.Parse(txtIgracSet3.Text);
                set3.Rezultat_drugi_clan = int.Parse(txtSuigracSet3.Text);
                mec.Sets.Add(set3);
            }
            else if (rbtn3Dobivena.Checked)
            {
                set3.Rezultat_prvi_clan = int.Parse(txtIgracSet3.Text);
                set3.Rezultat_drugi_clan = int.Parse(txtSuigracSet3.Text);
                mec.Sets.Add(set3);

                if (ProvjeriPotrebuZaCetvrtimSetom())
                {
                    set4.Rezultat_prvi_clan = int.Parse(txtIgracSet4.Text);
                    set4.Rezultat_drugi_clan = int.Parse(txtSuigracSet4.Text);
                    mec.Sets.Add(set4);

                    if (ProvjeriPotrebuZaPetimSetom())
                    {
                        set5.Rezultat_prvi_clan = int.Parse(txtIgracSet5.Text);
                        set5.Rezultat_drugi_clan = int.Parse(txtSuigracSet5.Text);
                        mec.Sets.Add(set5);
                    }
                }
            }
            
            tennisTrackEntities.Mec.Add(mec);
            tennisTrackEntities.SaveChanges();
            MessageBox.Show("Meč je dodan!");
        }

        private Teren OdaberiTeren()
        {
            string imeTerena = cmbTeren.SelectedItem as string;
            var upitTeren = from t in tennisTrackEntities.Teren where imeTerena==t.Vrsta select t;
            List<Teren> tereniCombo = upitTeren.ToList();
            teren = tereniCombo.First(t => 1 == 1);
            return teren;
        }

        private void PopuniSetove()
        {
            set1.Rezultat_prvi_clan = int.Parse(txtIgracSet1.Text);
            set1.Rezultat_drugi_clan = int.Parse(txtSuigracSet1.Text);

            set2.Rezultat_prvi_clan = int.Parse(txtIgracSet2.Text);
            set2.Rezultat_drugi_clan = int.Parse(txtSuigracSet2.Text);
        }


        private bool ProvjeriPotrebuZaPetimSetom()
        {
            int dobiveniSetoviIgraca = 0, dobiveniSetoviSuigraca = 0;
            if (set1.Rezultat_prvi_clan > set1.Rezultat_drugi_clan + 1 || (set1.Rezultat_prvi_clan == 7 && set1.Rezultat_drugi_clan == 6))
                dobiveniSetoviIgraca++;
            else
                dobiveniSetoviSuigraca++;

            if (set2.Rezultat_prvi_clan > set2.Rezultat_drugi_clan + 1 || (set2.Rezultat_prvi_clan == 7 && set2.Rezultat_drugi_clan == 6))
                dobiveniSetoviIgraca++;
            else
                dobiveniSetoviSuigraca++;

            if (set3.Rezultat_prvi_clan > set3.Rezultat_drugi_clan + 1 || (set3.Rezultat_prvi_clan == 7 && set3.Rezultat_drugi_clan == 6))
                dobiveniSetoviIgraca++;
            else
                dobiveniSetoviSuigraca++;

            if (set4.Rezultat_prvi_clan > set4.Rezultat_drugi_clan + 1 || (set4.Rezultat_prvi_clan == 7 && set4.Rezultat_drugi_clan == 6))
                dobiveniSetoviIgraca++;
            else
                dobiveniSetoviSuigraca++;


            if (dobiveniSetoviIgraca != 3 && dobiveniSetoviSuigraca != 3)
                return true;
            else return false; 
            
        }

        private bool ProvjeriPotrebuZaCetvrtimSetom()
        {
            int dobiveniSetoviIgraca = 0, dobiveniSetoviSuigraca = 0;
            if (set1.Rezultat_prvi_clan > set1.Rezultat_drugi_clan + 1 || (set1.Rezultat_prvi_clan == 7 && set1.Rezultat_drugi_clan == 6))
                dobiveniSetoviIgraca++;
            else
                dobiveniSetoviSuigraca++;

            if (set2.Rezultat_prvi_clan > set2.Rezultat_drugi_clan + 1 || (set2.Rezultat_prvi_clan == 7 && set2.Rezultat_drugi_clan == 6))
                dobiveniSetoviIgraca++;
            else
                dobiveniSetoviSuigraca++;

            if (set3.Rezultat_prvi_clan > set3.Rezultat_drugi_clan + 1 || (set3.Rezultat_prvi_clan == 7 && set3.Rezultat_drugi_clan == 6))
                dobiveniSetoviIgraca++;
            else
                dobiveniSetoviSuigraca++;

            if (dobiveniSetoviIgraca != 3 && dobiveniSetoviSuigraca != 3)
            {
                return true;
            }
            else return false;
                
        }

        private bool ProvjeriRezultatMecaNaDvaDobivena()
        {
            int dobiveniSetoviIgraca = 0, dobiveniSetoviSuigraca = 0;
            if (set1.Rezultat_prvi_clan > set1.Rezultat_drugi_clan + 1 || (set1.Rezultat_prvi_clan == 7 && set1.Rezultat_drugi_clan == 6))
                dobiveniSetoviIgraca++;
            else
                dobiveniSetoviSuigraca++;

            if (set2.Rezultat_prvi_clan > set2.Rezultat_drugi_clan + 1 || (set2.Rezultat_prvi_clan == 7 && set2.Rezultat_drugi_clan == 6))
                dobiveniSetoviIgraca++;
            else
                dobiveniSetoviSuigraca++;

            if (dobiveniSetoviIgraca != 2 && dobiveniSetoviSuigraca != 2)
                return true;
            else return false;
        }

        private void txtIgracSet2_TextChanged(object sender, EventArgs e)
        {
            if (rbtn2Dobivena.Checked)
                ProvjeriPotrebuZaUnosomTrecegSeta();
            else
            {
                ProvjeriPotrebuZaUnosomCetvrtogSeta();
                if (cetvrtiSetPotreban == true)
                    ProvjeriPotrebuZaUnosomPetogSeta();
            }
        }
        private void txtSuigracSet2_TextChanged(object sender, EventArgs e)
        {
            if (rbtn2Dobivena.Checked)
                ProvjeriPotrebuZaUnosomTrecegSeta();
            else
            {
                ProvjeriPotrebuZaUnosomCetvrtogSeta();
                if (cetvrtiSetPotreban == true)
                    ProvjeriPotrebuZaUnosomPetogSeta();
            }
        }
        private void txtIgracSet1_TextChanged(object sender, EventArgs e)
        {
            if(rbtn2Dobivena.Checked)
                ProvjeriPotrebuZaUnosomTrecegSeta();
            else
            {
                ProvjeriPotrebuZaUnosomCetvrtogSeta();
                if (cetvrtiSetPotreban == true)
                    ProvjeriPotrebuZaUnosomPetogSeta();
            }
        }
        private void txtSuigracSet1_TextChanged(object sender, EventArgs e)
        {
            if (rbtn2Dobivena.Checked)
                ProvjeriPotrebuZaUnosomTrecegSeta();
            else
            {
                ProvjeriPotrebuZaUnosomCetvrtogSeta();
                if(cetvrtiSetPotreban==true)
                    ProvjeriPotrebuZaUnosomPetogSeta();
            }
        }

        public void ProvjeriPotrebuZaUnosomTrecegSeta()
        {
            if (txtIgracSet1.Text != "" && txtIgracSet2.Text != "" && txtSuigracSet1.Text != "" && txtSuigracSet2.Text != "")
            {
                PopuniSetove();
                if (ProvjeriRezultatMecaNaDvaDobivena() == false)
                {
                    txtIgracSet3.Text = "";
                    txtSuigracSet3.Text = "";

                    txtIgracSet3.Enabled = false;
                    txtSuigracSet3.Enabled = false;
                    lblSet3.Enabled = false;
                }
                else
                {
                    txtIgracSet3.Enabled = true;
                    txtSuigracSet3.Enabled = true;
                    lblSet3.Enabled = true;
                }
            }
            else
            {
                txtIgracSet3.Enabled = true;
                txtSuigracSet3.Enabled = true;
                lblSet3.Enabled = true;
            }
        }

        public void ProvjeriPotrebuZaUnosomCetvrtogSeta()
        {
            
            if (txtIgracSet1.Text != "" && txtIgracSet2.Text != "" && txtSuigracSet1.Text != "" &&
                txtSuigracSet2.Text != "" && txtIgracSet3.Text != "" && txtSuigracSet3.Text != "")
            {
                PopuniSetove();
                set3.Rezultat_prvi_clan = int.Parse(txtIgracSet3.Text);
                set3.Rezultat_drugi_clan = int.Parse(txtSuigracSet3.Text);
                if (ProvjeriPotrebuZaCetvrtimSetom() == false)
                {
                    txtIgracSet4.Text = "";
                    txtIgracSet5.Text = "";
                    txtSuigracSet5.Text = "";
                    txtSuigracSet4.Text = "";

                    txtIgracSet4.Enabled = false;
                    txtSuigracSet4.Enabled = false;
                    lblSet4.Enabled = false;
                    txtIgracSet5.Enabled = false;
                    txtSuigracSet5.Enabled = false;
                    lblSet5.Enabled = false;

                    cetvrtiSetPotreban = false;
                }
                else
                {
                    txtIgracSet4.Enabled = true;
                    txtSuigracSet4.Enabled = true;
                    lblSet4.Enabled = true;
                    txtIgracSet5.Enabled = true;
                    txtSuigracSet5.Enabled = true;
                    lblSet5.Enabled = true;

                    cetvrtiSetPotreban = true;
                }
            }
            else
            {
                txtIgracSet4.Enabled = true;
                txtSuigracSet4.Enabled = true;
                lblSet4.Enabled = true;
                txtIgracSet5.Enabled = true;
                txtSuigracSet5.Enabled = true;
                lblSet5.Enabled = true;
            }
        }

        public void ProvjeriPotrebuZaUnosomPetogSeta()
        {
            if (txtIgracSet1.Text != "" && txtIgracSet2.Text != "" && txtSuigracSet1.Text != "" &&
                txtSuigracSet2.Text != "" && txtIgracSet3.Text != "" && txtSuigracSet3.Text != ""
               )
            {
                PopuniSetove();
                set3.Rezultat_prvi_clan = int.Parse(txtIgracSet3.Text);
                set3.Rezultat_drugi_clan = int.Parse(txtSuigracSet3.Text);

                if(txtIgracSet4.Text!="" && txtSuigracSet4.Text != "")
                {
                    set4.Rezultat_prvi_clan = int.Parse(txtIgracSet4.Text);
                    set4.Rezultat_drugi_clan = int.Parse(txtSuigracSet4.Text);
                }
                
                if (ProvjeriPotrebuZaPetimSetom() == false)
                {
                    txtIgracSet5.Text = "";
                    txtSuigracSet5.Text = "";
                    txtIgracSet5.Enabled = false;
                    txtSuigracSet5.Enabled = false;
                    lblSet5.Enabled = false;
                }
                else 
                {
                    txtIgracSet5.Enabled = true;
                    txtSuigracSet5.Enabled = true;
                    lblSet5.Enabled = true;
                }
            }
            else 
            {
                txtIgracSet5.Enabled = true;
                txtSuigracSet5.Enabled = true;
                lblSet5.Enabled = true;
            }
        }
        private void rbtn3Dobivena_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn3Dobivena.Checked == true)
            {
                lblSet3.Visible = true;
                lblSet4.Visible = true;
                lblSet5.Visible = true;
                txtIgracSet4.Visible = true;
                txtIgracSet5.Visible = true;
                txtIgracSet3.Visible = true;
                txtSuigracSet3.Visible = true;
                txtSuigracSet4.Visible = true;
                txtSuigracSet5.Visible = true;

                lblSet3.Enabled = true;
                txtIgracSet4.Enabled = true;
                txtIgracSet5.Enabled = true;
                txtIgracSet3.Enabled = true;
                txtSuigracSet3.Enabled = true;
                txtSuigracSet4.Enabled = true;
                txtSuigracSet5.Enabled = true;
            }
        }

        private void rbtn2Dobivena_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn2Dobivena.Checked == true)
            {
                lblSet4.Visible = false;
                lblSet5.Visible = false;
                txtIgracSet4.Visible = false;
                txtIgracSet5.Visible = false;
                txtSuigracSet4.Visible = false;
                txtSuigracSet5.Visible = false;
            }
        }

        private void txtIgracSet3_TextChanged(object sender, EventArgs e)
        {
            if (rbtn2Dobivena.Checked)
                ProvjeriPotrebuZaUnosomTrecegSeta();
            else
            {
                ProvjeriPotrebuZaUnosomCetvrtogSeta();
                if (cetvrtiSetPotreban == true)
                    ProvjeriPotrebuZaUnosomPetogSeta();
            }
        }

        private void txtSuigracSet3_TextChanged(object sender, EventArgs e)
        {
            if (rbtn2Dobivena.Checked)
                ProvjeriPotrebuZaUnosomTrecegSeta();
            else
            {
                ProvjeriPotrebuZaUnosomCetvrtogSeta();
                if (cetvrtiSetPotreban == true)
                    ProvjeriPotrebuZaUnosomPetogSeta();
            }
        }

        private void txtIgracSet4_TextChanged(object sender, EventArgs e)
        {
            if (rbtn2Dobivena.Checked)
                ProvjeriPotrebuZaUnosomTrecegSeta();
            else
            {
                ProvjeriPotrebuZaUnosomCetvrtogSeta();
                if (cetvrtiSetPotreban == true)
                    ProvjeriPotrebuZaUnosomPetogSeta();
            }
        }

        private void txtSuigracSet4_TextChanged(object sender, EventArgs e)
        {
            if (rbtn2Dobivena.Checked)
                ProvjeriPotrebuZaUnosomTrecegSeta();
            else
            {
                ProvjeriPotrebuZaUnosomCetvrtogSeta();
                if (cetvrtiSetPotreban == true)
                    ProvjeriPotrebuZaUnosomPetogSeta();
            }
        }
    }
}
