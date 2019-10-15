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
        private readonly Dictionary<int, UserControl> pages = new Dictionary<int, UserControl>();

        public Main()
        {
            InitializeComponent();
            InitalizePages();
            SetPage(0);
        }

        private void InitalizePages()
        {
            MainPage mainPage = new MainPage
            {
                BayPageCall = SetPageToBay
            };

            pages.Add(0, mainPage);
            pages.Add(1, new BayPage(1,GoToMainpage));
            pages.Add(2, new BayPage(2, GoToMainpage));
            pages.Add(3, new ManagementPage());
            pages.Add(4, new RegisterationPage());
            pages.Add(5, new PatientPage());
        }

        public void SetPage(int pageNumber)
        {
            //Pages have to be the same size for the design theme to work
            Controls.Clear();
            Controls.Add(pages[pageNumber]);
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

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            Text = Size.ToString();
        }
    }
}
