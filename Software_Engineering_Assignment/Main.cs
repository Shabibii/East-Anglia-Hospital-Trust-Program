using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_Engineering_Assignment.Pages;
using Software_Engineering_Assignment.Support_Classes;

namespace Software_Engineering_Assignment
{
    public partial class Main : Form
    {
        //Pages in the program (User controls in the "Pages" folder)
        private readonly Dictionary<int, UserControl> pages = new Dictionary<int, UserControl>();

        //Page call method with 0 parameters
        public delegate void PageCall0();
        //Page call method with 1 parameter
        public delegate void PageCall1(int bayNumber);
        //Page call method with 2 parameters
        public delegate void PageCall2(int bayNumber, int bedNumber);
        public PageCall0 BayPageCall = delegate { };

        public CentralStation MainPage { get; set; }

        public static Bay bay1;
        public static Bay bay2;

        public BayPage BayPage1 { get; set; }

        public BayPage BayPage2 { get; set; }

        public ManagementPage ManagementPage { get; set; }

        public RegistrationPage RegisterationPage { get; set; }

        public BedsidePage PatientPage { get; set; }

        public Main() => InitializeComponent();

        private void InitalizePages()
        {
            MainPage = new CentralStation(SetPatientPage)
            {
                BayPageCall = SetPageToBay,
                ManagementPageCall = CallManagementPage,
                RegisterationPageCall = CallRegisterationPage
            };

            bay1 = new Bay(1);
            bay2 = new Bay(2);

            BayPage1 = new BayPage(ref bay1, GoToMainpage) { PatientPageCall = SetPatientPage };
            BayPage2 = new BayPage(ref bay2, GoToMainpage) { PatientPageCall = SetPatientPage };
            ManagementPage = new ManagementPage() { pageCall0 = GoToMainpage };
            RegisterationPage = new RegistrationPage() { goBackToParentPage = GoToMainpage };
            PatientPage = new BedsidePage(GoToMainpage);

            pages.Add(0, MainPage);
            pages.Add(1, BayPage1);
            pages.Add(2, BayPage2);
            pages.Add(3, ManagementPage);
            pages.Add(4, RegisterationPage);
            pages.Add(5, PatientPage);
        } 

        public void SetPage(int pageNumber)
        {
            //Pages have to be the same size for the design theme to work
            Controls.Clear();
            Controls.Add(pages[pageNumber]);
            Text = pages[pageNumber].Text;
        }

        public void SetPatientPage(int bayNumber,int bedNumber)
        {
            //Set page to patient page
            if(bayNumber == 1)
                ((BedsidePage)pages[5]).SetBedside(bay1.GetBedside(bedNumber));
            else
                ((BedsidePage)pages[5]).SetBedside(bay2.GetBedside(bedNumber));

            SetPage(5);
        }

        public void GoToMainpage()
        {
            //Go to Page 0
            SetPage(0);
        }

        public void SetPageToBay(int bayNumber)
        {
            if (bayNumber == 1 || bayNumber == 2) SetPage(bayNumber);
        }

        public void CallManagementPage()
        {
            //Go to Page 3
            SetPage(3);
        }

        public void CallRegisterationPage()
        {
            //Go to Page 4
            SetPage(4);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitalizePages();
            SetPage(0);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainPage.Dispose();
            BayPage1.Dispose();
            BayPage2.Dispose();
            ManagementPage.Dispose();
            RegisterationPage.Dispose();
            PatientPage.Dispose();
        }
    }
}
