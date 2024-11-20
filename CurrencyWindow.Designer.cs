namespace GW2_Wallet_Snapshots
{
    partial class CurrencyWindow
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
            CurrencyDataGridView = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnOrder = new DataGridViewTextBoxColumn();
            ColumnIcon = new DataGridViewImageColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnDescription = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)CurrencyDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CurrencyDataGridView
            // 
            CurrencyDataGridView.AllowUserToAddRows = false;
            CurrencyDataGridView.AllowUserToDeleteRows = false;
            CurrencyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CurrencyDataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnOrder, ColumnIcon, ColumnName, ColumnDescription });
            CurrencyDataGridView.Dock = DockStyle.Fill;
            CurrencyDataGridView.Location = new Point(0, 0);
            CurrencyDataGridView.Name = "CurrencyDataGridView";
            CurrencyDataGridView.RowTemplate.Height = 50;
            CurrencyDataGridView.Size = new Size(1184, 450);
            CurrencyDataGridView.TabIndex = 0;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "ID";
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            ColumnID.Width = 75;
            // 
            // ColumnOrder
            // 
            ColumnOrder.HeaderText = "Order";
            ColumnOrder.Name = "ColumnOrder";
            ColumnOrder.ReadOnly = true;
            ColumnOrder.Width = 75;
            // 
            // ColumnIcon
            // 
            ColumnIcon.HeaderText = "Icon";
            ColumnIcon.ImageLayout = DataGridViewImageCellLayout.Stretch;
            ColumnIcon.Name = "ColumnIcon";
            ColumnIcon.ReadOnly = true;
            ColumnIcon.Width = 50;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Name";
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 150;
            // 
            // ColumnDescription
            // 
            ColumnDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnDescription.HeaderText = "Description";
            ColumnDescription.Name = "ColumnDescription";
            ColumnDescription.ReadOnly = true;
            // 
            // CurrencyWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 450);
            Controls.Add(CurrencyDataGridView);
            Name = "CurrencyWindow";
            Text = "CurrencyWindow";
            Load += CurrencyWindow_Load;
            ((System.ComponentModel.ISupportInitialize)CurrencyDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CurrencyDataGridView;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnOrder;
        private DataGridViewImageColumn ColumnIcon;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnDescription;
    }
}