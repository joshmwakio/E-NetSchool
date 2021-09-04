using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dropdowndoc
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public class Product
        {
            
            private string productName;
            private string productID;

            //class constructor
            public Product(string productName, string productID)
            {
                this.productName = productName;
                this.productID = productID;
            }
            public string ProductName
            {
                get { return productName; }
            }
            public string ProductID
            {
                get { return productID; }
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Buni_EnterpriseDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this._Buni_EnterpriseDataSet1.Orders);
            // TODO: This line of code loads data into the 'medilDataSet.Reports' table. You can move, or remove it, as needed.
            this.reportsTableAdapter.Fill(this.medilDataSet.Reports);
            List<Product> productList = new List<Product>()
            {
                new Product("Dell PowerEdge T40 Server","XC34RT"),
                new Product("HP Proliant MicroServer", "M36PF3"),
                new Product("Dell EMC PowerEdge","LPW12X"),
                new Product("HP Proliant 360","HTW321")
            };
            bunifuDropdown1.DataSource = productList;
            bunifuDropdown1.DisplayMember = "ProductName";
            bunifuDropdown1.ValueMember = "ProductID";
        }

        private void BunifuTextBox1_LostFocus(object sender, EventArgs e)
        {
           // bunifuLabel23.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void BunifuTextBox1_GotFocus(object sender, EventArgs e)
        {
           // bunifuLabel23.ForeColor = Color.FromArgb(133, 10, 214);
        }

        private void bunifuTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
          
           
        }

        private void bunifuTextBox1_ModifiedChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuTextBox1_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "[0-9]";
            Regex regex = new Regex(pattern);
            //if (regex.IsMatch(bunifuTextBox1.Text))
            //{
            //    e.Cancel = true;
            //    //ActiveControl = null;
            //}
            //else
            //{
            //    MessageBox.Show("Must be a Number");
            //}
            //;
        }

        private void greenBunifuRadioButton_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.ItemBorderColor = Color.FromArgb(55, 169, 120);
                bunifuDropdown2.ItemBorderColor = Color.FromArgb(55, 169, 120); 
            }
        }

        private void dbBunifuRadioButton_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.ItemBorderColor = Color.FromArgb(34, 87, 122);
                bunifuDropdown2.ItemBorderColor = Color.FromArgb(34, 87, 122);
            }
        }

        private void blueBunifuRadioButton6_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.ItemBorderColor = Color.FromArgb(67, 97, 238);
                bunifuDropdown2.ItemBorderColor = Color.FromArgb(67, 97, 238); 
            }
        }

        private void bcBunifuRadioButton_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.ItemBackColor = Color.FromArgb(250, 219, 246);
                bunifuDropdown2.ItemBackColor = Color.FromArgb(250, 219, 246); 
            }
        }

        private void bc2BunifuRadioButton_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.ItemBackColor = Color.FromArgb(223, 237, 246);
                bunifuDropdown2.ItemBackColor = Color.FromArgb(223, 237, 246); 
            }
        }

        private void hGBunifuRadioButton1_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.ItemHighLightColor = Color.FromArgb(181, 23, 158);
                bunifuDropdown2.ItemHighLightColor = Color.FromArgb(181, 23, 158); 
            }
        }

        private void dBbunifuRadioButton2_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.ItemHighLightColor = Color.FromArgb(114, 9, 183);
                bunifuDropdown2.ItemHighLightColor = Color.FromArgb(114, 9, 183); 
            }
        }

        private void HF1bunifuRadioButton7_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.ItemHighLightForeColor = Color.White;
                bunifuDropdown2.ItemHighLightForeColor = Color.White; 
            }
        }

        private void hF2bunifuRadioButton3_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.ItemHighLightForeColor = Color.Black;
                bunifuDropdown2.ItemHighLightForeColor = Color.Black; 
            }
        }

        private void bunifuTextBox1_Validated(object sender, EventArgs e)
        {
          
        }

        private void bunifuTextBox1_Enter(object sender, EventArgs e)
        {
           // this.ActiveControl = null;
        }

        private void bunifuRadioButton3_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.ItemHighLightColor = bunifuDropdown1.ItemBackColor;
                bunifuDropdown2.ItemHighLightColor = bunifuDropdown2.ItemBackColor;
            }
        }

        private void bunifuRadioButton1_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.ItemForeColor = Color.White;
                bunifuDropdown2.ItemForeColor = Color.White; 
            }
        }

        private void bunifuRadioButton2_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.ItemForeColor = Color.Black;
                bunifuDropdown2.ItemForeColor = Color.Black;
            }
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuRadioButton4_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.ItemBackColor= Color.FromArgb(181, 23, 158);
                bunifuDropdown2.ItemBackColor = Color.FromArgb(181, 23, 158);
            }
        }
    }
}
