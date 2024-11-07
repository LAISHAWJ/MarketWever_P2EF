namespace MarketWevers_Northwind
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            PrincipalMenu = new MenuStrip();
            BtMenuProduct = new FontAwesome.Sharp.IconMenuItem();
            BtMenuCateg = new FontAwesome.Sharp.IconMenuItem();
            BtMenuSuplid = new FontAwesome.Sharp.IconMenuItem();
            BtMenuOrder = new FontAwesome.Sharp.IconMenuItem();
            BtMenuExit = new FontAwesome.Sharp.IconMenuItem();
            pictureBox1 = new PictureBox();
            PrincipalMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PrincipalMenu
            // 
            PrincipalMenu.BackColor = Color.Peru;
            PrincipalMenu.ImageScalingSize = new Size(20, 20);
            PrincipalMenu.Items.AddRange(new ToolStripItem[] { BtMenuProduct, BtMenuCateg, BtMenuSuplid, BtMenuOrder, BtMenuExit });
            PrincipalMenu.Location = new Point(0, 0);
            PrincipalMenu.Name = "PrincipalMenu";
            PrincipalMenu.Size = new Size(1048, 81);
            PrincipalMenu.TabIndex = 0;
            PrincipalMenu.Text = "menuStrip1";
            // 
            // BtMenuProduct
            // 
            BtMenuProduct.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtMenuProduct.ForeColor = Color.LemonChiffon;
            BtMenuProduct.IconChar = FontAwesome.Sharp.IconChar.Box;
            BtMenuProduct.IconColor = Color.LemonChiffon;
            BtMenuProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtMenuProduct.IconSize = 50;
            BtMenuProduct.ImageScaling = ToolStripItemImageScaling.None;
            BtMenuProduct.Name = "BtMenuProduct";
            BtMenuProduct.Size = new Size(132, 77);
            BtMenuProduct.Text = "PRODUCTOS";
            BtMenuProduct.TextImageRelation = TextImageRelation.ImageAboveText;
            BtMenuProduct.Click += BtMenuProduct_Click;
            // 
            // BtMenuCateg
            // 
            BtMenuCateg.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtMenuCateg.ForeColor = Color.LemonChiffon;
            BtMenuCateg.IconChar = FontAwesome.Sharp.IconChar.Tag;
            BtMenuCateg.IconColor = Color.LemonChiffon;
            BtMenuCateg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtMenuCateg.IconSize = 50;
            BtMenuCateg.ImageScaling = ToolStripItemImageScaling.None;
            BtMenuCateg.Name = "BtMenuCateg";
            BtMenuCateg.Size = new Size(134, 77);
            BtMenuCateg.Text = "CATEGORIAS";
            BtMenuCateg.TextImageRelation = TextImageRelation.ImageAboveText;
            BtMenuCateg.Click += BtMenuCateg_Click;
            // 
            // BtMenuSuplid
            // 
            BtMenuSuplid.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtMenuSuplid.ForeColor = Color.LemonChiffon;
            BtMenuSuplid.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            BtMenuSuplid.IconColor = Color.LemonChiffon;
            BtMenuSuplid.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtMenuSuplid.IconSize = 50;
            BtMenuSuplid.ImageScaling = ToolStripItemImageScaling.None;
            BtMenuSuplid.Name = "BtMenuSuplid";
            BtMenuSuplid.Size = new Size(131, 77);
            BtMenuSuplid.Text = "SUPLIDORES";
            BtMenuSuplid.TextImageRelation = TextImageRelation.ImageAboveText;
            BtMenuSuplid.Click += BtMenuSuplid_Click;
            // 
            // BtMenuOrder
            // 
            BtMenuOrder.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtMenuOrder.ForeColor = Color.LemonChiffon;
            BtMenuOrder.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            BtMenuOrder.IconColor = Color.LemonChiffon;
            BtMenuOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtMenuOrder.IconSize = 50;
            BtMenuOrder.ImageScaling = ToolStripItemImageScaling.None;
            BtMenuOrder.Name = "BtMenuOrder";
            BtMenuOrder.Size = new Size(86, 77);
            BtMenuOrder.Text = "ORDEN";
            BtMenuOrder.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // BtMenuExit
            // 
            BtMenuExit.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtMenuExit.ForeColor = Color.LemonChiffon;
            BtMenuExit.IconChar = FontAwesome.Sharp.IconChar.Close;
            BtMenuExit.IconColor = Color.LemonChiffon;
            BtMenuExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtMenuExit.IconSize = 50;
            BtMenuExit.ImageScaling = ToolStripItemImageScaling.None;
            BtMenuExit.Name = "BtMenuExit";
            BtMenuExit.Size = new Size(72, 77);
            BtMenuExit.Text = "SALIR";
            BtMenuExit.TextImageRelation = TextImageRelation.ImageAboveText;
            BtMenuExit.Click += BtMenuExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(173, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(648, 618);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(1048, 735);
            Controls.Add(pictureBox1);
            Controls.Add(PrincipalMenu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = PrincipalMenu;
            Name = "FrmMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            PrincipalMenu.ResumeLayout(false);
            PrincipalMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip PrincipalMenu;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconMenuItem BtMenuOrder;
        private FontAwesome.Sharp.IconMenuItem BtMenuProduct;
        private FontAwesome.Sharp.IconMenuItem BtMenuCateg;
        private FontAwesome.Sharp.IconMenuItem BtMenuSuplid;
        private FontAwesome.Sharp.IconMenuItem BtMenuExit;
    }
}