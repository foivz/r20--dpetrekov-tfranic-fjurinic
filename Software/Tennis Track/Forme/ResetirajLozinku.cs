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
    public partial class ResetirajLozinku : Form
    {
        private LoginForm loginForm;

        public ResetirajLozinku()
        {
            InitializeComponent();
        }

        public ResetirajLozinku(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void btnResetirajLozinku_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Klikom na gumb OK resetirati čete svoju lozinku.", "UPOZORENJE!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Učlanjenje.ResetirajLozinku(TxtUsername.Text.ToString(), txtEmail.Text.ToString());
            }
        }
    }
}
