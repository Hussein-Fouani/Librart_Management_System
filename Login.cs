using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librart_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Log_button_Click(object sender, EventArgs e)
        {
            if (Log_UserName_TextBox.Text == "Admin" && Log_Password_TextBox.Text=="Password")
            {
                LibraryMS library = new LibraryMS();
                this.Hide();
                library.Show();

            }
            else
            {
                MessageBox.Show("Invalid Login Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
