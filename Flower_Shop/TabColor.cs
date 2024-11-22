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
using System.Reflection;

namespace Flower_Shop
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class TabColor : Form
    {
        DB dB = new DB();
        int SelectedRow; 

        public TabColor()
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
            dataGridViewColors.Columns.Add("ID_Color","id");
            dataGridViewColors.Columns.Add("Color", "Color");
            dataGridViewColors.Columns.Add("IsNew", String.Empty);
            
        }
        private void ClearFields()
        {
            TBIDColor.Text = "";
            TBColor.Text = "";
        }
        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv) 
        {
            
            dB.openConnection();
            dgv.Rows.Clear();

            string QueryString = $"select * from  Flower_Color";
            SqlCommand cmd = new SqlCommand(QueryString, dB.GetSqlConnection());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) 
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
            dB.closeConnection();
        }

        private void TabColor_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewColors);
            dataGridViewColors.Columns[2].Visible = false;
            
        }

        private void dataGridViewColors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            SelectedRow = e.RowIndex;
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridViewColors.Rows[SelectedRow];

                TBIDColor.Text = row.Cells[0].Value.ToString();
                TBColor.Text = row.Cells[1].Value.ToString();
            }
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewColors);
            ClearFields();
            
        }

        private void BTAddData_Click(object sender, EventArgs e)
        {
            AddDataColor AddColor = new AddDataColor();
            AddColor.Show();
        }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string SearchString = $"select * from flower_color where concat (id_color, color) like '%" + TBSearch.Text + "%'";
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
            Search(dataGridViewColors);
        }
        private void DeleteRow()
        {
            int index = dataGridViewColors.CurrentCell.RowIndex;

            dataGridViewColors.Rows[index].Visible = false;

            if (dataGridViewColors.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewColors.Rows[index].Cells[2].Value = RowState.Deleted;
                return;
            }
            dataGridViewColors.Rows[index].Cells[2].Value = RowState.Deleted;
        }
        private void Update()
        {
            dB.openConnection();

            for (int index = 0; index < dataGridViewColors.Rows.Count; index++)
            {
                var RowState = (RowState)dataGridViewColors.Rows [index].Cells[2].Value;
                if (RowState == RowState.Existed) 
                {
                    continue;
                }
                if (RowState == RowState.Deleted) 
                {
                    var id = Convert.ToInt32(dataGridViewColors.Rows[index].Cells[0].Value);
                    var DeleteQuery = $"delete from Flower_Color where ID_Color = {id}";

                    var command = new SqlCommand(DeleteQuery, dB.GetSqlConnection());
                    command.ExecuteNonQuery();
                }
                if(RowState == RowState.Modified)
                {
                    var Id = dataGridViewColors.Rows[index].Cells[0].Value.ToString();
                    var Color = dataGridViewColors.Rows[index].Cells[1].Value.ToString();

                    var ChangeQuery = $"update Flower_Color set Color = '{Color}' where ID_Color = '{Id}'";
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
            var SelectedRowIndex = dataGridViewColors.CurrentCell.RowIndex;
            var Id = TBIDColor.Text;
            var Color = TBColor.Text;
            if (dataGridViewColors.Rows[SelectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridViewColors.Rows[SelectedRowIndex].SetValues(Id, Color);
                dataGridViewColors.Rows[SelectedRowIndex ].Cells[2].Value = RowState.Modified;
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
            dataGridViewColors.Sort(dataGridViewColors.Columns[1], ListSortDirection.Ascending);
        }

        private void BTSortDesc_Click(object sender, EventArgs e)
        {
            dataGridViewColors.Sort(dataGridViewColors.Columns[1], ListSortDirection.Descending);
        }

        
    }
}
