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
using Tennis_Track.Klase;

namespace Tennis_Track.Forme
{
    public partial class DodajClana : Form
    {
        private GlavniIzbornik glavniIzbornik;

        public DodajClana()
        {
            InitializeComponent();
        }

        public DodajClana(GlavniIzbornik glavniIzbornik)
        {
            InitializeComponent();
            this.glavniIzbornik = glavniIzbornik;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            glavniIzbornik.Show();
            this.Close();
        }

        private void btnKreirajNoviRacun_Click(object sender, EventArgs e)
        {
            Učlanjenje.DodajClana(this);
        }

        private void DodajClana_Load(object sender, EventArgs e)
        {

        }
    }
}
