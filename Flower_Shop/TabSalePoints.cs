using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flower_Shop
{
    public partial class TabSalePoints : Form
    {
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
    }
}
