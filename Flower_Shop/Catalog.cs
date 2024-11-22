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
    public partial class Catalog : Form
    {
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
    }
}
