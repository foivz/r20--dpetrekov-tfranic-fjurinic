using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis_Track.Forme
{
    public partial class StatistikaKorisnika : Form
    {
        private GlavniIzbornik glavniIzbornik;

        public StatistikaKorisnika()
        {
            InitializeComponent();
        }

        public StatistikaKorisnika(GlavniIzbornik glavniIzbornik)
        {
            this.glavniIzbornik = glavniIzbornik;
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            glavniIzbornik.Show();
            this.Close();
        }
    }
}
