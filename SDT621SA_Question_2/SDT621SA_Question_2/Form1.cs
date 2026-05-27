using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDT621SA_Question_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            // VALIDATION: Check if client name is empty
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter your name.");
                return;
            }
            else
            {
                MessageBox.Show($"Hello Mnr., {name}");
            }

            txtName.Clear();
            
        }
    }
}
