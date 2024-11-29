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
    public partial class TabType : Form
    {
        DB dB = new DB();
        int SelectedRow;
        public TabType()
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
            dataGridViewType.Columns.Add("ID_Type", "id");
            dataGridViewType.Columns.Add("Flower_Name", "Type of flower");
            dataGridViewType.Columns.Add("IsNew", String.Empty);

        }
        private void ClearFields()
        {
            TBIDType.Text = "";
            TBType.Text = "";
        }
        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv)
        {

            dB.openConnection();
            dgv.Rows.Clear();

            string QueryString = $"select * from  Flower_Type";
            SqlCommand cmd = new SqlCommand(QueryString, dB.GetSqlConnection());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
            dB.closeConnection();
        }

        private void TabType_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewType);
            dataGridViewType.Columns[2].Visible = false;
        }

        private void dataGridViewType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewType.Rows[SelectedRow];

                TBIDType.Text = row.Cells[0].Value.ToString();
                TBType.Text = row.Cells[1].Value.ToString();
            }
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewType);
            ClearFields();
        }

        private void BTAddData_Click(object sender, EventArgs e)
        {
            AddDataType AddType = new AddDataType();
            AddType.Show();
        }
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string SearchString = $"select * from flower_type where concat (id_type, flower_name) like '%" + TBSearch.Text + "%'";
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
            Search(dataGridViewType);
        }
        private void DeleteRow()
        {
            int index = dataGridViewType.CurrentCell.RowIndex;

            dataGridViewType.Rows[index].Visible = false;

            if (dataGridViewType.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewType.Rows[index].Cells[2].Value = RowState.Deleted;
                return;
            }
            dataGridViewType.Rows[index].Cells[2].Value = RowState.Deleted;
        }
        private void Update()
        {
            dB.openConnection();

            for (int index = 0; index < dataGridViewType.Rows.Count; index++)
            {
                var RowState = (RowState)dataGridViewType.Rows[index].Cells[2].Value;
                if (RowState == RowState.Existed)
                {
                    continue;
                }
                if (RowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridViewType.Rows[index].Cells[0].Value);
                    var DeleteQuery = $"delete from Flower_Type where ID_Type = {id}";

                    var command = new SqlCommand(DeleteQuery, dB.GetSqlConnection());
                    command.ExecuteNonQuery();
                }
                if (RowState == RowState.Modified)
                {
                    var Id = dataGridViewType.Rows[index].Cells[0].Value.ToString();
                    var Type = dataGridViewType.Rows[index].Cells[1].Value.ToString();

                    var ChangeQuery = $"update Flower_Type set Flower_Name = '{Type}' where ID_Type = '{Id}'";
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
            var SelectedRowIndex = dataGridViewType.CurrentCell.RowIndex;
            var Id = TBIDType.Text;
            var Type = TBType.Text;
            if (TBIDType.Text != string.Empty && TBType.Text != string.Empty)
            {
                dataGridViewType.Rows[SelectedRowIndex].SetValues(Id, Type);
                dataGridViewType.Rows[SelectedRowIndex].Cells[2].Value = RowState.Modified;
            }
        }

        private void BTModify_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void BTClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BTSortAsc_Click(object sender, EventArgs e)
        {
            dataGridViewType.Sort(dataGridViewType.Columns[1], ListSortDirection.Ascending);
        }

        private void BTSortDesc_Click(object sender, EventArgs e)
        {
            dataGridViewType.Sort(dataGridViewType.Columns[1], ListSortDirection.Descending);
        }
    }
}
