using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_Engineering_Assignment.Support_Classes;

namespace Software_Engineering_Assignment.Pages
{
    public partial class BayPage : UserControl
    {
        Bay currentBay; // bay holding bedsides being displayed

        //Method which takes the screen to the patient page
        public Main.PageCall2 PatientPageCall = delegate { };

        public BayPage() => InitializeComponent();

        /// <summary>
        /// Guide program page to (selected) patient from the bay page
        /// </summary>
        /// <param name="bayPage"></param>
        /// <param name="goBackPage"></param>
        public BayPage(int bayPage, Main.PageCall0 goBackPage) : this()
        {
            SelectBay(bayPage);
            ConnectBedsidesToDB();
            button2.Click += delegate { goBackPage(); };
        }

        private void ConnectBedsidesToDB()
        {
            bedsideInfoControl1.AssignPatient(currentBay.GetPatient(1));
            bedsideInfoControl1.PatientPageCall = delegate { PatientPageCall(currentBay.BayNumber, 1); };

            bedsideInfoControl2.AssignPatient(currentBay.GetPatient(2));
            bedsideInfoControl2.PatientPageCall = delegate { PatientPageCall(currentBay.BayNumber, 2); };

            bedsideInfoControl3.AssignPatient(currentBay.GetPatient(3));
            bedsideInfoControl3.PatientPageCall = delegate { PatientPageCall(currentBay.BayNumber, 3); };

            bedsideInfoControl4.AssignPatient(currentBay.GetPatient(4));
            bedsideInfoControl4.PatientPageCall = delegate { PatientPageCall(currentBay.BayNumber, 4); };

            bedsideInfoControl5.AssignPatient(currentBay.GetPatient(5));
            bedsideInfoControl5.PatientPageCall = delegate { PatientPageCall(currentBay.BayNumber, 5); };

            bedsideInfoControl6.AssignPatient(currentBay.GetPatient(6));
            bedsideInfoControl6.PatientPageCall = delegate { PatientPageCall(currentBay.BayNumber, 6); };

            bedsideInfoControl7.AssignPatient(currentBay.GetPatient(7));
            bedsideInfoControl7.PatientPageCall = delegate { PatientPageCall(currentBay.BayNumber, 7); };

            bedsideInfoControl8.AssignPatient(currentBay.GetPatient(8));
            bedsideInfoControl8.PatientPageCall = delegate { PatientPageCall(currentBay.BayNumber, 8); };
        }

        public void SelectBay(int bayPage)
        {
            // get bay from database connector
            currentBay = DatabaseConnector.Instance.GetBay(bayPage);
            label1.Text = $"Bay {bayPage}";
        }

        private void Label1_TextChanged(object sender, EventArgs e)
        {
            Text = label1.Text; // Set title to bay details
        }
    }
}
