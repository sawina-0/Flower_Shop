using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Flower_Shop
{
    public partial class TabFlowers : Form
    {
        DB dB = new DB();
        int SelectedRow;
        public TabFlowers()
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
            dataGridViewFl.Columns.Add("ID_Flower", "id");
            dataGridViewFl.Columns.Add("ID_Color", "Color");
            dataGridViewFl.Columns.Add("ID_Size", "Size");
            dataGridViewFl.Columns.Add("ID_Type", "Flower name");
            dataGridViewFl.Columns.Add("ID_Supplier", "Country");
            dataGridViewFl.Columns.Add("Price", "Price");
            dataGridViewFl.Columns.Add("IsNew", String.Empty);

        }
        private void ClearFields()
        {
            TBIDFl.Text = "";
            TBColor.Text = "";
            TBSize.Text = "";
            TBName.Text = "";
            TBCountry.Text = "";
            TBPrice.Text = "";
            CBFilter.Text = "";
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetInt32(5), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgv)
        {

            dB.openConnection();
            dgv.Rows.Clear();

            string QueryString = $"select Flowers.ID_Flower, Flower_Color.Color, Blossom_Size.Size, Flower_Type.Flower_Name, Supplier.Country, Flowers.Price from Flowers join Flower_Color ON Flowers.ID_Color = Flower_Color.ID_Color join Blossom_Size ON Flowers.ID_Size = Blossom_Size.ID_Size join Flower_Type ON Flowers.ID_Type = Flower_Type.ID_Type join Supplier ON Flowers.ID_Supplier = Supplier.ID_Supplier";
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
            foreach (DataGridViewRow row in dataGridViewFl.Rows)
            {
                string value = row.Cells[3].Value.ToString();
                if (!uniqueValues.Contains(value))
                {
                    CBFilter.Items.Add(value);
                    uniqueValues.Add(value);
                }
            }
        }

        private void TabFlowers_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewFl);
            dataGridViewFl.Columns[6].Visible = false;
            CreateFilter();
        }

        private void dataGridViewFl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewFl.Rows[SelectedRow];

                TBIDFl.Text = row.Cells[0].Value.ToString();
                TBColor.Text = row.Cells[1].Value.ToString();
                TBSize.Text = row.Cells[2].Value.ToString();
                TBName.Text = row.Cells[3].Value.ToString();
                TBCountry.Text = row.Cells[4].Value.ToString();
                TBPrice.Text = row.Cells[5].Value.ToString();
            }
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewFl);
            ClearFields();
            CreateFilter();
        }

        private void BTAddData_Click(object sender, EventArgs e)
        {
            AddDataFlower AddDataFlower = new AddDataFlower();
            AddDataFlower.Show();
        }
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string SearchString = $"select Flowers.ID_Flower, Flower_Color.Color, Blossom_Size.Size, Flower_Type.Flower_Name, Supplier.Country, Flowers.Price from Flowers join Flower_Color ON Flowers.ID_Color = Flower_Color.ID_Color join Blossom_Size ON Flowers.ID_Size = Blossom_Size.ID_Size join Flower_Type ON Flowers.ID_Type = Flower_Type.ID_Type join Supplier ON Flowers.ID_Supplier = Supplier.ID_Supplier where concat (Flowers.ID_Flower, Flower_Color.Color, Blossom_Size.Size, Flower_Type.Flower_Name, Supplier.Country, Flowers.Price) like '%" + TBSearch.Text + "%'";
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
            Search(dataGridViewFl);
        }
        private void DeleteRow()
        {
            int index = dataGridViewFl.CurrentCell.RowIndex;

            dataGridViewFl.Rows[index].Visible = false;

            if (dataGridViewFl.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewFl.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
            dataGridViewFl.Rows[index].Cells[6].Value = RowState.Deleted;
        }
        private int GetIdFromColor(string Name)
        {
            string query = $"SELECT ID_Color FROM Flower_Color WHERE Color = '{Name}'";
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
        private int GetIdFromSize(string Name)
        {
            string query = $"SELECT ID_Size FROM Blossom_Size WHERE Size = '{Name}'";
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
        private int GetIdFromType(string Name)
        {
            string query = $"SELECT ID_Type FROM Flower_Type WHERE Flower_Name = '{Name}'";
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
        private int GetIdFromSup(string Name)
        {
            string query = $"SELECT ID_Supplier FROM Supplier WHERE Country = '{Name}'";
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
        private void Update()
        {
            dB.openConnection();

            for (int index = 0; index < dataGridViewFl.Rows.Count; index++)
            {
                var RowState = (RowState)dataGridViewFl.Rows[index].Cells[6].Value;
                if (RowState == RowState.Existed)
                {
                    continue;
                }
                if (RowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridViewFl.Rows[index].Cells[0].Value);
                    var DeleteQuery = $"delete from Flowers where ID_Flower = {id}";

                    var command = new SqlCommand(DeleteQuery, dB.GetSqlConnection());
                    command.ExecuteNonQuery();
                }
                if (RowState == RowState.Modified)
                {
                    var Id = dataGridViewFl.Rows[index].Cells[0].Value.ToString();
                    var Color = dataGridViewFl.Rows[index].Cells[1].Value.ToString();
                    var Size = dataGridViewFl.Rows[index].Cells[2].Value.ToString();
                    var Type = dataGridViewFl.Rows[index].Cells[3].Value.ToString();
                    var Sup = dataGridViewFl.Rows[index].Cells[4].Value.ToString();
                    var Price = (dataGridViewFl.Rows[index].Cells[5].Value.ToString());
                    int IdColor = GetIdFromColor(Color);
                    int IdSize = GetIdFromSize(Size);
                    int IdType = GetIdFromType(Type);
                    int IdSup = GetIdFromSup(Sup);
                    
                    if (IdColor == -1 || IdSize == -1 || IdType == -1 ||IdSup == -1)
                    {
                        MessageBox.Show("Color or size of type or supplier not found in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var ChangeQuery = $"update Flowers set ID_Color = {IdColor}, ID_Size = {IdSize}, ID_Type = {IdType}, ID_Supplier = {IdSup}, Price = {Price} where ID_Flower = '{Id}'";
                        var command = new SqlCommand(ChangeQuery, dB.GetSqlConnection());
                        command.ExecuteNonQuery();
                    }
                }
            }
            dB.closeConnection();
        }
        private void Change()
        {
            var SelectedRowIndex = dataGridViewFl.CurrentCell.RowIndex;
            var Id = TBIDFl.Text;
            var Color = TBColor.Text;
            var Size = TBSize.Text;
            var Type = TBName.Text;
            var Country = TBCountry.Text;
            int Price;
            if (TBIDFl.Text != string.Empty && TBColor.Text != string.Empty && TBSize.Text != string.Empty && TBName.Text != string.Empty && TBCountry.Text != string.Empty && TBPrice.Text != string.Empty)
            {
                if((int.TryParse(TBPrice.Text, out Price)) && Price>0)
                {
                    dataGridViewFl.Rows[SelectedRowIndex].SetValues(Id, Color, Size, Type, Country, Price);
                    dataGridViewFl.Rows[SelectedRowIndex].Cells[6].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("price not integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("enter the value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dataGridViewFl.Sort(dataGridViewFl.Columns[5], ListSortDirection.Ascending);
        }

        private void BTSortDesc_Click(object sender, EventArgs e)
        {
            dataGridViewFl.Sort(dataGridViewFl.Columns[5], ListSortDirection.Descending);
        }
        private void Filter(DataGridView dgv)
        {
            dgv.Rows.Clear();
            var SearchString = $"select Flowers.ID_Flower, Flower_Color.Color, Blossom_Size.Size, Flower_Type.Flower_Name, Supplier.Country, Flowers.Price from Flowers join Flower_Color ON Flowers.ID_Color = Flower_Color.ID_Color join Blossom_Size ON Flowers.ID_Size = Blossom_Size.ID_Size join Flower_Type ON Flowers.ID_Type = Flower_Type.ID_Type join Supplier ON Flowers.ID_Supplier = Supplier.ID_Supplier where Flowers.ID_Type = (select Flower_Type.ID_Type from Flower_Type where Flower_Name = '" + CBFilter.Text + "')";
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
            Filter(dataGridViewFl);
        }
    }
    
}
