namespace MarketWevers_Northwind
{
    partial class FrmStart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStart));
            pictureBox1 = new PictureBox();
            BtStart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(99, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(809, 644);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtStart
            // 
            BtStart.Cursor = Cursors.Hand;
            BtStart.FlatStyle = FlatStyle.Flat;
            BtStart.ForeColor = Color.Firebrick;
            BtStart.Image = (Image)resources.GetObject("BtStart.Image");
            BtStart.Location = new Point(893, 611);
            BtStart.Name = "BtStart";
            BtStart.Size = new Size(116, 114);
            BtStart.TabIndex = 1;
            BtStart.UseVisualStyleBackColor = true;
            BtStart.Click += BtStart_Click;
            // 
            // FrmStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(1015, 728);
            Controls.Add(BtStart);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmStart";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmStart_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtStart;
    }
}
