namespace MarketWevers_Northwind
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Hide();
            frmMenu.Show(this);
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {

        }
    }
}
