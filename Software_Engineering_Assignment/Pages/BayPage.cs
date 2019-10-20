using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Assignment.Pages
{
    public partial class BayPage : UserControl
    {
        Bay selectedBay;

        public delegate void PageCall();
        public PageCall PreviousPageCall = delegate { };

        public BayPage()
        {
            InitializeComponent();
        }

        public BayPage(int bayPage, PageCall goBackPage) : this()
        {
            SelectBay(bayPage);
            PreviousPageCall = goBackPage;
        }

        public void SelectBay(int bayPage)
        {
            selectedBay = DatabaseConnector.GetBay(bayPage);
            label1.Text = $"Bay {bayPage}";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PreviousPageCall();
        }

        private void BayPage_Load(object sender, EventArgs e)
        {

        }
    }
}
