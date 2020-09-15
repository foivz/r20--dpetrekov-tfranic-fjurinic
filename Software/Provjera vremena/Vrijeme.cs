using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvjeraVremena
{
    public class Vrijeme
    {
        public bool ProvjeriVrijeme(string vrijeme, Label label)
        {
            var date = DateTime.Parse(label.Text);
            var datum = date.ToString("yyyy-MM-dd");
            var time = DateTime.Now;
            DateTime vrijeme1 = DateTime.Parse(vrijeme);
            
            if (datum == DateTime.Today.ToString("yyyy-MM-dd") && vrijeme1 <= time)
            {
                MessageBox.Show("Ne možete rezervirati termin u prošlosti!");
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ProvjeriVrijemeBrisanje(string vrijeme, Label label)
        {
            var date = DateTime.Parse(label.Text);
            var datum = date.ToString("yyyy-MM-dd");
            var time = DateTime.Now;
            DateTime vrijeme1 = DateTime.Parse(vrijeme);

            if (datum == DateTime.Today.ToString("yyyy-MM-dd") && vrijeme1 <= time)
            {
                MessageBox.Show("Ne možete obrisati termin iz prošlosti!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
