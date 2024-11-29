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
    //enum RowStateRole
    //{
    //    Existed,
    //    New,
    //    Modified,
    //    ModifiedNew,
    //    Deleted
    //}
    public partial class TabRoles : Form
    {
        DB dB = new DB();
        int SelectedRow;
        public TabRoles()
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
            dataGridViewRole.Columns.Add("ID_Role", "id");
            dataGridViewRole.Columns.Add("Role_Name", "Role");
            dataGridViewRole.Columns.Add("IsNew", String.Empty);

        }
        private void ClearFields()
        {
            TBIDRole.Text = "";
            TBRole.Text = "";
        }
        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv)
        {

            dB.openConnection();
            dgv.Rows.Clear();

            string QueryString = $"select * from  Role";
            SqlCommand cmd = new SqlCommand(QueryString, dB.GetSqlConnection());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
            dB.closeConnection();
        }
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string SearchString = $"select * from Role where concat (id_role, role_name) like '%" + TBSearch.Text + "%'";
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

        private void BTClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void TabRoles_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewRole);
            dataGridViewRole.Columns[2].Visible = false;
        }

        private void dataGridViewRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewRole.Rows[SelectedRow];

                TBIDRole.Text = row.Cells[0].Value.ToString();
                TBRole.Text = row.Cells[1].Value.ToString();
            }
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewRole);
            ClearFields();
        }

        private void BTAddData_Click(object sender, EventArgs e)
        {
            AddDataRole AddRole = new AddDataRole();
            AddRole.Show();
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridViewRole);
        }
        private void DeleteRow()
        {
            int index = dataGridViewRole.CurrentCell.RowIndex;

            dataGridViewRole.Rows[index].Visible = false;

            if (dataGridViewRole.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewRole.Rows[index].Cells[2].Value = RowState.Deleted;
                return;
            }
            dataGridViewRole.Rows[index].Cells[2].Value = RowState.Deleted;
        }
        private void Update()
        {
            dB.openConnection();

            for (int index = 0; index < dataGridViewRole.Rows.Count; index++)
            {
                var RowState = (RowState)dataGridViewRole.Rows[index].Cells[2].Value;
                if (RowState == RowState.Existed)
                {
                    continue;
                }
                if (RowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridViewRole.Rows[index].Cells[0].Value);
                    var DeleteQuery = $"delete from Role where ID_Role = {id}";

                    var command = new SqlCommand(DeleteQuery, dB.GetSqlConnection());
                    command.ExecuteNonQuery();
                }
                if (RowState == RowState.Modified)
                {
                    var Id = dataGridViewRole.Rows[index].Cells[0].Value.ToString();
                    var Role = dataGridViewRole.Rows[index].Cells[1].Value.ToString();

                    var ChangeQuery = $"update Role set Role_Name = '{Role}' where ID_Role = '{Id}'";
                    var command = new SqlCommand(ChangeQuery, dB.GetSqlConnection());
                    command.ExecuteNonQuery();
                }
            }
            dB.closeConnection();
        }

        private void BTDeleteData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deleting data will cause deletion in the linked table", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                DeleteRow();
                ClearFields();
            }
        }

        private void BTSaveData_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void Change()
        {
            var SelectedRowIndex = dataGridViewRole.CurrentCell.RowIndex;
            var Id = TBIDRole.Text;
            var Role = TBRole.Text;
            if (TBIDRole.Text != string.Empty && TBRole.Text != string.Empty)
            {
                dataGridViewRole.Rows[SelectedRowIndex].SetValues(Id, Role);
                dataGridViewRole.Rows[SelectedRowIndex].Cells[2].Value = RowState.Modified;
            }
        }

        private void BTModify_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void BTSortAsc_Click(object sender, EventArgs e)
        {
            dataGridViewRole.Sort(dataGridViewRole.Columns[1], ListSortDirection.Ascending);
        }

        private void BTSortDesc_Click(object sender, EventArgs e)
        {
            dataGridViewRole.Sort(dataGridViewRole.Columns[1], ListSortDirection.Descending);
        }
    }
}
