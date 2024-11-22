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
    public partial class AddDataSize : Form
    {
        DB dB = new DB();
        public AddDataSize()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BTSaveData_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            var AddSize = TBAddSize.Text;
            SqlCommand cmd = new SqlCommand("select * from Blossom_Size where Size='" + TBAddSize.Text + "'", dB.GetSqlConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                MessageBox.Show("Size already exist  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dr.Close();
                var AddQuery = $"insert into Blossom_size (Size) values ('{AddSize}')";
                var command = new SqlCommand(AddQuery, dB.GetSqlConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Data is add", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            dB.closeConnection();
        }
    }
}
