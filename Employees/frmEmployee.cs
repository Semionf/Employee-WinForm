using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private bool checkID(string ID)
        {
            long result = 0, sum = 0;
            if (!long.TryParse(ID, out result)) { return false; }
            for (int i = 0; i < ID.Length-1; i++)
            {
                int num = (i % 2 + 1) * (Convert.ToInt32(ID[i].ToString()));
                sum +=  num/10 + num%10;
            }
            return (sum + int.Parse(ID[ID.Length - 1].ToString())) % 10 == 0 ;
        }

        public string status
        {
            get
            {
                foreach (Control ctr in pStatus.Controls)
                {
                    if(ctr is RadioButton)
                    {
                        if (((RadioButton)ctr).Checked) return ctr.Text;
                    }
                   
                }
                return "";
            }
            set 
            {
                foreach (Control ctr in pStatus.Controls)
                {
                    if (ctr is RadioButton && ctr.Text == value) 
                        ((RadioButton)ctr).Checked = true;
                }
            }
        }
        private void ResetAllControls(Control control)
        {
            if (control == null) return;
            foreach (Control ctr in control.Controls)
            {
                if (ctr is TextBox) ctr.Text = "";
                else if (ctr is RadioButton) ((RadioButton)ctr).Checked = false;
                else if (ctr is Panel) ResetAllControls(ctr);
                else if (ctr is DateTimePicker) ((DateTimePicker)ctr).Value = DateTime.Now.AddYears(-18);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            lbl_InvalidID.Visible = false;
            if (!checkID(txtID.Text))
            {
                lbl_InvalidID.Visible= true;
                txtID.Focus();
            }
                
            else return;
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            if(radioMale.Checked)
            {
                radioSingle.Text = "רווק";
                radioMerried.Text = "נשוי";
                radioDevorsed.Text = "גרוש";
                radiowidower.Text = "אלמן";
            }
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFemale.Checked)
            {
                radioSingle.Text = "רווקה";
                radioMerried.Text = "נשואה";
                radioDevorsed.Text = "גרושה";
                radiowidower.Text = "אלמנה";
            }
        }
    }
}

