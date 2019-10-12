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
            pages.Add(0,new MainPage());
            pages.Add(1, new BayPage());
            pages.Add(2, new BayPage());
            pages.Add(3, new ManagementPage());
            pages.Add(4, new RegistrationPage());
        }

        public void SetPage(int pageNumber)
        {
            //Pages have to be the same size for the design theme to work
            Controls.Clear();
            Controls.Add(pages[pageNumber]);
        }
    }
}
