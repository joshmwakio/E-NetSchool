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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void purpleBunifuRadioButton_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.BorderColor = Color.FromArgb(114, 9, 183);
                bunifuDropdown2.BorderColor = Color.FromArgb(114, 9, 183); 
            }
        }

        private void pinkBunifuRadioButton_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.BorderColor = Color.FromArgb(247, 37, 133);
                bunifuDropdown2.BorderColor = Color.FromArgb(247, 37, 133); 
            }
        }

        private void blueBunifuRadioButton_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.BorderColor = Color.FromArgb(67, 97, 238);
                bunifuDropdown2.BorderColor = Color.FromArgb(67, 97, 238); 
            }
        }

        private void thickBunifuRadioButton_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
                bunifuDropdown2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            }
        }

        private void thinBunifuRadioButton_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
                bunifuDropdown2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            }
        }

        private void radBunifuVSlider_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
        {
            bunifuDropdown1.BorderRadius = radBunifuVSlider.Value;
            bunifuDropdown2.BorderRadius = radBunifuVSlider.Value;
            bunifuRadialGauge.Value = radBunifuVSlider.Value;
        }
    }
}
