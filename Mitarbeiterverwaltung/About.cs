using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mitarbeiterverwaltung.DAL;

namespace Mitarbeiterverwaltung
{
    public partial class About : Form
    {
        public About(Settings settings)
        {
            InitializeComponent();
            lblCompanyName.Text = settings.companyName;
            pictureLogo.Image = new Bitmap(settings.logoPath);
        }

        private void lblCompanyName_Click(object sender, EventArgs e)
        {

        }
    }
}
