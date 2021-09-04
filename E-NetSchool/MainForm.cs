using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dropdowndoc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'country_DataDataSet.Countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.country_DataDataSet.Countries);
            // TODO: This line of code loads data into the 'country_DataDataSet.Cities' table. You can move, or remove it, as needed.
            //  this.citiesTableAdapter.Fill(this.country_DataDataSet.Cities);
       
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void chipControl_CloseIconClicked(object sender, EventArgs args)
        {
            ChipControl chipControl = (ChipControl)sender;
            flowLayoutPanel2.Controls.Remove(chipControl);
        }

        private void fillByCountryNameToolStripButton_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    this.citiesTableAdapter.FillByCountryName(this.country_DataDataSet.Cities, new System.Nullable<int>(((int)(System.Convert.ChangeType(param1ToolStripTextBox.Text, typeof(int))))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bunifuDropdown1.ForeColor = Color.FromArgb(64,64,64);
            if (bunifuDropdown1.SelectedValue.ToString()=="1") {
                country_DataDataSet.Cities.Clear();
                //MessageBox.Show(bunifuDropdown1.SelectedValue.ToString());
                citiesTableAdapter.FillByCountryName(country_DataDataSet.Cities, 1);
                bunifuDropdown2.Text = "Select City";
                bunifuDropdown2.ForeColor = Color.DarkGray;
            }
            else
            {
                
               // MessageBox.Show(bunifuDropdown1.SelectedValue.ToString());
                country_DataDataSet.Cities.Clear();
                citiesTableAdapter.FillByCountryName(country_DataDataSet.Cities, 2);
                bunifuDropdown2.Text = "Select City";
                bunifuDropdown2.ForeColor = Color.DarkGray;
            }
        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            bunifuDropdown2.ForeColor = Color.FromArgb(64,64,64);
        }

        private void bunifuDropdown4_SelectedIndexChanged(object sender, EventArgs e)
        {
            bunifuDropdown4.ForeColor = Color.FromArgb(64, 64, 64); 
            ChipControl chipControl = new ChipControl();
            chipControl.DepartmentName = bunifuDropdown4.SelectedItem.ToString();
        
            chipControl.DepartmentNameSetEvent += ChipControl_DepartmentNameSetEvent;
            chipControl.CloseIconClicked += ChipControl_CloseIconClicked;
            flowLayoutPanel2.Controls.Add(chipControl);
        }

        private void ChipControl_CloseIconClicked(object sender, EventArgs args)
        {
            ChipControl chipControl = (ChipControl)sender;
            flowLayoutPanel2.Controls.Remove(chipControl);
;        }

        private void ChipControl_DepartmentNameSetEvent(object sender, ChipControl.DepartmentArgs departmentArgs)
        {
            ChipControl chipControl = (ChipControl)sender;
            MessageBox.Show(departmentArgs.Dname);
            chipControl.departmentBunifuLabel.Text = departmentArgs.Dname;
        }

        private void chipControl1_DepartmentNameSetEvent(object sender, ChipControl.DepartmentArgs departmentArgs)
        {
            MessageBox.Show(departmentArgs.Dname);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
