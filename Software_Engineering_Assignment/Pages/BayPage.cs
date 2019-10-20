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

            bedsideInfoControl1.AssignPatient(selectedBay.GetPatient(1));
            bedsideInfoControl2.AssignPatient(selectedBay.GetPatient(2));
            bedsideInfoControl3.AssignPatient(selectedBay.GetPatient(3));
            bedsideInfoControl4.AssignPatient(selectedBay.GetPatient(4));
            bedsideInfoControl5.AssignPatient(selectedBay.GetPatient(5));
            bedsideInfoControl6.AssignPatient(selectedBay.GetPatient(6));
            bedsideInfoControl7.AssignPatient(selectedBay.GetPatient(7));
            bedsideInfoControl8.AssignPatient(selectedBay.GetPatient(8));
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
