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

namespace Flower_Shop
{
    public partial class AddDataUs : Form
    {
        DB dB = new DB();
        public AddDataUs()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BTSaveData_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            var AddLog = TBAddLog.Text;
            var AddPswd = TBAddPswd.Text;
            var AddRole = TBAddRole.Text;
            SqlCommand cmd = new SqlCommand("select * from System_Users where Login='" + TBAddLog.Text + "'", dB.GetSqlConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                MessageBox.Show("Login already exist  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dr.Close();
                SqlCommand com = new SqlCommand("select * from Role where Role_Name='" + TBAddRole.Text + "'", dB.GetSqlConnection());
                SqlDataReader read = com.ExecuteReader();
                if (read.Read())
                {
                    read.Close();
                    var AddQuery1 = $"insert into System_Users (Login, Password, ID_Role) values ('{AddLog}','{AddPswd}', (select ID_Role from Role where Role_Name = '{AddRole}'))";
                    var command = new SqlCommand(AddQuery1, dB.GetSqlConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Data is add", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    read.Close();
                    if (MessageBox.Show("this role does not exist in the database, adding data will create a new role", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        var AddQuery2 = $"insert into Role (Role_Name) values ('{AddRole}')";
                        var SqlCom = new SqlCommand(AddQuery2, dB.GetSqlConnection());
                        SqlCom.ExecuteNonQuery();
                        var AddQuery3 = $"insert into System_Users(Login, Password, ID_Role) values ('{AddLog}','{AddPswd}',(select ID_Role from Role where Role_Name='{AddRole}')";
                        var SqlCmd = new SqlCommand(AddQuery3, dB.GetSqlConnection());
                        SqlCmd.ExecuteNonQuery();

                        MessageBox.Show("Data is add", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }

            }
            dB.closeConnection();
        }
    }
}
