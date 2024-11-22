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
    public partial class WelcomeWin : Form
    {
        public WelcomeWin()
        {
            InitializeComponent();
        }

        private void BTCreateAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void BTEnter_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.openConnection();
            if (TBPassword.Text != string.Empty && TBLog.Text != string.Empty)
            {
                SqlCommand sc = new SqlCommand("select * from System_Users where ID_Role = '2' and login='" + TBLog.Text + "' and password='" + TBPassword.Text + "'", dB.GetSqlConnection());
                SqlDataReader RoleChecker = sc.ExecuteReader();
                bool check = RoleChecker.Read();
                RoleChecker.Close();

                SqlCommand cmd = new SqlCommand("select * from System_Users where login='" + TBLog.Text + "' and password='" + TBPassword.Text + "'", dB.GetSqlConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                if (check == true)
                {
                    dr.Close();
                    this.Hide();
                    AdminForm admin = new AdminForm();
                    admin.ShowDialog();
                }
                else if(dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Catalog ware = new Catalog();
                    ware.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account available with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
