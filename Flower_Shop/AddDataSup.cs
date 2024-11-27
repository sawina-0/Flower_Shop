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
    public partial class AddDataSup : Form
    {
        DB dB = new DB();
        public AddDataSup()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BTSaveData_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            var AddComName = TBAddComName.Text;
            var AddCountry = TBAddCountry.Text;
            SqlCommand cmd = new SqlCommand("select * from Supplier where Company_Name='" + TBAddComName.Text + "'", dB.GetSqlConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (TBAddComName.Text != string.Empty && TBAddCountry.Text != string.Empty)
            {
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Company already exist  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    var AddQuery = $"insert into Supplier (Company_Name, Country) values ('{AddComName}','{AddCountry}')";
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
