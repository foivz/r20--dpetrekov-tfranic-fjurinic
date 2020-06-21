using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennis_Track.Klase;

namespace Tennis_Track.Forme
{
    public partial class Help : Form
    {
        private GlavniIzbornik glavniIzbornik;

        public Help()
        {
            InitializeComponent();
        }

        public Help(GlavniIzbornik glavniIzbornik)
        {
            this.glavniIzbornik = glavniIzbornik;
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            glavniIzbornik.Show();
            this.Close();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            if(PrijavaClana.PrijavljeniCLan.TipClana=="Admin")
            {
                lblAdminPanel.Show();
            }
            else
            {
                lblAdminPanel.Hide();
            }
        }
    }
}
