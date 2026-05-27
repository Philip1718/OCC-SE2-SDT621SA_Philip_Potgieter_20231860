using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SDT621_Section_C_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // This is to add a Mobile to the list
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtCode.Text == "")
            {
                MessageBox.Show("Please enter the mobile code");
                return;
            }


            if (txtMake.Text == "")
            {
                MessageBox.Show("Please enter in the make.");
                return;
            }

            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Please enter in the quantity");
                return;
            }


            double code = double.Parse(txtCode.Text);
            double qty = double.Parse(txtQuantity.Text);
            string make = txtMake.Text;
            

            if (qty < 0)
            {
                MessageBox.Show("Quantity cannot be negative.");
                return;
            }


            string mobileData = "Mobile Code: " + code + "  Make:" + make + " - Quantity:" + qty.ToString("N2");
            tblMobilePhones.Items.Add(mobileData);

            // CLEAN UP
            lblOutput.Text = "Mobile added Successfully!";
            txtCode.Clear();
            txtMake.Clear();
            txtQuantity.Clear();

        }

        // This is to Delete a mobile

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (tblMobilePhones.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Mobile to remove");
                return;
            }

            tblMobilePhones.Items.Remove(tblMobilePhones.SelectedItem);
            lblOutput.Text = "Mobile has been removed";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // VALIDATION: Check if search field is empty
            if (txtCode.Text == "")
            {
                MessageBox.Show("Please enter in the Mobile Code");
                return;
            }

            string searchName = txtCode.Text;
            bool found = false;

            // LOOP through the ListBox to find the name
            for (int i = 0; i < tblMobilePhones.Items.Count; i++)
            {
                if (tblMobilePhones.Items[i].ToString().Contains(searchName))
                {
                    found = true;
                    break;
                }
            }

            // SHOW RESULT
            if (found == true)
            {
                lblOutput.Text = "Mobile has been found in the system!";
            }
            else
            {
                lblOutput.Text = "No Mobile has been found.";
            }
        }
    }
}

