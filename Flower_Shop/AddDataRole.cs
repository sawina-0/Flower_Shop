using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flower_Shop
{
    public partial class AddDataRole : Form
    {
        DB dB = new DB();
        public AddDataRole()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BTSaveData_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            var AddRole = TBAddRole.Text;
            SqlCommand cmd = new SqlCommand("select * from Role where Role_Name='" + TBAddRole.Text + "'", dB.GetSqlConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (TBAddRole.Text != string.Empty)
            {
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Role already exist  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    var AddQuery = $"insert into Role (Role_Name) values ('{AddRole}')";
                    var command = new SqlCommand(AddQuery, dB.GetSqlConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data is add", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                dr.Close();
                MessageBox.Show("enter the value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            dB.closeConnection();
        }
    }
}
