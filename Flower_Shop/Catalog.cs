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
using System.Xml.Linq;

namespace Flower_Shop
{
    public partial class Catalog : Form
    {
        DB dB = new DB();
        public Catalog()
        {
            InitializeComponent();
        }

        private void BTLogOutUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeWin login = new WelcomeWin();
            login.ShowDialog();
        }
        private void CreateColumns()
        {
            dataGridViewCat.Columns.Add("ID_Shop", "Address");
            dataGridViewCat.Columns.Add("ID_Color", "Color");
            dataGridViewCat.Columns.Add("ID_Size", "Size");
            dataGridViewCat.Columns.Add("ID_Type", "Flower name");
            dataGridViewCat.Columns.Add("ID_Supplier", "Country");
            dataGridViewCat.Columns.Add("Price", "Price");
            dataGridViewCat.Columns.Add("Count", "Count");
            dataGridViewCat.Columns.Add("IsNew", String.Empty);

        }
        private void ClearFields()
        {
            CBFilterAddr.Text = "";
            CBFilterColor.Text = "";
            CBFilterCountry.Text = "";
            CBFilterSize.Text = "";
            CBFilterType.Text = "";
            TBSearch.Text = "";
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetInt32(5), record.GetInt32(6), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgv)
        {

            dB.openConnection();
            dgv.Rows.Clear();

            string QueryString = $"select Sale_Point.Shop_Address, Flower_Color.Color, Blossom_Size.Size, Flower_Type.Flower_Name, Supplier.Country, Flowers.Price, Available.Count from Available join Sale_Point ON Available.ID_Shop = Sale_Point.ID_Shop join Flowers ON Available.ID_Flower = Flowers.ID_Flower join Flower_Color ON Flowers.ID_Color = Flower_Color.ID_Color join Blossom_Size ON Flowers.ID_Size = Blossom_Size.ID_Size join Flower_Type ON Flowers.ID_Type = Flower_Type.ID_Type join Supplier ON Flowers.ID_Supplier = Supplier.ID_Supplier";
            SqlCommand cmd = new SqlCommand(QueryString, dB.GetSqlConnection());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
            dB.closeConnection();
        }
        private void CreateFilterAddr()
        {
            CBFilterAddr.Items.Clear();
            HashSet<string> uniqueValues = new HashSet<string>();
            foreach (DataGridViewRow row in dataGridViewCat.Rows)
            {
                string value = row.Cells[0].Value.ToString();
                if (!uniqueValues.Contains(value))
                {
                    CBFilterAddr.Items.Add(value);
                    uniqueValues.Add(value);
                }
            }
        }
        private void CreateFilterType()
        {
            CBFilterType.Items.Clear();
            HashSet<string> uniqueValues = new HashSet<string>();
            foreach (DataGridViewRow row in dataGridViewCat.Rows)
            {
                string value = row.Cells[3].Value.ToString();
                if (!uniqueValues.Contains(value))
                {
                    CBFilterType.Items.Add(value);
                    uniqueValues.Add(value);
                }
            }
        }
        private void CreateFilterColor()
        {
            CBFilterColor.Items.Clear();
            HashSet<string> uniqueValues = new HashSet<string>();
            foreach (DataGridViewRow row in dataGridViewCat.Rows)
            {
                string value = row.Cells[1].Value.ToString();
                if (!uniqueValues.Contains(value))
                {
                    CBFilterColor.Items.Add(value);
                    uniqueValues.Add(value);
                }
            }
        }
        private void CreateFilterSize()
        {
            CBFilterSize.Items.Clear();
            HashSet<string> uniqueValues = new HashSet<string>();
            foreach (DataGridViewRow row in dataGridViewCat.Rows)
            {
                string value = row.Cells[2].Value.ToString();
                if (!uniqueValues.Contains(value))
                {
                    CBFilterSize.Items.Add(value);
                    uniqueValues.Add(value);
                }
            }
        }
        private void CreateFilterCountry()
        {
            CBFilterCountry.Items.Clear();
            HashSet<string> uniqueValues = new HashSet<string>();
            foreach (DataGridViewRow row in dataGridViewCat.Rows)
            {
                string value = row.Cells[4].Value.ToString();
                if (!uniqueValues.Contains(value))
                {
                    CBFilterCountry.Items.Add(value);
                    uniqueValues.Add(value);
                }
            }
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewCat);
            dataGridViewCat.Columns[7].Visible = false;
            CreateFilterAddr();
            CreateFilterColor();
            CreateFilterCountry();
            CreateFilterSize();
            CreateFilterType();
        }

        private void BTRemoveSettings_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewCat);
            ClearFields();
            CreateFilterAddr();
            CreateFilterColor();
            CreateFilterType();
            CreateFilterSize();
            CreateFilterCountry();
        }
        
        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            SearchAndFilter(dataGridViewCat);
        }

        private void BTSortAscPrice_Click(object sender, EventArgs e)
        {
            dataGridViewCat.Sort(dataGridViewCat.Columns[5], ListSortDirection.Ascending);
        }

        private void BTSortDescPrice_Click(object sender, EventArgs e)
        {
            dataGridViewCat.Sort(dataGridViewCat.Columns[5], ListSortDirection.Descending);
        }

        private void BTSortAscCount_Click(object sender, EventArgs e)
        {
            dataGridViewCat.Sort(dataGridViewCat.Columns[6], ListSortDirection.Ascending);
        }

        private void BTSortDescCount_Click(object sender, EventArgs e)
        {
            dataGridViewCat.Sort(dataGridViewCat.Columns[6], ListSortDirection.Descending);
        }
        private void SearchAndFilter(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string SearchString = "select Sale_Point.Shop_Address, Flower_Color.Color, Blossom_Size.Size, Flower_Type.Flower_Name, Supplier.Country, Flowers.Price, Available.Count from Available join Sale_Point ON Available.ID_Shop = Sale_Point.ID_Shop join Flowers ON Available.ID_Flower = Flowers.ID_Flower join Flower_Color ON Flowers.ID_Color = Flower_Color.ID_Color join Blossom_Size ON Flowers.ID_Size = Blossom_Size.ID_Size join Flower_Type ON Flowers.ID_Type = Flower_Type.ID_Type join Supplier ON Flowers.ID_Supplier = Supplier.ID_Supplier ";

            bool AddedCondition = false;
            if (!string.IsNullOrEmpty(TBSearch.Text))
            {
                SearchString += $"where concat (Sale_Point.Shop_Address, Flower_Color.Color, Blossom_Size.Size, Flower_Type.Flower_Name, Supplier.Country, Flowers.Price, Available.Count) like '%{TBSearch.Text}%'";
                AddedCondition = true;
            }

            if (!string.IsNullOrEmpty(CBFilterAddr.Text))
            {
                SearchString += (AddedCondition ? " AND " : "where ") + $"Available.ID_Shop = (select Sale_Point.ID_Shop from Sale_Point where Shop_Address = '{CBFilterAddr.Text}')";
                AddedCondition = true;
            }

            if (!string.IsNullOrEmpty(CBFilterType.Text))
            {
                SearchString += (AddedCondition ? " AND " : "where ") + $"Flowers.ID_Type = (select Flower_Type.ID_Type from Flower_Type where Flower_Name = '{CBFilterType.Text}')";
                AddedCondition = true;
            }
            if(!string.IsNullOrEmpty(CBFilterColor.Text))
            {
                SearchString += (AddedCondition ? " AND " : "where ") + $"Flowers.ID_Color = (select Flower_Color.ID_Color from Flower_Color where Color = '{CBFilterColor.Text}')";
                AddedCondition = true;
            }
            if(!string.IsNullOrEmpty(CBFilterSize.Text))
            {
                SearchString += (AddedCondition ? " AND " : "where ") + $"Flowers.ID_Size = (select Blossom_Size.ID_Size from Blossom_Size where Size = '{CBFilterSize.Text}')";
                AddedCondition = true;
            }
            if (!string.IsNullOrEmpty(CBFilterCountry.Text))
            {
                SearchString += (AddedCondition ? " AND " : "where ") + $"Flowers.ID_Supplier in (select Supplier.ID_Supplier from Supplier where Country = '{CBFilterCountry.Text}')";
                AddedCondition = true;
            }

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

        private void CBFilterAddr_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAndFilter(dataGridViewCat);
        }

        private void CBFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAndFilter(dataGridViewCat);
        }

        private void CBFilterColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAndFilter(dataGridViewCat);
        }

        private void CBFilterSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAndFilter(dataGridViewCat);
        }

        private void CBFilterCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAndFilter(dataGridViewCat);
        }
    }
}
