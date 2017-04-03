using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {

            Program.MySelectForm.Show();
        }

        private void btnSavedOrder_Click(object sender, EventArgs e)
        {
            Program.MyProductInfoForm.Show();
        }
    }
}
