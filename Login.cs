using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Librart_Management_System
{
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\admin lenovo\Documents\LibraryDB.mdf;Integrated Security=True;Connect Timeout=30");
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
             SqlDataAdapter sqlData = new SqlDataAdapter("select * from User_Info where User_ID = '"+Login_UserName_Label.Text+"' and User_Password= '"+Login_Password_Label.Text+"'", connection);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
                if (dataTable.Rows.Count==1)
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
