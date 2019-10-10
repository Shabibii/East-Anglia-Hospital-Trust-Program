using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeBays();
        }

        public void InitializeBays()
        {
            bayControl1.SetBay(new Bay(1));
            bayControl2.SetBay(new Bay(2));
        }
    }
}
