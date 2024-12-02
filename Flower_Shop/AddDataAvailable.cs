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
    public partial class AddDataAvailable : Form
    {
        DB dB = new DB();
        public AddDataAvailable()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
        private void BTSaveData_Click(object sender, EventArgs e)
        {
            dB.openConnection();
            var AddAddr = TBAddAddr.Text;
            var AddColor = TBAddColor.Text;
            var AddSize = TBAddSize.Text;
            var AddType = TBAddType.Text;
            var AddSup = TBAddSup.Text;
            int AddCount;
            if (TBAddAddr.Text != string.Empty && TBAddColor.Text != string.Empty && TBAddSize.Text != string.Empty && TBAddType.Text != string.Empty && TBAddSup.Text != string.Empty && TBAddCount.Text != string.Empty)
            {
                if ((int.TryParse(TBAddCount.Text, out AddCount)) && AddCount > 0)
                {
                    SqlCommand comm = new SqlCommand("select * from Sale_Point where Shop_Address ='" + TBAddAddr.Text + "'", dB.GetSqlConnection());
                    SqlDataReader AddressChecker = comm.ExecuteReader();
                    bool CheckAddress = AddressChecker.Read();
                    AddressChecker.Close();

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

                    SqlCommand FindDouble = new SqlCommand("select ID_Shop, ID_Flower, Count from Available where ID_Shop = (select ID_Shop from Sale_Point where Shop_Address = '" + TBAddAddr + "') and ID_Flower = (select ID_Flower from Flowers where ID_Color = (select ID_Color from Flower_Color where Color = '" + TBAddColor + "') AND ID_Size = (select ID_Size from Blossom_Size where Size = '" + TBAddSize + "') AND ID_Type = (select ID_Type from Flower_Type where Flower_Name = '" + TBAddType + "') AND ID_Supplier = (select ID_Supplier from Supplier where Company_Name = '" + TBAddSup + "')) AND Count = '"+ AddCount+ "'", dB.GetSqlConnection());
                    SqlDataReader DoubleReader = FindDouble.ExecuteReader();
                    bool CheckDouble = DoubleReader.Read();
                    DoubleReader.Close();

                    int IdAddr = GetIdFromAddr(AddAddr);
                    int IdColor = GetIdFromColor(AddColor);
                    int IdSize = GetIdFromSize(AddSize);
                    int IdType = GetIdFromType(AddType);
                    int IdSup = GetIdFromSup(AddSup);
                    int IdFlower = GetFlowerId(IdColor, IdSize, IdType, IdSup);


                    if (CheckColor == true && CheckSize == true && CheckType == true && CheckSup == true && CheckAddress == true)
                    {
                        if(IdFlower == -1)
                        {
                            MessageBox.Show("Flower do not exist in database, add it first to use later ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (CheckDouble == true)
                            {
                                MessageBox.Show("This data already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                var AddQuery = $"insert into Available (ID_Shop, ID_Flower, Count) values ((select ID_Shop from Sale_Point where Shop_Address = '{AddAddr}'),(select ID_Flower from Flowers where ID_Color = (select ID_Color from Flower_Color where Color = '{AddColor}') AND ID_Size = (select ID_Size from Blossom_Size where Size = '{AddSize}') AND ID_Type = (select ID_Type from Flower_Type where Flower_Name = '{AddType}') AND ID_Supplier = (select ID_Supplier from Supplier where Company_Name = '{AddSup}')),'{AddCount}')";
                                var InsertCommand = new SqlCommand(AddQuery, dB.GetSqlConnection());
                                InsertCommand.ExecuteNonQuery();

                                MessageBox.Show("Data is add", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("there is no such an address, color, type, size or supplier in the database, add it first to use in the future", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
