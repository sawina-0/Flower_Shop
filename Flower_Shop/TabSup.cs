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
    public partial class TabSup : Form
    {
        DB dB = new DB();
        int SelectedRow;
        public TabSup()
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
            dataGridViewSup.Columns.Add("ID_Supplier", "id");
            dataGridViewSup.Columns.Add("Company_Name", "Company name");
            dataGridViewSup.Columns.Add("Country", "Country");
            dataGridViewSup.Columns.Add("IsNew", String.Empty);

        }
        private void ClearFields()
        {
            TBIDSup.Text = "";
            TBComName.Text = "";
            TBCountry.Text = "";
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

            string QueryString = $"select * from  Supplier";
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
            foreach (DataGridViewRow row in dataGridViewSup.Rows)
            {
                string value = row.Cells[2].Value.ToString();
                if (!uniqueValues.Contains(value))
                {
                    CBFilter.Items.Add(value);
                    uniqueValues.Add(value);
                }
            }
        }
        private void TabSup_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewSup);
            dataGridViewSup.Columns[3].Visible = false;
            CreateFilter();
        }

        private void dataGridViewSup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSup.Rows[SelectedRow];

                TBIDSup.Text = row.Cells[0].Value.ToString();
                TBComName.Text = row.Cells[1].Value.ToString();
                TBCountry.Text = row.Cells[2].Value.ToString();
            }
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewSup);
            ClearFields();
            CreateFilter();           
        }

        private void BTAddData_Click(object sender, EventArgs e)
        {
            AddDataSup AddSup = new AddDataSup();
            AddSup.Show();
        }
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string SearchString = $"select * from Supplier where concat (id_supplier, company_name, country) like '%" + TBSearch.Text + "%'";
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
            Search(dataGridViewSup);
        }
        private void DeleteRow()
        {
            int index = dataGridViewSup.CurrentCell.RowIndex;

            dataGridViewSup.Rows[index].Visible = false;

            if (dataGridViewSup.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewSup.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
            dataGridViewSup.Rows[index].Cells[3].Value = RowState.Deleted;
        }
        private void Update()
        {
            dB.openConnection();

            for (int index = 0; index < dataGridViewSup.Rows.Count; index++)
            {
                var RowState = (RowState)dataGridViewSup.Rows[index].Cells[3].Value;
                if (RowState == RowState.Existed)
                {
                    continue;
                }
                if (RowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridViewSup.Rows[index].Cells[0].Value);
                    var DeleteQuery = $"delete from Supplier where ID_Supplier = {id}";

                    var command = new SqlCommand(DeleteQuery, dB.GetSqlConnection());
                    command.ExecuteNonQuery();
                }
                if (RowState == RowState.Modified)
                {
                    var Id = dataGridViewSup.Rows[index].Cells[0].Value.ToString();
                    var ComName = dataGridViewSup.Rows[index].Cells[1].Value.ToString();
                    var Country =dataGridViewSup.Rows[index].Cells[2].Value.ToString();

                    SqlCommand cmd = new SqlCommand("select * from Supplier where Company_Name='" + ComName + "' and ID_Supplier != '" + Id + "'", dB.GetSqlConnection());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Company already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        var ChangeQuery = $"update Supplier set Company_Name = '{ComName}', Country = '{Country}' where ID_Supplier = '{Id}'";
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
            var SelectedRowIndex = dataGridViewSup.CurrentCell.RowIndex;
            var Id = TBIDSup.Text;
            var ComName = TBComName.Text;
            var Country = TBCountry.Text;
            if (TBIDSup.Text != string.Empty && TBComName.Text != string.Empty && TBCountry.Text != string.Empty)
            {
                dataGridViewSup.Rows[SelectedRowIndex].SetValues(Id, ComName, Country);
                dataGridViewSup.Rows[SelectedRowIndex].Cells[3].Value = RowState.Modified;
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
            dataGridViewSup.Sort(dataGridViewSup.Columns[1], ListSortDirection.Ascending);
        }

        private void BTSortDesc_Click(object sender, EventArgs e)
        {
            dataGridViewSup.Sort(dataGridViewSup.Columns[1], ListSortDirection.Descending);
        }
        private void Filter (DataGridView dgv)
        {
            dgv.Rows.Clear();
            string SearchString = $"select * from Supplier where country = '" + CBFilter.Text + "'";
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
            Filter(dataGridViewSup);
        }
    }
}
