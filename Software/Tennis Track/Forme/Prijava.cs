using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennis_Track.Forme;
using Tennis_Track.Klase;

namespace Tennis_Track
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void TxtUsername_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TxtUsername.SelectAll();
        }

        private void TxtPassword_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TxtPassword.SelectAll();
        }

        private void BtnPrijaviSe_Click(object sender, EventArgs e)
        {
            GlavniIzbornik glavniIzbornik = new GlavniIzbornik(this);
            if (PrijavaClana.ProvjeriPodatke(TxtUsername.Text.ToString(), TxtPassword.Text.ToString()))
            {
                this.Hide();
                glavniIzbornik.ShowDialog();
                TxtUsername.Text = "Korisnicko ime";
                TxtPassword.Text = "Lozinka";
            }
        }

        private void btnResetirajLozinku_Click(object sender, EventArgs e)
        {
           Učlanjenje.ResetirajLozinku(TxtUsername.Text.ToString());
        }
    }
}