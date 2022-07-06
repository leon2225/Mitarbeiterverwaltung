namespace Mitarbeiterverwaltung
{
    /// <summary>
    /// Window showing the company contact information and logo. 
    /// </summary>
    public partial class HelpView : Form
    {
        public HelpView()
        {
            InitializeComponent();
            rtbHelp.Text = Properties.Resources.HelpString;
        }
    }
}
