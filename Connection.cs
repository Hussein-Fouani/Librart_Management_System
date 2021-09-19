using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Librart_Management_System
{
    public class Connection
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\admin lenovo\Documents\LibraryDB.mdf;Integrated Security=True;Connect Timeout=30");

        public SqlConnection ActiveConection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            return connect;
        }
    }
}
