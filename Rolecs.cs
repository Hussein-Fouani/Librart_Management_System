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
    public partial class Rolecs : Form
    {
        public Rolecs()
        {
            InitializeComponent();
        }

        private void Rolecs_Load(object sender, EventArgs e)
        {

        }

        private void Update_Button_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void New_Button_Click(object sender, EventArgs e)
        {
            book_id_textbox.Clear();
            bkname_txtbx.Clear();
            status_cmbbx.SelectedItem = -1;
            book_id_textbox.Focus();
        }
        
        void CreateNewData()
        {
            Connection connection = new();

        }

    }
}
