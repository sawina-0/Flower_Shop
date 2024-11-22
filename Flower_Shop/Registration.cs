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
using System.Data.SqlClient;

namespace Flower_Shop
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void BTHaveAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeWin login = new WelcomeWin();
            login.ShowDialog();
        }

        private void BTReg_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.openConnection();
            int idRoleReg = 1;
            
                if (TBLogReg.Text != string.Empty && TBPswdReg.Text != string.Empty && TBPswdAgainReg.Text != string.Empty)
                {
                    if (TBPswdReg.Text == TBPswdAgainReg.Text)
                    {
                        SqlCommand cmd = new SqlCommand("select * from System_Users where Login='" + TBLogReg.Text + "'", dB.GetSqlConnection());
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            cmd = new SqlCommand("insert into System_Users values(@Login,@Password,@ID_Role)", dB.GetSqlConnection());
                            cmd.Parameters.AddWithValue("Login", TBLogReg.Text);
                            cmd.Parameters.AddWithValue("Password", TBPswdReg.Text);
                            cmd.Parameters.AddWithValue("ID_Role", idRoleReg);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            dB.closeConnection();
        }

        
    }
}
