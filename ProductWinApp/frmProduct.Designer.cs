namespace ProductWinApp
{
    partial class frmProduct
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
            btnViewProduct = new Button();
            btnViewCatagories = new Button();
            dgvData = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnViewProduct
            // 
            btnViewProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewProduct.Location = new Point(76, 46);
            btnViewProduct.Name = "btnViewProduct";
            btnViewProduct.Size = new Size(174, 46);
            btnViewProduct.TabIndex = 0;
            btnViewProduct.Text = "View Product ";
            btnViewProduct.UseVisualStyleBackColor = true;
            btnViewProduct.Click += btnViewProduct_Click;
            // 
            // btnViewCatagories
            // 
            btnViewCatagories.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewCatagories.Location = new Point(487, 46);
            btnViewCatagories.Name = "btnViewCatagories";
            btnViewCatagories.Size = new Size(152, 46);
            btnViewCatagories.TabIndex = 1;
            btnViewCatagories.Text = "View Catagories";
            btnViewCatagories.UseVisualStyleBackColor = true;
            btnViewCatagories.Click += btnViewCatagories_Click;
            // 
            // dgvData
            // 
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(25, 113);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 29;
            dgvData.Size = new Size(705, 249);
            dgvData.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(310, 385);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(116, 39);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 450);
            Controls.Add(btnClose);
            Controls.Add(dgvData);
            Controls.Add(btnViewCatagories);
            Controls.Add(btnViewProduct);
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProduct";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewProduct;
        private Button btnViewCatagories;
        private DataGridView dgvData;
        private Button btnClose;
    }
}