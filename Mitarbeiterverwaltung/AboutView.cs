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
    /// <summary>
    /// Window showing the company contact information and logo. 
    /// </summary>
    public partial class AboutView : Form
    {
        public AboutView(Settings settings)
        {
            InitializeComponent();
            lblCompanyName.Text = settings.companyName;

            if (!File.Exists(settings.logoPath))
            {
                throw new ErrorException("Der Logo-Pfad ist ungültig!");
            }
            else
            {
                pictureLogo.Image = new Bitmap(settings.logoPath);
            }
        }
    }
}
