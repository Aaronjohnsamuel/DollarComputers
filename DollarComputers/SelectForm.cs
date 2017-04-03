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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollorComputersDataSet1.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollorComputersDataSet1.products);
        }

        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtSelction_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void dataGridV(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
               DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
               txtSelction.Text = row.Cells[2].Value.ToString() + " " + row.Cells[3].Value.ToString() + " Priced at $" + row.Cells[1].Value.ToString();
               
               


            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();

            Program.MyProductInfoForm.Show();
        }
    }
}
