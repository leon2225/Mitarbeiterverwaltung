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
    public partial class HelpView : Form
    {
        public HelpView()
        {
            InitializeComponent();
            rtbHelp.Text = Properties.Resources.HelpString;
        }
    }
}
