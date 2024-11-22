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
    public partial class AddDataColor : Form
    {
        DB dB = new DB();
        public AddDataColor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BTSaveData_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            var AddColor = TBAddColor.Text;
            SqlCommand cmd = new SqlCommand("select * from Flower_Color where Color='" + TBAddColor.Text + "'", dB.GetSqlConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                MessageBox.Show("Color already exist  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                dr.Close();
                var AddQuery = $"insert into Flower_Color (Color) values ('{AddColor}')";
                var command = new SqlCommand(AddQuery, dB.GetSqlConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Data is add", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            dB.closeConnection();
        }
    }
}
