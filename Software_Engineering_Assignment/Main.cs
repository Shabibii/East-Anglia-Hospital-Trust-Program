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


        

        public Main()
        {
            InitializeComponent();
            InitalizePages();
            SetPage(0);
        }

        private void InitalizePages()
        {
            MainPage mainPage = new MainPage(SetPatientPage)
            {
                BayPageCall = SetPageToBay,
                ManagementPageCall = CallManagementPage,
                RegisterationPageCall = CallRegisterationPage
            };

            pages.Add(0, mainPage);
            pages.Add(1, new BayPage(1, GoToMainpage) { PatientPageCall = SetPatientPage});
            pages.Add(2, new BayPage(2, GoToMainpage) { PatientPageCall = SetPatientPage });
            pages.Add(3, new ManagementPage() {pageCall0 = GoToMainpage });
            pages.Add(4, new RegisterationPage() { goBackToParentPage = GoToMainpage });
            pages.Add(5, new PatientPage(GoToMainpage));
        } 

        public void SetPage(int pageNumber)
        {
            //Pages have to be the same size for the design theme to work
            Controls.Clear();
            Controls.Add(pages[pageNumber]);
        }

        public void SetPatientPage(int bayNumber,int pageNumber)
        {
            //Set page to patient page
            ((PatientPage)pages[5]).SetPatient(bayNumber, pageNumber);
            SetPage(5);
        }

        public void GoToMainpage()
        {
            //Go to Page 0
            SetPage(0);
        }

        public void SetPageToBay(int bayNumber)
        {
            switch(bayNumber)
            {
                case 1:
                    SetPage(1);
                    break;

                case 2:
                    SetPage(2);
                    break;
            }
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

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            Text = Size.ToString();
        }
    }
}
