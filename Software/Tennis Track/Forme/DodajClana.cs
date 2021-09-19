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
        private AdminPanel adminPanel;

        public DodajClana()
        {
            InitializeComponent();
        }


        public DodajClana(AdminPanel adminPanel)
        {
            this.adminPanel = adminPanel;
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            adminPanel.Show();
            this.Close();
        }

        private void btnKreirajNoviRacun_Click(object sender, EventArgs e)
        {
            Učlanjenje.DodajClana(txtIme.Text.ToString(), txtPrezime.Text.ToString(), 
                                  txtEmail.Text.ToString(), txtTelefon.Text.ToString());
        }

        private void DodajClana_Load(object sender, EventArgs e)
        {

        }
    }
}
