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
