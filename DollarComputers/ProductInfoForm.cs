using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DollarComputers
{
    public partial class ProductInfoForm : Form
    {

        private StreamWriter _writer;
        private StreamReader _reader;
        private const char _DELIMETER = ',';
        private Computer _computer;

        public ProductInfoForm()
        {
            InitializeComponent();

            this._computer = new Computer();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

       public void ProductInfoForm_Load(object sender, EventArgs e)
        {
            DialogResult result;
            string filename;

            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;


                string computerInfoString = "";

                try
                {
                    this._reader = new StreamReader(filename);

                    if (this._reader.Peek() != -1)
                    {
                        computerInfoString = this._reader.ReadLine();

                        this._computer.ProductID = computerInfoString.Split(_DELIMETER)[0]; 
                        this._computer.Condition = computerInfoString.Split(_DELIMETER)[1]; 
                        this._computer.Cost = computerInfoString.Split(_DELIMETER)[2];
                        this._computer.Platform = computerInfoString.Split(_DELIMETER)[3];
                        this._computer.OS = computerInfoString.Split(_DELIMETER)[4];
                        this._computer.Manufacture = computerInfoString.Split(_DELIMETER)[5];
                        this._computer.Model = computerInfoString.Split(_DELIMETER)[6];
                        this._computer.Memory = computerInfoString.Split(_DELIMETER)[7];
                        this._computer.CPUBrand = computerInfoString.Split(_DELIMETER)[8];
                        this._computer.CPUType = computerInfoString.Split(_DELIMETER)[9];
                        this._computer.LCDSize = computerInfoString.Split(_DELIMETER)[10];
                        this._computer.CPUNumber = computerInfoString.Split(_DELIMETER)[11];
                        this._computer.CPUSpeed = computerInfoString.Split(_DELIMETER)[12];
                        this._computer.HDD = computerInfoString.Split(_DELIMETER)[13];
                        this._computer.GPUType = computerInfoString.Split(_DELIMETER)[14];
                        this._computer.WebcamType = computerInfoString.Split(_DELIMETER)[15];
                        

                        txtProductID.Text = this._computer.ProductID;
                        txtCondition.Text = this._computer.Condition;
                        txtCost.Text = this._computer.Cost;
                        txtPlatform.Text = this._computer.Platform;
                        txtOS.Text = this._computer.OS;
                        txtManufacture.Text = this._computer.Manufacture;
                        txtModel.Text = this._computer.Model;
                        txtMemory.Text = this._computer.Memory;
                        txtCPUBrand.Text = this._computer.CPUBrand;
                        txtCPUType.Text = this._computer.CPUType;
                        txtLCDSize.Text = this._computer.LCDSize;
                        txtCPUNumber.Text = this._computer.CPUNumber;
                        txtCPUSpeed.Text = this._computer.CPUSpeed;
                        txtHDD.Text = this._computer.HDD;
                        txtGPUType.Text = this._computer.GPUType;
                        txtWebCam.Text = this._computer.WebcamType;
                    }
                    else
                    {
                        MessageBox.Show("File Empty - No data to Read", "Error Reading File",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    this._reader.Close();
                }
                catch (Exception exception)
                {

                    Debug.WriteLine(exception.Message);
                    MessageBox.Show("Error  Reading File", "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result;

            string filename;



           saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            saveFileDialog1.FileName = "person.txt";

            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            result = saveFileDialog1.ShowDialog();



            if (result == DialogResult.OK)
            {

                filename = saveFileDialog1.FileName;

                try

                {

                    this._writer = new StreamWriter(filename, true);

                    this._writer.Write(txtProductID.Text);
                    this._writer.Write(_DELIMETER);
                    this._writer.WriteLine(txtCondition.Text);
                    this._writer.Write(_DELIMETER);
                    this._writer.WriteLine(txtCost.Text);
                    this._writer.Write(_DELIMETER);
                    this._writer.WriteLine(txtPlatform.Text);
                    this._writer.Write(_DELIMETER);
                    this._writer.WriteLine(txtOS.Text);
                    this._writer.Write(_DELIMETER);
                    this._writer.WriteLine(txtManufacture.Text);
                    this._writer.Write(_DELIMETER);
                    this._writer.WriteLine(txtModel.Text);
                    this._writer.Write(_DELIMETER);
                    this._writer.WriteLine(txtMemory.Text);
                    this._writer.Write(_DELIMETER);
                    this._writer.WriteLine(txtCPUBrand.Text);
                    this._writer.Write(_DELIMETER);
                    this._writer.WriteLine(txtCPUType.Text);
                    this._writer.Write(_DELIMETER);
                    this._writer.WriteLine(txtLCDSize.Text);
                    this._writer.Write(_DELIMETER);
                    this._writer.WriteLine(txtCPUSpeed.Text);
                    this._writer.Write(_DELIMETER);
                    this._writer.WriteLine(txtCPUNumber.Text);
                    this._writer.Write(_DELIMETER);
                    this._writer.WriteLine(txtHDD.Text);
                    this._writer.Write(_DELIMETER);
                    this._writer.WriteLine(txtGPUType.Text);
                    this._writer.Write(_DELIMETER);
                    this._writer.WriteLine(txtWebCam.Text);

                    this._writer.Close(); 

                    MessageBox.Show("File Written Successfully", "File Status",

                        MessageBoxButtons.OK, MessageBoxIcon.Information);



                    txtProductID.Clear();
                    txtCondition.Clear();
                    txtCost.Clear();
                    txtPlatform.Clear();
                    txtOS.Clear();
                    txtManufacture.Clear();
                    txtModel.Clear();
                    txtMemory.Clear();
                    txtCPUBrand.Clear();
                    txtCPUType.Clear();
                    txtLCDSize.Clear();
                    txtCPUSpeed.Clear();
                    txtCPUNumber.Clear();
                    txtHDD.Clear();
                    txtGPUType.Clear();
                    txtWebCam.Clear();


                    txtProductID.Focus();

                }

                catch (Exception exception)

                {



                    Debug.WriteLine(exception.Message);

                    MessageBox.Show("Error  Writing File", "File Error",

                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result;
            string filename;

            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;


                string computerInfoString = "";

                try
                {
                    this._reader = new StreamReader(filename);

                    if (this._reader.Peek() != -1)
                    {
                        computerInfoString = this._reader.ReadLine();

                        this._computer.ProductID = computerInfoString.Split(_DELIMETER)[0];
                        this._computer.Condition = computerInfoString.Split(_DELIMETER)[1];
                        this._computer.Cost = computerInfoString.Split(_DELIMETER)[2];
                        this._computer.Platform = computerInfoString.Split(_DELIMETER)[3];
                        this._computer.OS = computerInfoString.Split(_DELIMETER)[4];
                        this._computer.Manufacture = computerInfoString.Split(_DELIMETER)[5];
                        this._computer.Model = computerInfoString.Split(_DELIMETER)[6];
                        this._computer.Memory = computerInfoString.Split(_DELIMETER)[7];
                        this._computer.CPUBrand = computerInfoString.Split(_DELIMETER)[8];
                        this._computer.CPUType = computerInfoString.Split(_DELIMETER)[9];
                        this._computer.LCDSize = computerInfoString.Split(_DELIMETER)[10];
                        this._computer.CPUNumber = computerInfoString.Split(_DELIMETER)[11];
                        this._computer.CPUSpeed = computerInfoString.Split(_DELIMETER)[12];
                        this._computer.HDD = computerInfoString.Split(_DELIMETER)[13];
                        this._computer.GPUType = computerInfoString.Split(_DELIMETER)[14];
                        this._computer.WebcamType = computerInfoString.Split(_DELIMETER)[15];


                        txtProductID.Text = this._computer.ProductID;
                        txtCondition.Text = this._computer.Condition;
                        txtCost.Text = this._computer.Cost;
                        txtPlatform.Text = this._computer.Platform;
                        txtOS.Text = this._computer.OS;
                        txtManufacture.Text = this._computer.Manufacture;
                        txtModel.Text = this._computer.Model;
                        txtMemory.Text = this._computer.Memory;
                        txtCPUBrand.Text = this._computer.CPUBrand;
                        txtCPUType.Text = this._computer.CPUType;
                        txtLCDSize.Text = this._computer.LCDSize;
                        txtCPUNumber.Text = this._computer.CPUNumber;
                        txtCPUSpeed.Text = this._computer.CPUSpeed;
                        txtHDD.Text = this._computer.HDD;
                        txtGPUType.Text = this._computer.GPUType;
                        txtWebCam.Text = this._computer.WebcamType;
                    }
                    else
                    {
                        MessageBox.Show("File Empty - No data to Read", "Error Reading File",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    this._reader.Close();
                }
                catch (Exception exception)
                {

                    Debug.WriteLine(exception.Message);
                    MessageBox.Show("Error  Reading File", "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Program.MySelectForm.Show();
        }
    }
}
