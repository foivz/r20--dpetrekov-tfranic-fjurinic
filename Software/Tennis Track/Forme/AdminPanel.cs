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
    public partial class AdminPanel : Form
    {
        private GlavniIzbornik glavniIzbornik;

        public AdminPanel()
        {
            InitializeComponent();
        }

        public AdminPanel(GlavniIzbornik glavniIzbornik)
        {
            this.glavniIzbornik = glavniIzbornik;
            InitializeComponent();
        }

        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            DodajClana dodajClana = new DodajClana(this);
            this.Hide();
            dodajClana.ShowDialog();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            glavniIzbornik.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brisanje_mečeva brisanje_Mečeva = new Brisanje_mečeva(this);
            this.Hide();
            brisanje_Mečeva.ShowDialog();
        }
    }
}
