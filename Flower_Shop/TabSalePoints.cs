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
    public partial class TabSalePoints : Form
    {
        DB dB = new DB();
        int SelectedRow;
        public TabSalePoints()
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
            dataGridViewShop.Columns.Add("ID_Shop", "id");
            dataGridViewShop.Columns.Add("Shop_Address", "Address");
            dataGridViewShop.Columns.Add("ID_Storehouse", "Storehouse name");
            dataGridViewShop.Columns.Add("IsNew", String.Empty);

        }
        private void ClearFields()
        {
            TBIDSP.Text = "";
            TBSPAddr.Text = "";
            TBSHName.Text = "";
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

            string QueryString = $"select Sale_Point.ID_Shop, Sale_Point.Shop_Address, Storehouse.Storehouse_Name from Sale_Point join Storehouse ON Sale_Point.ID_Storehouse = Storehouse.ID_Storehouse";
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
            foreach (DataGridViewRow row in dataGridViewShop.Rows)
            {
                string value = row.Cells[2].Value.ToString();
                if (!uniqueValues.Contains(value))
                {
                    CBFilter.Items.Add(value);
                    uniqueValues.Add(value);
                }
            }
        }

        private void TabSalePoints_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewShop);
            dataGridViewShop.Columns[3].Visible = false;
            CreateFilter();
        }

        private void dataGridViewShop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewShop.Rows[SelectedRow];

                TBIDSP.Text = row.Cells[0].Value.ToString();
                TBSPAddr.Text = row.Cells[1].Value.ToString();
                TBSHName.Text = row.Cells[2].Value.ToString();
            }
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewShop);
            ClearFields();
            CreateFilter();
        }

        private void BTAddData_Click(object sender, EventArgs e)
        {
            AddDataSalePoints AddSP = new AddDataSalePoints();
            AddSP.Show();
        }
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string SearchString = $"select Sale_Point.ID_Shop, Sale_Point.Shop_Address, Storehouse.Storehouse_Name from Sale_Point join Storehouse ON Sale_Point.ID_Storehouse = Storehouse.ID_Storehouse where concat (Sale_Point.ID_Shop, Sale_Point.Shop_Address, Storehouse.Storehouse_Name) like '%" + TBSearch.Text + "%'";
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
            Search(dataGridViewShop);
        }
        private void DeleteRow()
        {
            int index = dataGridViewShop.CurrentCell.RowIndex;

            dataGridViewShop.Rows[index].Visible = false;

            if (dataGridViewShop.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewShop.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
            dataGridViewShop.Rows[index].Cells[3].Value = RowState.Deleted;
        }
        private void Update()
        {
            dB.openConnection();

            for (int index = 0; index < dataGridViewShop.Rows.Count; index++)
            {
                var RowState = (RowState)dataGridViewShop.Rows[index].Cells[3].Value;
                if (RowState == RowState.Existed)
                {
                    continue;
                }
                if (RowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridViewShop.Rows[index].Cells[0].Value);
                    var DeleteQuery = $"delete from Sale_Point where ID_Shop = {id}";

                    var command = new SqlCommand(DeleteQuery, dB.GetSqlConnection());
                    command.ExecuteNonQuery();
                }
                if (RowState == RowState.Modified)
                {
                    var Id = dataGridViewShop.Rows[index].Cells[0].Value.ToString();
                    var ShopAddr = dataGridViewShop.Rows[index].Cells[1].Value.ToString();
                    var SHName = dataGridViewShop.Rows[index].Cells[2].Value.ToString();
                    int IdSHName = GetIdFromName(SHName);
                    SqlCommand cmd = new SqlCommand("select * from Sale_Point where Shop_Address='" + ShopAddr + "' and ID_Shop != '" + Id + "'", dB.GetSqlConnection());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (IdSHName == -1 || dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Addres already exist or Storehouse name '" + SHName + "' not found in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        var ChangeQuery = $"update Sale_Point set Shop_Address = '{ShopAddr}', ID_Storehouse = '{IdSHName}' where ID_Shop = '{Id}'";
                        var command = new SqlCommand(ChangeQuery, dB.GetSqlConnection());
                        command.ExecuteNonQuery();
                    }
                }
            }
            dB.closeConnection();
        }
        private int GetIdFromName(string Name)
        {
            string query = $"SELECT ID_Storehouse FROM Storehouse WHERE Storehouse_Name = '{Name}'";
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
            var SelectedRowIndex = dataGridViewShop.CurrentCell.RowIndex;
            var Id = TBIDSP.Text;
            var SPAddr = TBSPAddr.Text;
            var SHName = TBSHName.Text;
            if (TBIDSP.Text != string.Empty && TBSPAddr.Text != string.Empty && TBSHName.Text != string.Empty)
            {
                dataGridViewShop.Rows[SelectedRowIndex].SetValues(Id, SPAddr, SHName);
                dataGridViewShop.Rows[SelectedRowIndex].Cells[3].Value = RowState.Modified;
            }
        }

        private void BTModify_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
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

        private void BTClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BTSortAsc_Click(object sender, EventArgs e)
        {
            dataGridViewShop.Sort(dataGridViewShop.Columns[1], ListSortDirection.Ascending);
        }

        private void BTSortDesc_Click(object sender, EventArgs e)
        {
            dataGridViewShop.Sort(dataGridViewShop.Columns[1], ListSortDirection.Descending);
        }
        private void Filter(DataGridView dgv)
        {
            dgv.Rows.Clear();
            var SearchString = $"select Sale_Point.ID_Shop, Sale_Point.Shop_Address, Storehouse.Storehouse_Name from Sale_Point join Storehouse ON Sale_Point.ID_Storehouse = Storehouse.ID_Storehouse where Sale_Point.ID_Storehouse = (select Storehouse.ID_Storehouse from Storehouse where Storehouse_Name = '" + CBFilter.Text + "')";
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
            Filter(dataGridViewShop);
        }
    }
}
