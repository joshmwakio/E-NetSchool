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

    public partial class ChipControl : UserControl
    {
        public class DepartmentArgs : EventArgs
        {
            public string Dname { get; set; }
            public DepartmentArgs(string departmentName="iii")
            {
                Dname = departmentName;
            }

         
        }
        public delegate void DepartmentNameDelegate(object sender, DepartmentArgs departmentArgs);
        public event DepartmentNameDelegate DepartmentNameSetEvent;
        private string departmentName;
        public delegate void CloseIconDelegate(object sender, EventArgs args);
        public event CloseIconDelegate CloseIconClicked;
        public string DepartmentName
        {
            set { departmentName = value;

                if (departmentName.Length != 0)
                {
                    if (DepartmentNameSetEvent != null)
                    {
                        DepartmentNameSetEvent.Invoke(this, new DepartmentArgs(departmentName));
                    }
                    else
                    {
                        departmentBunifuLabel.Text = departmentName;
                    }
                }
            }
            get
            {
                return departmentName;
            }
        }

        public ChipControl()
        {
            InitializeComponent();
        }

        private void ChipControl_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(departmentName))
            {
                departmentName = "Set the Chip's Text";
            }
            else
            {
                departmentBunifuLabel.Text = departmentName;
            }
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            CloseIconClicked(this, e);
        }

        private void departmentBunifuLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
