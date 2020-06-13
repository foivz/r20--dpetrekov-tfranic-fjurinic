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
    public partial class RangListe : Form
    {
        private GlavniIzbornik glavniIzbornik;

        public RangListe()
        {
            InitializeComponent();
        }

        public RangListe(GlavniIzbornik glavniIzbornik)
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
