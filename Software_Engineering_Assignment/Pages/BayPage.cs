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

        //Method which takes the screen to the patient page
        public Main.PageCall2 PatientPageCall = delegate { };

        public BayPage() => InitializeComponent();

        /// <summary>
        /// Guide program page to (selected) patient from the bay page
        /// </summary>
        /// <param name="bayPage"></param>
        /// <param name="goBackPage"></param>
        public BayPage(ref Bay bay, Main.PageCall0 goBackPage) : this()
        {
            ConnectBedsidesToDB(ref bay);
            button2.Click += delegate { goBackPage(); };
        }

        private void ConnectBedsidesToDB(ref Bay currentBay)
        {
            int BayNumber = currentBay.BayNumber;
            label1.Text = $"Bay {currentBay.BayNumber}";

            bedsideInfoControl1.AssignPatient(currentBay.GetBedside(1).patient);
            bedsideInfoControl1.PatientPageCall = delegate { PatientPageCall(BayNumber, 1); };

            bedsideInfoControl2.AssignPatient(currentBay.GetBedside(2).patient);
            bedsideInfoControl2.PatientPageCall = delegate { PatientPageCall(BayNumber, 2); };

            bedsideInfoControl3.AssignPatient(currentBay.GetBedside(3).patient);
            bedsideInfoControl3.PatientPageCall = delegate { PatientPageCall(BayNumber, 3); };

            bedsideInfoControl4.AssignPatient(currentBay.GetBedside(4).patient);
            bedsideInfoControl4.PatientPageCall = delegate { PatientPageCall(BayNumber, 4); };

            bedsideInfoControl5.AssignPatient(currentBay.GetBedside(5).patient);
            bedsideInfoControl5.PatientPageCall = delegate { PatientPageCall(BayNumber, 5); };

            bedsideInfoControl6.AssignPatient(currentBay.GetBedside(6).patient);
            bedsideInfoControl6.PatientPageCall = delegate { PatientPageCall(BayNumber, 6); };

            bedsideInfoControl7.AssignPatient(currentBay.GetBedside(7).patient);
            bedsideInfoControl7.PatientPageCall = delegate { PatientPageCall(BayNumber, 7); };

            bedsideInfoControl8.AssignPatient(currentBay.GetBedside(8).patient);
            bedsideInfoControl8.PatientPageCall = delegate { PatientPageCall(BayNumber, 8); };
        }

        private void Label1_TextChanged(object sender, EventArgs e)
        {
            Text = label1.Text; // Set title to bay details
        }
    }
}
