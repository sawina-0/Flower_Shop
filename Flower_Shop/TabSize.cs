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
    public partial class TabSize : Form
    {
        DB dB = new DB();
        int SelectedRow;
        public TabSize()
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
            dataGridViewSize.Columns.Add("ID_Size", "id");
            dataGridViewSize.Columns.Add("Size", "Size");
            dataGridViewSize.Columns.Add("IsNew", String.Empty);

        }
        private void ClearFields()
        {
            TBIDSize.Text = "";
            TBSize.Text = "";
        }
        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv)
        {

            dB.openConnection();
            dgv.Rows.Clear();

            string QueryString = $"select * from Blossom_Size";
            SqlCommand cmd = new SqlCommand(QueryString, dB.GetSqlConnection());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
            dB.closeConnection();
        }

        private void TabSize_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewSize);
            dataGridViewSize.Columns[2].Visible = false;
        }

        private void dataGridViewSize_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSize.Rows[SelectedRow];

                TBIDSize.Text = row.Cells[0].Value.ToString();
                TBSize.Text = row.Cells[1].Value.ToString();
            }
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewSize);
            ClearFields();
        }

        private void BTAddData_Click(object sender, EventArgs e)
        {
            AddDataSize AddData = new AddDataSize();
            AddData.Show();
        }
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string SearchString = $"select * from Blossom_Size where concat (id_size, size) like '%" + TBSearch.Text + "%'";
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
            Search(dataGridViewSize);
        }
        private void DeleteRow()
        {
            int index = dataGridViewSize.CurrentCell.RowIndex;

            dataGridViewSize.Rows[index].Visible = false;

            if (dataGridViewSize.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewSize.Rows[index].Cells[2].Value = RowState.Deleted;
                return;
            }
            dataGridViewSize.Rows[index].Cells[2].Value = RowState.Deleted;
        }
        private void Update()
        {
            dB.openConnection();

            for (int index = 0; index < dataGridViewSize.Rows.Count; index++)
            {
                var RowState = (RowState)dataGridViewSize.Rows[index].Cells[2].Value;
                if (RowState == RowState.Existed)
                {
                    continue;
                }
                if (RowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridViewSize.Rows[index].Cells[0].Value);
                    var DeleteQuery = $"delete from Blossom_Size where ID_Size = {id}";

                    var command = new SqlCommand(DeleteQuery, dB.GetSqlConnection());
                    command.ExecuteNonQuery();
                }
                if (RowState == RowState.Modified)
                {
                    var Id = dataGridViewSize.Rows[index].Cells[0].Value.ToString();
                    var Size = dataGridViewSize.Rows[index].Cells[1].Value.ToString();

                    SqlCommand cmd = new SqlCommand("select * from Blossom_Size where Size ='" + Size + "' and ID_Size != '" + Id + "'", dB.GetSqlConnection());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Size already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        var ChangeQuery = $"update Blossom_Size set Size = '{Size}' where ID_Size = '{Id}'";
                        var command = new SqlCommand(ChangeQuery, dB.GetSqlConnection());
                        command.ExecuteNonQuery();
                    }

                    
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
            var SelectedRowIndex = dataGridViewSize.CurrentCell.RowIndex;
            var Id = TBIDSize.Text;
            var Size = TBSize.Text;
            if (dataGridViewSize.Rows[SelectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridViewSize.Rows[SelectedRowIndex].SetValues(Id, Size);
                dataGridViewSize.Rows[SelectedRowIndex].Cells[2].Value = RowState.Modified;
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
            dataGridViewSize.Sort(dataGridViewSize.Columns[1], ListSortDirection.Ascending);
        }

        private void BTSortDesc_Click(object sender, EventArgs e)
        {
            dataGridViewSize.Sort(dataGridViewSize.Columns[1], ListSortDirection.Descending);
        }
    }
}
