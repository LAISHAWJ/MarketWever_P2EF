using MarketWevers_Northwind.Servicios;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketWevers_Northwind
{
    internal partial class FrmProduct : Form
    {
     
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Hide();
            frmMenu.ShowDialog();
        }
    }
}
