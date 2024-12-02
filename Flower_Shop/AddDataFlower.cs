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
    public partial class AddDataFlower : Form
    {
        DB dB = new DB();
        public AddDataFlower()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BTSaveData_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            var AddColor = TBAddColor.Text;
            var AddSize = TBAddSize.Text;
            var AddType = TBAddType.Text;
            var AddSup = TBAddSup.Text;
            int AddPrice;
            if (TBAddColor.Text != string.Empty && TBAddSize.Text != string.Empty && TBAddType.Text != string.Empty && TBAddSup.Text != string.Empty && TBAddPrice.Text != string.Empty)
            {
                if ((int.TryParse(TBAddPrice.Text, out AddPrice)) && AddPrice>0)
                {
                    SqlCommand com = new SqlCommand("select * from Flower_Color where Color ='" + TBAddColor.Text + "'", dB.GetSqlConnection());
                    SqlDataReader ColorChecker = com.ExecuteReader();
                    bool CheckColor = ColorChecker.Read();
                    ColorChecker.Close();

                    SqlCommand command = new SqlCommand("select * from Blossom_Size where Size ='" + TBAddSize.Text + "'", dB.GetSqlConnection());
                    SqlDataReader SizeChecker = command.ExecuteReader();
                    bool CheckSize = SizeChecker.Read();
                    SizeChecker.Close();

                    SqlCommand SqlCom = new SqlCommand("select * from Flower_Type where Flower_Name ='" + TBAddType.Text + "'", dB.GetSqlConnection());
                    SqlDataReader TypeChecker = SqlCom.ExecuteReader();
                    bool CheckType = TypeChecker.Read();
                    TypeChecker.Close();

                    SqlCommand cmd = new SqlCommand("select * from Supplier where Company_Name ='" + TBAddSup.Text + "'", dB.GetSqlConnection());
                    SqlDataReader SupChecker = cmd.ExecuteReader();
                    bool CheckSup = SupChecker.Read();
                    SupChecker.Close();
                    if (CheckColor == true && CheckSize == true && CheckType == true && CheckSup == true)
                    {
                        var AddQuery = $"insert into Flowers (ID_Color, ID_Size, ID_Type, ID_Supplier, Price) values ((select ID_Color from Flower_Color where Color = '{AddColor}'),(select ID_Size from Blossom_Size where Size = '{AddSize}'),(select ID_Type from Flower_Type where Flower_Name = '{AddType}'),(select ID_Supplier from Supplier where Company_Name = '{AddSup}'),'{AddPrice}')";
                        var InsertCommand = new SqlCommand(AddQuery, dB.GetSqlConnection());
                        InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("Data is add", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("there is no such a color, type, size or supplier in the database, add it first to use in the future", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
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
            dB.closeConnection();
        }
    }
}
