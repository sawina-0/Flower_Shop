using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flower_Shop
{
    public partial class TabAvailable : Form
    {
        DB dB = new DB();
        int SelectedRow;
        public TabAvailable()
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
            dataGridViewAv.Columns.Add("ID_Available", "id");
            dataGridViewAv.Columns.Add("ID_Shop", "Address");
            dataGridViewAv.Columns.Add("ID_Color", "Color");
            dataGridViewAv.Columns.Add("ID_Size", "Size");
            dataGridViewAv.Columns.Add("ID_Type", "Flower name");
            dataGridViewAv.Columns.Add("ID_Supplier", "Company name");
            dataGridViewAv.Columns.Add("Count", "Count");
            dataGridViewAv.Columns.Add("IsNew", String.Empty);

        }
        private void ClearFields()
        {
            TBIDAv.Text = "";
            TBAddr.Text = "";
            TBColor.Text = "";
            TBSize.Text = "";
            TBName.Text = "";
            TBSup.Text = "";
            TBCount.Text = "";
            CBFilter.Text = "";
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetInt32(6), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgv)
        {

            dB.openConnection();
            dgv.Rows.Clear();
             
            string QueryString = $"select Available.ID_Available, Sale_Point.Shop_Address, Flower_Color.Color, Blossom_Size.Size, Flower_Type.Flower_Name, Supplier.Company_Name, Available.Count from Available join Sale_Point ON Available.ID_Shop = Sale_Point.ID_Shop join Flowers ON Available.ID_Flower = Flowers.ID_Flower join Flower_Color ON Flowers.ID_Color = Flower_Color.ID_Color join Blossom_Size ON Flowers.ID_Size = Blossom_Size.ID_Size join Flower_Type ON Flowers.ID_Type = Flower_Type.ID_Type join Supplier ON Flowers.ID_Supplier = Supplier.ID_Supplier";
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
            foreach (DataGridViewRow row in dataGridViewAv.Rows)
            {
                string value = row.Cells[1].Value.ToString();
                if (!uniqueValues.Contains(value))
                {
                    CBFilter.Items.Add(value);
                    uniqueValues.Add(value);
                }
            }
        }

        private void TabAvailable_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewAv);
            dataGridViewAv.Columns[7].Visible = false;
            CreateFilter();
        }

        private void dataGridViewAv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewAv.Rows[SelectedRow];

                TBIDAv.Text = row.Cells[0].Value.ToString();
                TBAddr.Text = row.Cells[1].Value.ToString();
                TBColor.Text = row.Cells[2].Value.ToString();
                TBSize.Text = row.Cells[3].Value.ToString();
                TBName.Text = row.Cells[4].Value.ToString();
                TBSup.Text = row.Cells[5].Value.ToString();
                TBCount.Text = row.Cells[6].Value.ToString();
            }
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewAv);
            ClearFields();
            CreateFilter();
        }

        private void BTAddData_Click(object sender, EventArgs e)
        {
            AddDataAvailable AddDataAvailable = new AddDataAvailable();
            AddDataAvailable.Show();
        }
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string SearchString = $"select Available.ID_Available, Sale_Point.Shop_Address, Flower_Color.Color, Blossom_Size.Size, Flower_Type.Flower_Name, Supplier.Company_Name, Available.Count from Available join Sale_Point ON Available.ID_Shop = Sale_Point.ID_Shop join Flowers ON Available.ID_Flower = Flowers.ID_Flower join Flower_Color ON Flowers.ID_Color = Flower_Color.ID_Color join Blossom_Size ON Flowers.ID_Size = Blossom_Size.ID_Size join Flower_Type ON Flowers.ID_Type = Flower_Type.ID_Type join Supplier ON Flowers.ID_Supplier = Supplier.ID_Supplier where concat (Available.ID_Available, Sale_Point.Shop_Address, Flower_Color.Color, Blossom_Size.Size, Flower_Type.Flower_Name, Supplier.Company_Name, Available.Count) like '%" + TBSearch.Text + "%'";
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
            Search(dataGridViewAv);
        }
        private void DeleteRow()
        {
            int index = dataGridViewAv.CurrentCell.RowIndex;

            dataGridViewAv.Rows[index].Visible = false;

            if (dataGridViewAv.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewAv.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }
            dataGridViewAv.Rows[index].Cells[7].Value = RowState.Deleted;
        }
        private int GetIdFromAddr(string Name)
        {
            string query = $"SELECT ID_Shop FROM Sale_Point WHERE Shop_Address = '{Name}'";
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
            string query = $"SELECT ID_Supplier FROM Supplier WHERE Company_Name = '{Name}'";
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
        private int GetFlowerId(int IdColor, int IdSize, int IdType, int IdSup)
        {
            string query = $"select ID_Flower FROM Flowers where ID_Color  = {IdColor} and ID_Size = {IdSize} and ID_Type = {IdType} and ID_Supplier = {IdSup}";
            SqlCommand command = new SqlCommand (query, dB.GetSqlConnection());
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if(reader.Read())
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

            for (int index = 0; index < dataGridViewAv.Rows.Count; index++)
            {
                var RowState = (RowState)dataGridViewAv.Rows[index].Cells[7].Value;
                if (RowState == RowState.Existed)
                {
                    continue;
                }
                if (RowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridViewAv.Rows[index].Cells[0].Value);
                    var DeleteQuery = $"delete from Available where ID_Available = {id}";

                    var command = new SqlCommand(DeleteQuery, dB.GetSqlConnection());
                    command.ExecuteNonQuery();
                }
                if (RowState == RowState.Modified)
                {
                    var Id = dataGridViewAv.Rows[index].Cells[0].Value.ToString();
                    var Addr = dataGridViewAv.Rows[index ].Cells[1].Value.ToString();
                    var Color = dataGridViewAv.Rows[index].Cells[2].Value.ToString();
                    var Size = dataGridViewAv.Rows[index].Cells[3].Value.ToString();
                    var Type = dataGridViewAv.Rows[index].Cells[4].Value.ToString();
                    var Sup = dataGridViewAv.Rows[index].Cells[5].Value.ToString();
                    var Count = dataGridViewAv.Rows[index].Cells[6].Value.ToString();
                    int IdAddr = GetIdFromAddr(Addr);
                    int IdColor = GetIdFromColor(Color);
                    int IdSize = GetIdFromSize(Size);
                    int IdType = GetIdFromType(Type);
                    int IdSup = GetIdFromSup(Sup);
                    int IdFlower = GetFlowerId(IdColor, IdSize, IdType, IdSup);
                    if (IdColor == -1 || IdSize == -1 || IdType == -1 || IdSup == -1 || IdAddr == -1)
                    {
                        MessageBox.Show("Color, size, type, supplier or address not found in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(IdFlower == -1)
                        {
                            MessageBox.Show("Flower do not exist in database, add it first to use later ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var ChangeQuery = $"update Available set ID_Shop = {IdAddr}, ID_Flower = {IdFlower} where ID_Available = '{Id}'";
                            var command = new SqlCommand(ChangeQuery, dB.GetSqlConnection());
                            command.ExecuteNonQuery();
                        }
                        
                    }
                }
            }
            dB.closeConnection();
        }
        private void Change()
        {
            dB.openConnection();
            var SelectedRowIndex = dataGridViewAv.CurrentCell.RowIndex;
            var Id = TBIDAv.Text;
            var Addr = TBAddr.Text;
            var Color = TBColor.Text;
            var Size = TBSize.Text;
            var Type = TBName.Text;
            var Sup = TBSup.Text;
            int Count;

            

            if (TBIDAv.Text != string.Empty && TBAddr.Text != string.Empty && TBColor.Text != string.Empty && TBSize.Text != string.Empty && TBName.Text != string.Empty && TBSup.Text != string.Empty && TBCount.Text != string.Empty)
            {
                if ((int.TryParse(TBCount.Text, out Count)) && Count > 0)
                {
                    SqlCommand FindDouble = new SqlCommand("select ID_Shop, ID_Flower, Count from Available where ID_Shop = (select ID_Shop from Sale_Point where Shop_Address = '" + Addr + "') and ID_Flower = (select ID_Flower from Flowers where ID_Color = (select ID_Color from Flower_Color where Color = '" + Color + "') AND ID_Size = (select ID_Size from Blossom_Size where Size = '" + Size + "') AND ID_Type = (select ID_Type from Flower_Type where Flower_Name = '" + Type + "') AND ID_Supplier = (select ID_Supplier from Supplier where Company_Name = '" + Sup + "')) and Count = '" + Count + "'", dB.GetSqlConnection());
                    SqlDataReader DoubleReader = FindDouble.ExecuteReader();
                    bool CheckDouble = DoubleReader.Read();
                    DoubleReader.Close();
                    if (CheckDouble == true)
                    {
                        MessageBox.Show("This data already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dataGridViewAv.Rows[SelectedRowIndex].SetValues(Id, Addr, Color, Size, Type, Sup, Count);
                        dataGridViewAv.Rows[SelectedRowIndex].Cells[7].Value = RowState.Modified;
                    }
                    
                }
                else
                {
                    MessageBox.Show("count not integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("enter the value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dB.closeConnection();
        }

        private void BTModify_Click(object sender, EventArgs e)
        {
            Change();
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

        private void BTDeleteData_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void BTSortAsc_Click(object sender, EventArgs e)
        {
            dataGridViewAv.Sort(dataGridViewAv.Columns[6], ListSortDirection.Ascending);
        }

        private void BTSortDesc_Click(object sender, EventArgs e)
        {
            dataGridViewAv.Sort(dataGridViewAv.Columns[6], ListSortDirection.Descending);
        }
        private void Filter(DataGridView dgv)
        {
            dgv.Rows.Clear();
            var SearchString = $"select Available.ID_Available, Sale_Point.Shop_Address, Flower_Color.Color, Blossom_Size.Size, Flower_Type.Flower_Name, Supplier.Company_Name, Available.Count from Available join Sale_Point ON Available.ID_Shop = Sale_Point.ID_Shop join Flowers ON Available.ID_Flower = Flowers.ID_Flower join Flower_Color ON Flowers.ID_Color = Flower_Color.ID_Color join Blossom_Size ON Flowers.ID_Size = Blossom_Size.ID_Size join Flower_Type ON Flowers.ID_Type = Flower_Type.ID_Type join Supplier ON Flowers.ID_Supplier = Supplier.ID_Supplier where Available.ID_Shop = (select Sale_Point.ID_Shop from Sale_Point where Shop_Address = '" + CBFilter.Text + "')";
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
            Filter(dataGridViewAv);
        }
    }
}
