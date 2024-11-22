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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void BTLogOutAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeWin login = new WelcomeWin();
            login.ShowDialog();
        }

        private void BTUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            TabSysUs us = new TabSysUs();
            us.ShowDialog();
        }

        private void BTRoles_Click(object sender, EventArgs e)
        {
            this.Hide();
            TabRoles roles = new TabRoles();
            roles.ShowDialog();
        }

        private void BTSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            TabSup suppliers = new TabSup();
            suppliers.ShowDialog();
        }

        private void BTColor_Click(object sender, EventArgs e)
        {
            this.Hide();
            TabColor color = new TabColor();
            color.ShowDialog();
        }

        private void BTSize_Click(object sender, EventArgs e)
        {
            this.Hide();
            TabSize size = new TabSize();
            size.ShowDialog();
        }

        private void BTType_Click(object sender, EventArgs e)
        {
            this.Hide();
            TabType type = new TabType();
            type.ShowDialog();
        }

        private void BTStore_Click(object sender, EventArgs e)
        {
            this.Hide();
            TabStorehouse storehouse = new TabStorehouse();
            storehouse.ShowDialog();
        }

        private void BTSaPo_Click(object sender, EventArgs e)
        {
            this.Hide();
            TabSalePoints points = new TabSalePoints();
            points.ShowDialog();
        }

        private void BTFlowers_Click(object sender, EventArgs e)
        {
            this.Hide();
            TabFlowers flowers = new TabFlowers();
            flowers.ShowDialog();
        }

        private void BTAvailable_Click(object sender, EventArgs e)
        {
            this.Hide();
            TabAvailable available = new TabAvailable();
            available.ShowDialog();
        }
    }
}
