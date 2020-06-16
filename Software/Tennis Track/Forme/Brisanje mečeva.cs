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

namespace Tennis_Track.Forme
{
    public partial class Brisanje_mečeva : Form
    {
        private AdminPanel adminPanel;
        private TennisTrackEntities tennisTrackEntities = new TennisTrackEntities();

        public Brisanje_mečeva()
        {
            InitializeComponent();
        }

        public Brisanje_mečeva(AdminPanel adminPanel)
        {
            this.adminPanel = adminPanel;
            InitializeComponent();
        }

        private void Brisanje_mečeva_Load(object sender, EventArgs e)
        {
            tennisTrackEntities.Mec.Load();
            mecBindingSource.DataSource = tennisTrackEntities.Mec.Local;
            mecDataGridView.AllowUserToAddRows = false;
            mecDataGridView.RowHeadersVisible = false;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            adminPanel.Show();
            this.Close();
        }

        private void btnBrisiMec_Click(object sender, EventArgs e)
        {
            Mec mecZaObrisati = mecBindingSource.Current as Mec;
            mecBindingSource.Remove(mecZaObrisati);
            tennisTrackEntities.Mec.Remove(mecZaObrisati);
            tennisTrackEntities.SaveChanges();
        }
    }
}
