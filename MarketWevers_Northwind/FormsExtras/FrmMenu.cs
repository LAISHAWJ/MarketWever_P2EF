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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtMenuProduct_Click(object sender, EventArgs e)
        {
           FrmProduct frmProduct = new FrmProduct();
           this.Hide();
           frmProduct.Show();
        }

        private void BtMenuCateg_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            this.Hide();
            frmCategory.Show();
        }

        private void BtMenuSuplid_Click(object sender, EventArgs e)
        {
            FrmSupplier frmSupplier = new FrmSupplier();
            this.Hide();
            frmSupplier.Show();
        }

        private void BtMenuExit_Click(object sender, EventArgs e)
        {
            DialogResult Opcionsalir = MessageBox.Show("¿Estás seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (Opcionsalir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       
    }
}
