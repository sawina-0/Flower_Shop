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
using System.Security.AccessControl;

namespace Flower_Shop
{
    public partial class AddDataStorehouse : Form
    {
        DB dB = new DB();
        public AddDataStorehouse()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BTSaveData_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            var AddStName = TBAddStName.Text;
            var AddAddress = TBAddAddr.Text;
            SqlCommand cmd = new SqlCommand("select * from Storehouse where Storehouse_Name='" + TBAddStName.Text + "' or Storehouse_Address = '" + TBAddAddr.Text + "'", dB.GetSqlConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (TBAddStName.Text != string.Empty && TBAddAddr.Text != string.Empty)
            {
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Storehouse name or address already exist  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    var AddQuery = $"insert into Storehouse (Storehouse_Name, Storehouse_Address) values ('{AddStName}','{AddAddress}')";
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
