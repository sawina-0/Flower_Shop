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
    public partial class AddDataSalePoints : Form
    {
        DB dB = new DB();
        public AddDataSalePoints()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BTSaveData_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            var AddAddr = TBAddShopAddr.Text;
            var AddStorehouse = TBAddStorehouse.Text;
            SqlCommand cmd = new SqlCommand("select * from Sale_Point where Shop_Address ='" + TBAddShopAddr.Text + "'", dB.GetSqlConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (TBAddShopAddr.Text != string.Empty && TBAddStorehouse.Text != string.Empty)
            {
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Address already exist  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    SqlCommand com = new SqlCommand("select * from Storehouse where Storehouse_Name ='" + TBAddStorehouse.Text + "'", dB.GetSqlConnection());
                    SqlDataReader read = com.ExecuteReader();
                    if (read.Read())
                    {
                        read.Close();
                        var AddQuery1 = $"insert into Sale_Point (Shop_Address, ID_Storehouse) values ('{AddAddr}', (select ID_Storehouse from Storehouse where Storehouse_Name = '{AddStorehouse}'))";
                        var command = new SqlCommand(AddQuery1, dB.GetSqlConnection());
                        command.ExecuteNonQuery();

                        MessageBox.Show("Data is add", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        read.Close();
                        MessageBox.Show("there is no such storehouse in the database, add it first to use in the future", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

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

