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
    public partial class TabSysUs : Form
    {
        DB dB = new DB();
        int SelectedRow;
        public TabSysUs()
        {
            InitializeComponent();
        }

        private void BTToAdForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm admin = new AdminForm();
            admin.ShowDialog();
        }
        private void CreateColumns()
        {
            dataGridViewUs.Columns.Add("ID_Users", "id");
            dataGridViewUs.Columns.Add("Login", "Login");
            dataGridViewUs.Columns.Add("Password", "Password");
            dataGridViewUs.Columns.Add("ID_Role", "Role name");
            dataGridViewUs.Columns.Add("IsNew", String.Empty);

        }
        private void ClearFields()
        {
            TBIDUs.Text = "";
            TBLogUs.Text = "";
            TBPasswdUs.Text = "";
            TBRole.Text = "";
            CBFilter.Text = "";
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgv)
        {

            dB.openConnection();
            dgv.Rows.Clear();

            string QueryString = $"select System_Users.ID_Users, System_Users.Login, System_Users.Password, Role.Role_Name from System_Users join Role ON System_Users.ID_Role = Role.ID_Role";
            SqlCommand cmd = new SqlCommand(QueryString, dB.GetSqlConnection());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
            dB.closeConnection();
        }
        private void CreateFilter()
        {
            CBFilter.Items.Clear();
            HashSet<string> uniqueValues = new HashSet<string>();
            foreach (DataGridViewRow row in dataGridViewUs.Rows)
            {
                string value = row.Cells[3].Value.ToString();
                if (!uniqueValues.Contains(value))
                {
                    CBFilter.Items.Add(value);
                    uniqueValues.Add(value);
                }
            }
        }

        private void TabSysUs_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewUs);
            dataGridViewUs.Columns[4].Visible = false;
            CreateFilter();
        }

        private void dataGridViewUs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUs.Rows[SelectedRow];

                TBIDUs.Text = row.Cells[0].Value.ToString();
                TBLogUs.Text = row.Cells[1].Value.ToString();
                TBPasswdUs.Text = row.Cells[2].Value.ToString();
                TBRole.Text = row.Cells[3].Value.ToString();

            }
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewUs);
            ClearFields();
            CreateFilter();
        }

        private void BTAddData_Click(object sender, EventArgs e)
        {
            AddDataUs AddDataUs = new AddDataUs();
            AddDataUs.Show();
        }
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string SearchString = $"select System_Users.ID_Users, System_Users.Login, System_Users.Password, Role.Role_Name from System_Users join Role ON System_Users.ID_Role = Role.ID_Role where concat (System_Users.ID_Users, System_Users.Login, System_Users.Password, Role.Role_Name) like '%" + TBSearch.Text + "%'";
            SqlCommand com = new SqlCommand(SearchString, dB.GetSqlConnection());
            dB.openConnection();
            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgv, read);
            }
            read.Close();
            dB.closeConnection();
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridViewUs);
        }
        private void DeleteRow()
        {
            int index = dataGridViewUs.CurrentCell.RowIndex;

            dataGridViewUs.Rows[index].Visible = false;

            if (dataGridViewUs.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewUs.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }
            dataGridViewUs.Rows[index].Cells[4].Value = RowState.Deleted;
        }
        private void Update()
        {
            dB.openConnection();

            for (int index = 0; index < dataGridViewUs.Rows.Count; index++)
            {
                var RowState = (RowState)dataGridViewUs.Rows[index].Cells[4].Value;
                if (RowState == RowState.Existed)
                {
                    continue;
                }
                if (RowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridViewUs.Rows[index].Cells[0].Value);
                    var DeleteQuery = $"delete from System_Users where ID_Users = {id}";

                    var command = new SqlCommand(DeleteQuery, dB.GetSqlConnection());
                    command.ExecuteNonQuery();
                }
                if (RowState == RowState.Modified)
                {
                    var Id = dataGridViewUs.Rows[index].Cells[0].Value.ToString();
                    var Login = dataGridViewUs.Rows[index].Cells[1].Value.ToString();
                    var Password = dataGridViewUs.Rows[index].Cells[2].Value.ToString();
                    var Role = dataGridViewUs.Rows[index].Cells[3].Value.ToString();
                    int IdRole = GetRoleIdFromName(Role);
                    SqlCommand cmd = new SqlCommand("select * from System_Users where Login='" + Login + "' and ID_Users != '"+Id+"'", dB.GetSqlConnection());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (IdRole == -1 || dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Login already exist or  Role '" + Role + "' not found in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close() ;
                        var ChangeQuery = $"update System_Users set Login = '{Login}', Password = '{Password}', ID_Role = '{IdRole}' where ID_Users = '{Id}'";
                        var command = new SqlCommand(ChangeQuery, dB.GetSqlConnection());
                        command.ExecuteNonQuery();
                    }
                }
            }
            dB.closeConnection();
        }
        private int GetRoleIdFromName(string roleName)
        {
            string query = $"SELECT ID_Role FROM Role WHERE Role_Name = '{roleName}'";
            SqlCommand command = new SqlCommand(query, dB.GetSqlConnection());
            SqlDataReader reader = command.ExecuteReader();
            try 
            {
                if (reader.Read())
                {
                    return reader.GetInt32(0);

                }
                else
                {
                    
                    return -1;
                }
            }
            finally 
            {
                reader.Close();
            }
            
        }
        private void Change()
        {
            var SelectedRowIndex = dataGridViewUs.CurrentCell.RowIndex;
            var Id = TBIDUs.Text;
            var Login = TBLogUs.Text;
            var Pswd = TBPasswdUs.Text;
            var Role = TBRole.Text;
            if (TBIDUs.Text != string.Empty && TBLogUs.Text != string.Empty && TBPasswdUs.Text != string.Empty && TBRole.Text != string.Empty)
            {
                dataGridViewUs.Rows[SelectedRowIndex].SetValues(Id, Login, Pswd, Role);
                dataGridViewUs.Rows[SelectedRowIndex].Cells[4].Value = RowState.Modified;
            }
        }
        private void BTModify_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void BTDeleteData_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void BTSaveData_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void BTClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BTSortAsc_Click(object sender, EventArgs e)
        {
            dataGridViewUs.Sort(dataGridViewUs.Columns[1], ListSortDirection.Ascending);
        }

        private void BTSortDesc_Click(object sender, EventArgs e)
        {
            dataGridViewUs.Sort(dataGridViewUs.Columns[1], ListSortDirection.Descending);
        }
        private void Filter(DataGridView dgv)
        {
            dgv.Rows.Clear();
            var SearchString = $"select System_Users.ID_Users, System_Users.Login, System_Users.Password, Role.Role_Name from System_Users join Role ON System_Users.ID_Role = Role.ID_Role where System_Users.ID_Role = (select Role.ID_Role from Role where Role_Name = '" + CBFilter.Text + "')";
            SqlCommand com = new SqlCommand(SearchString, dB.GetSqlConnection());
            dB.openConnection();
            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgv, read);
            }
            read.Close();
            dB.closeConnection();
        }

        private void CBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter(dataGridViewUs);
        }

        private void BTClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BTModify_Click_1(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }
    }
}
