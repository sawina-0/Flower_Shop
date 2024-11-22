using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flower_Shop
{
    public partial class AddDataType : Form
    {
        DB dB = new DB();
        public AddDataType()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BTSaveData_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            var AddType = TBAddType.Text;
            SqlCommand cmd = new SqlCommand("select * from Flower_Type where Flower_Name='" + TBAddType.Text + "'", dB.GetSqlConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                MessageBox.Show("Type already exist  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dr.Close();
                var AddQuery = $"insert into Flower_Type (Flower_Name) values ('{AddType}')";
                var command = new SqlCommand(AddQuery, dB.GetSqlConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Data is add", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            dB.closeConnection();
        }
    }
}
