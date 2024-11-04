namespace MarketWevers_Northwind
{
    partial class FrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            panel1 = new Panel();
            BtBack = new Button();
            BtDelete = new Button();
            BtUpdate = new Button();
            BtAdd = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(BtBack);
            panel1.Controls.Add(BtDelete);
            panel1.Controls.Add(BtUpdate);
            panel1.Controls.Add(BtAdd);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 643);
            panel1.TabIndex = 0;
            // 
            // BtBack
            // 
            BtBack.Cursor = Cursors.Hand;
            BtBack.FlatStyle = FlatStyle.Flat;
            BtBack.ForeColor = Color.Peru;
            BtBack.Image = (Image)resources.GetObject("BtBack.Image");
            BtBack.Location = new Point(7, 567);
            BtBack.Name = "BtBack";
            BtBack.Size = new Size(76, 65);
            BtBack.TabIndex = 4;
            BtBack.UseVisualStyleBackColor = true;
            BtBack.Click += BtBack_Click;
            // 
            // BtDelete
            // 
            BtDelete.BackColor = Color.Red;
            BtDelete.Cursor = Cursors.Hand;
            BtDelete.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold);
            BtDelete.ForeColor = SystemColors.ButtonHighlight;
            BtDelete.Location = new Point(64, 328);
            BtDelete.Name = "BtDelete";
            BtDelete.Size = new Size(213, 55);
            BtDelete.TabIndex = 3;
            BtDelete.Text = "ELIMINAR";
            BtDelete.UseVisualStyleBackColor = false;
            // 
            // BtUpdate
            // 
            BtUpdate.BackColor = Color.FromArgb(255, 128, 0);
            BtUpdate.Cursor = Cursors.Hand;
            BtUpdate.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold);
            BtUpdate.ForeColor = SystemColors.ButtonHighlight;
            BtUpdate.Location = new Point(64, 265);
            BtUpdate.Name = "BtUpdate";
            BtUpdate.Size = new Size(213, 55);
            BtUpdate.TabIndex = 2;
            BtUpdate.Text = "EDITAR";
            BtUpdate.UseVisualStyleBackColor = false;
            // 
            // BtAdd
            // 
            BtAdd.BackColor = Color.Green;
            BtAdd.Cursor = Cursors.Hand;
            BtAdd.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold);
            BtAdd.ForeColor = SystemColors.ButtonHighlight;
            BtAdd.Location = new Point(64, 204);
            BtAdd.Name = "BtAdd";
            BtAdd.Size = new Size(213, 55);
            BtAdd.TabIndex = 1;
            BtAdd.Text = "AGREGAR";
            BtAdd.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(20, 53);
            label1.Name = "label1";
            label1.Size = new Size(304, 62);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(379, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(850, 553);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Location = new Point(379, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 66);
            panel2.TabIndex = 2;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(1246, 686);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmProduct";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtDelete;
        private Button BtUpdate;
        private Button BtAdd;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button BtBack;
    }
}