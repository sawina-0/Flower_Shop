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
    public partial class TabStorehouse : Form
    {
        DB dB = new DB();
        int SelectedRow;
        public TabStorehouse()
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
            dataGridViewStore.Columns.Add("ID_Storehouse", "id");
            dataGridViewStore.Columns.Add("Storehouse_Name", "Storehouse name");
            dataGridViewStore.Columns.Add("Storehouse_Address", "Address");
            dataGridViewStore.Columns.Add("IsNew", String.Empty);

        }
        private void ClearFields()
        {
            TBIDStore.Text = "";
            TBStoreName.Text = "";
            TBStoreAddr.Text = "";
            CBFilter.Text = "";
        }
        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv)
        {

            dB.openConnection();
            dgv.Rows.Clear();

            string QueryString = $"select * from  Storehouse";
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
            foreach (DataGridViewRow row in dataGridViewStore.Rows)
            {
                string value = row.Cells[2].Value.ToString();
                if (!uniqueValues.Contains(value))
                {
                    CBFilter.Items.Add(value);
                    uniqueValues.Add(value);
                }
            }
        }

        private void TabStorehouse_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewStore);
            dataGridViewStore.Columns[3].Visible = false;
            CreateFilter();
        }

        private void dataGridViewStore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewStore.Rows[SelectedRow];

                TBIDStore.Text = row.Cells[0].Value.ToString();
                TBStoreName.Text = row.Cells[1].Value.ToString();
                TBStoreAddr.Text = row.Cells[2].Value.ToString();
            }
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewStore);
            ClearFields();
            CreateFilter();
        }

        private void BTAddData_Click(object sender, EventArgs e)
        {
            AddDataStorehouse AddDataStorehouse = new AddDataStorehouse();
            AddDataStorehouse.Show();
        }
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string SearchString = $"select * from Storehouse where concat (id_storehouse, storehouse_name, storehouse_address) like '%" + TBSearch.Text + "%'";
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
            Search(dataGridViewStore);
        }
        private void DeleteRow()
        {
            int index = dataGridViewStore.CurrentCell.RowIndex;

            dataGridViewStore.Rows[index].Visible = false;

            if (dataGridViewStore.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewStore.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
            dataGridViewStore.Rows[index].Cells[3].Value = RowState.Deleted;
        }
        private void Update()
        {
            dB.openConnection();

            for (int index = 0; index < dataGridViewStore.Rows.Count; index++)
            {
                var RowState = (RowState)dataGridViewStore.Rows[index].Cells[3].Value;
                if (RowState == RowState.Existed)
                {
                    continue;
                }
                if (RowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridViewStore.Rows[index].Cells[0].Value);
                    var DeleteQuery = $"delete from Storehouse where ID_Storehouse = {id}";

                    var command = new SqlCommand(DeleteQuery, dB.GetSqlConnection());
                    command.ExecuteNonQuery();
                }
                if (RowState == RowState.Modified)
                {
                    var Id = dataGridViewStore.Rows[index].Cells[0].Value.ToString();
                    var StName = dataGridViewStore.Rows[index].Cells[1].Value.ToString();
                    var StAddr = dataGridViewStore.Rows[index].Cells[2].Value.ToString();

                    var ChangeQuery = $"update Storehouse set Storehouse_Name = '{StName}', Storehouse_Address = '{StAddr}' where ID_Storehouse = '{Id}'";
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
            var SelectedRowIndex = dataGridViewStore.CurrentCell.RowIndex;
            var Id = TBIDStore.Text;
            var ComName = TBStoreName.Text;
            var Country = TBStoreAddr.Text;
            if (dataGridViewStore.Rows[SelectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridViewStore.Rows[SelectedRowIndex].SetValues(Id, ComName, Country);
                dataGridViewStore.Rows[SelectedRowIndex].Cells[3].Value = RowState.Modified;
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
            dataGridViewStore.Sort(dataGridViewStore.Columns[1], ListSortDirection.Ascending);
        }

        private void BTSortDesc_Click(object sender, EventArgs e)
        {
            dataGridViewStore.Sort(dataGridViewStore.Columns[1], ListSortDirection.Descending);
        }
        private void Filter(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string SearchString = $"select * from Storehouse where Storehouse_Address = '" + CBFilter.Text + "'";
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
            Filter(dataGridViewStore);
        
        }
    }
}
