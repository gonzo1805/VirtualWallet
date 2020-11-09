using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualWallet
{
    public partial class CreateAccount : Form
    {
        private Controller controller;

        internal Controller Controller { get => controller; set => controller = value; }

        public CreateAccount()
        {
            InitializeComponent();
            
            txtName.ForeColor = Color.Gray;
            txtName.Text = "Enter the account name";

            txtAmount.ForeColor = Color.Gray;
            txtAmount.Text = "123456789.12";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Enter the account name")
            {
                txtName.Text = "";
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Enter the account name";
                txtName.ForeColor = Color.Gray;
            } else if (Utilities.ContainsSpecialCharacters(txtName.Text)) 
            {

            }
        }

        private void txtAmount_Enter(object sender, EventArgs e)
        {
            if (txtAmount.Text == "123456789.12")
            {
                txtAmount.Text = "";
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                txtAmount.Text = "123456789.12";
                txtAmount.ForeColor = Color.Gray;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.TextLength > 0)
            {

            }
        }
    }
}
