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
using Tennis_Track.Iznimke;

namespace Tennis_Track.Forme
{
    public partial class Mecevi : Form
    {
        TennisTrackEntities tennisTrackEntities = new TennisTrackEntities();
        private PopisMeceva popisMeceva;
        public Clan odabraniSuigrac = new Clan();
        public Teren teren = new Teren();
        private Turnir turnir = new Turnir();
        private Set set1 = new Set();
        private Set set2 = new Set();
        private Set set3 = new Set();
        private Set set4 = new Set();
        private Set set5 = new Set();
        bool cetvrtiSetPotreban = true;
        bool odabirSuigraca = false;
        bool unosZadovoljava = false;


        public Mecevi()
        {
            InitializeComponent();
        }

        public Mecevi(PopisMeceva popisMeceva)
        {
            this.popisMeceva = popisMeceva;
            InitializeComponent();
        }
        

        private void Mecevi_Load(object sender, EventArgs e)
        {
            tennisTrackEntities.Clan.Load();
            var SviClanoviOsimPrijavljenog = from c in tennisTrackEntities.Clan.Local
                                            where c.KorisnickoIme != PrijavaClana.PrijavljeniCLan.KorisnickoIme
                                            select c;
            clanBindingSource.DataSource = SviClanoviOsimPrijavljenog;

            cmbTeren.DataSource = tennisTrackEntities.Teren.Local;
            txtIgrac.Text = PrijavaClana.PrijavljeniCLan.Ime + " " + PrijavaClana.PrijavljeniCLan.Prezime;
            
            var tereni = (from m in tennisTrackEntities.Teren select m.Vrsta).Distinct();
            cmbTeren.DataSource = tereni.ToList();

            cmbTermini.DataSource = PopuniTermine();

            var turniriKorisnika = (from turnir in tennisTrackEntities.Turnir from clan in turnir.Clans
                           where clan.ID==PrijavaClana.PrijavljeniCLan.ID select turnir.Naziv).Distinct();
            cmbTurnir.DataSource = turniriKorisnika.ToList();

            gboBrojDobivenih.BackColor = System.Drawing.Color.Transparent;
            gboSluzbenostMeca.BackColor = System.Drawing.Color.Transparent;
            lblPopis.BackColor = System.Drawing.Color.Transparent;
            lblIgrac1.BackColor = System.Drawing.Color.Transparent;
            lblIgrac2.BackColor = System.Drawing.Color.Transparent;
            lblPretraga.BackColor = System.Drawing.Color.Transparent;
            lblDatum.BackColor = System.Drawing.Color.Transparent;
            lblVrijeme.BackColor = System.Drawing.Color.Transparent;
            lblTeren.BackColor = System.Drawing.Color.Transparent;

            txtSuigrac.Enabled = false;
            txtIgrac.Enabled = false;
            for (int i = 0; i < clanDataGridView.Columns.Count; i++)
            {
                clanDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                clanDataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                clanDataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            clanDataGridView.AllowUserToAddRows = false;
            clanDataGridView.RowHeadersVisible = false;
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
            popisMeceva.Show();
            this.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var result = from c in tennisTrackEntities.Clan.Local where 
                         (c.Ime.ToLower() + " " + c.Prezime.ToLower()).Contains(txtFilter.Text.ToString().ToLower()) 
                         select c;
            clanBindingSource.DataSource = result.ToList();
        }


        private void btnKreirajMec_Click(object sender, EventArgs e)
        {
            Mec mec = new Mec();

            PopuniSetove();

            string time = cmbTermini.SelectedItem as string;
            TimeSpan realTime = TimeSpan.Parse(time);
            

            mec.Prvi_clan_Id = PrijavaClana.PrijavljeniCLan.ID;
            mec.Drugi_clan_Id = odabraniSuigrac.ID;
            mec.Datum = dtpDatumMeca.Value.Date;
            mec.Teren = OdaberiTeren();
            mec.Vrijeme = realTime;
            if (rbtnSluzbeni.Checked)
                mec.Turnir = OdaberiTurnir();
            else mec.Turnir = null;

            mec.Sets.Add(set1);
            mec.Sets.Add(set2);
            if (rbtn2Dobivena.Checked && ProvjeriRezultatMecaNaDvaDobivena())
            {
                if(ProvjeriGemove(txtIgracSet3.Text, txtSuigracSet3.Text))
                {
                    set3.Rezultat_prvi_clan = int.Parse(txtIgracSet3.Text);
                    set3.Rezultat_drugi_clan = int.Parse(txtSuigracSet3.Text);
                    mec.Sets.Add(set3);
                }
                else MessageBox.Show("Rezultati trećeg seta moraju biti nenegativni cijeli brojevi!", "Upozorenje!");

            }
            else if (rbtn3Dobivena.Checked)
            {
                if(ProvjeriGemove(txtIgracSet3.Text, txtSuigracSet3.Text))
                {
                    set3.Rezultat_prvi_clan = int.Parse(txtIgracSet3.Text);
                    set3.Rezultat_drugi_clan = int.Parse(txtSuigracSet3.Text);
                    mec.Sets.Add(set3);
                }
                else MessageBox.Show("Rezultati trećeg seta moraju biti nenegativni cijeli brojevi!", "Upozorenje!");

                if (ProvjeriPotrebuZaCetvrtimSetom())
                {
                    if(ProvjeriGemove(txtIgracSet4.Text, txtSuigracSet4.Text))
                    {
                        set4.Rezultat_prvi_clan = int.Parse(txtIgracSet4.Text);
                        set4.Rezultat_drugi_clan = int.Parse(txtSuigracSet4.Text);
                        mec.Sets.Add(set4);
                    }
                    else MessageBox.Show("Rezultati četvrtog seta moraju biti nenegativni cijeli brojevi!", "Upozorenje!");

                    if (ProvjeriPotrebuZaPetimSetom())
                    {
                        if(ProvjeriGemove(txtIgracSet5.Text, txtSuigracSet5.Text))
                        {
                            set5.Rezultat_prvi_clan = int.Parse(txtIgracSet5.Text);
                            set5.Rezultat_drugi_clan = int.Parse(txtSuigracSet5.Text);
                            mec.Sets.Add(set5);
                        }
                        else MessageBox.Show("Rezultati petog seta moraju biti nenegativni cijeli brojevi!", "Upozorenje!");
                    }
                }
            }
            
            if (odabirSuigraca)
            {
                if (unosZadovoljava)
                {
                    if (ProvjeraValjanostiRezultataMeca(mec))
                    {
                        if (ProvjeravaIzjednacenRezultat(mec))
                        {
                            tennisTrackEntities.Mec.Add(mec);
                            tennisTrackEntities.SaveChanges();
                            MessageBox.Show("Meč je dodan!", "Obavijest");
                        }
                        else MessageBox.Show("Rezultat završenog meča ne može biti izjednačen","Upozorenje");
                    }
                    else MessageBox.Show("Uneseni rezultati nisu valjani!", "Upozorenje!");
                }
                else MessageBox.Show("Rezultati svih setova moraju biti nenegativni cijeli brojevi!", "Upozorenje!");
            }
            else MessageBox.Show("Suigrač nije odabran!", "Upozorenje!");

        }

        private bool ProvjeravaIzjednacenRezultat(Mec mec)
        {
            int setoviIgraca1=0, setoviIgraca2 = 0;
            foreach (var item in mec.Sets)
            {
                if (item.Rezultat_prvi_clan > item.Rezultat_drugi_clan)
                    setoviIgraca1++;
                else setoviIgraca2++;
            }
            if (setoviIgraca1 != setoviIgraca2)
                return true;
            else return false;
        }

        private bool ProvjeraValjanostiRezultataMeca(Mec mec)
        {
            foreach (var item in mec.Sets)
            {
                if (((item.Rezultat_prvi_clan == 6 && item.Rezultat_drugi_clan < 5) || (item.Rezultat_prvi_clan == 7 && (item.Rezultat_drugi_clan == 6 || item.Rezultat_drugi_clan == 5))
                    || (item.Rezultat_drugi_clan == 6 && item.Rezultat_prvi_clan < 5) || (item.Rezultat_drugi_clan == 7 && (item.Rezultat_prvi_clan == 6 || item.Rezultat_prvi_clan ==5))) == false)
                    return false;
            }
            return true;
        }

        private Turnir OdaberiTurnir()
        {
            string imeTurnira = cmbTurnir.SelectedItem as string;
            var upitTurnir = from t in tennisTrackEntities.Turnir where t.Naziv == imeTurnira select t;
            List<Turnir> turniriCombo = upitTurnir.ToList();
            turnir = turniriCombo.First(t => 1 == 1);
            return turnir;
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
            if (ProvjeriGemove(txtIgracSet1.Text, txtSuigracSet1.Text))
            {
                set1.Rezultat_prvi_clan = int.Parse(txtIgracSet1.Text);
                set1.Rezultat_drugi_clan = int.Parse(txtSuigracSet1.Text);

                if (ProvjeriGemove(txtIgracSet2.Text, txtSuigracSet2.Text))
                {
                    set2.Rezultat_prvi_clan = int.Parse(txtIgracSet2.Text);
                    set2.Rezultat_drugi_clan = int.Parse(txtSuigracSet2.Text);
                }
                else MessageBox.Show("Rezultati drugog seta moraju biti nenegativni cijeli brojevi!","Upozorenje!");
            }
            else MessageBox.Show("Rezultati prvog seta moraju biti nenegativni cijeli brojevi!","Upozorenje!");


        }
        private bool ProvjeriGemove(string set1, string set2)
        {
            if (uint.TryParse(set1, out uint broj))
            {
                if (uint.TryParse(set2, out uint broj2))
                {
                    unosZadovoljava = true;
                    return true;
                }
                else
                {
                    unosZadovoljava = false;
                    return false;
                }
                
            }
            else
            {
                unosZadovoljava = false;
                return false;
            }
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
                if(ProvjeriGemove(txtIgracSet3.Text, txtSuigracSet3.Text))
                {
                    set3.Rezultat_prvi_clan = int.Parse(txtIgracSet3.Text);
                    set3.Rezultat_drugi_clan = int.Parse(txtSuigracSet3.Text);
                }
                else MessageBox.Show("Rezultati trećeg seta moraju biti nenegativni cijeli brojevi!", "Upozorenje!");


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
                if(ProvjeriGemove(txtIgracSet3.Text, txtSuigracSet3.Text))
                {
                    set3.Rezultat_prvi_clan = int.Parse(txtIgracSet3.Text);
                    set3.Rezultat_drugi_clan = int.Parse(txtSuigracSet3.Text);
                }
                else MessageBox.Show("Rezultati trećeg seta moraju biti nenegativni cijeli brojevi!", "Upozorenje!");

                if (txtIgracSet4.Text!="" && txtSuigracSet4.Text != "")
                {
                    if (ProvjeriGemove(txtIgracSet4.Text, txtSuigracSet4.Text))
                    {
                        set4.Rezultat_prvi_clan = int.Parse(txtIgracSet4.Text);
                        set4.Rezultat_drugi_clan = int.Parse(txtSuigracSet4.Text);
                    }
                    else MessageBox.Show("Rezultati četvrtog seta moraju biti nenegativni cijeli brojevi!", "Upozorenje!");
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
        private void txtIgracSet2_TextChanged(object sender, EventArgs e)
        {
            PromjenaUnosaRezultataSetova();
        }
        private void txtSuigracSet2_TextChanged(object sender, EventArgs e)
        {
            PromjenaUnosaRezultataSetova();
        }
        private void txtIgracSet1_TextChanged(object sender, EventArgs e)
        {
            PromjenaUnosaRezultataSetova();
        }
        private void txtSuigracSet1_TextChanged(object sender, EventArgs e)
        {
            PromjenaUnosaRezultataSetova();
        }
        private void txtIgracSet3_TextChanged(object sender, EventArgs e)
        {
            PromjenaUnosaRezultataSetova();
        }

        private void txtSuigracSet3_TextChanged(object sender, EventArgs e)
        {
            PromjenaUnosaRezultataSetova();
        }

        private void txtIgracSet4_TextChanged(object sender, EventArgs e)
        {
            PromjenaUnosaRezultataSetova();
        }

        private void txtSuigracSet4_TextChanged(object sender, EventArgs e)
        {
            PromjenaUnosaRezultataSetova();
        }

        private void PromjenaUnosaRezultataSetova()
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

        private void clanDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            odabirSuigraca = true;
            odabraniSuigrac = clanBindingSource.Current as Clan;
            txtSuigrac.Text = odabraniSuigrac.Ime + " " + odabraniSuigrac.Prezime;
        }

        private void rbtnSluzbeni_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnSluzbeni.Checked == true)
            {
                cmbTurnir.Enabled = true;
            }
        }

        private void rbtnNesluzbeni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNesluzbeni.Checked == true)
            {
                cmbTurnir.Enabled = false;
            }
        }

        private void Mecevi_KeyDown_1(object sender, KeyEventArgs e)
        {
        if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("Prozor ''Dodaj meč'' omogućuje korisniku dodavanje već odigranog meča. Korisnik bira suparnika" +
                    " dvostrukim klikom na korisnika u popisu igrača. Moguće je birati između igre na 2 ili 3 dobivena seta, kao i " +
                    "između službenog i neslužbenog meča. Moguće je i odabrati datum, vrijeme i vrstu terena na kojemu se igra. " +
                    "Nakon što odabere suparnika i unese rezultate setova, korisnik može " +
                    "kreirati meč.","Help");
            }
        }
    }
}
