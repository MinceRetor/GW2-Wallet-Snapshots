namespace GW2_Wallet_Snapshots
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            FileDropDownButton = new ToolStripDropDownButton();
            FileNewButton = new ToolStripMenuItem();
            FileLoadButton = new ToolStripMenuItem();
            FileSaveButton = new ToolStripMenuItem();
            FileSaveAsButton = new ToolStripMenuItem();
            EditDropDownButton = new ToolStripDropDownButton();
            EditConfigButton = new ToolStripMenuItem();
            MainWindowToolStrip = new ToolStrip();
            ViewDropDownButton = new ToolStripDropDownButton();
            ViewCurrenciesButton = new ToolStripMenuItem();
            CreateSnapshotButton = new ToolStripButton();
            WalletDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            SnapshotDetailsDataGridView = new DataGridView();
            CurrencyIcon = new DataGridViewImageColumn();
            CurrencyName = new DataGridViewTextBoxColumn();
            CurrencyValue = new DataGridViewTextBoxColumn();
            CurrencyChange = new DataGridViewTextBoxColumn();
            MainWindowToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WalletDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SnapshotDetailsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // FileDropDownButton
            // 
            FileDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            FileDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { FileNewButton, FileLoadButton, FileSaveButton, FileSaveAsButton });
            FileDropDownButton.Image = (Image)resources.GetObject("FileDropDownButton.Image");
            FileDropDownButton.ImageTransparentColor = Color.Magenta;
            FileDropDownButton.Name = "FileDropDownButton";
            FileDropDownButton.Size = new Size(38, 22);
            FileDropDownButton.Text = "File";
            // 
            // FileNewButton
            // 
            FileNewButton.Name = "FileNewButton";
            FileNewButton.Size = new Size(180, 22);
            FileNewButton.Text = "New";
            FileNewButton.Click += FileNewButton_Click;
            // 
            // FileLoadButton
            // 
            FileLoadButton.Name = "FileLoadButton";
            FileLoadButton.Size = new Size(180, 22);
            FileLoadButton.Text = "Load";
            FileLoadButton.Click += FileLoadButton_Click;
            // 
            // FileSaveButton
            // 
            FileSaveButton.Name = "FileSaveButton";
            FileSaveButton.Size = new Size(180, 22);
            FileSaveButton.Text = "Save";
            FileSaveButton.Click += FileSaveButton_Click;
            // 
            // FileSaveAsButton
            // 
            FileSaveAsButton.Name = "FileSaveAsButton";
            FileSaveAsButton.Size = new Size(180, 22);
            FileSaveAsButton.Text = "Save As";
            FileSaveAsButton.Click += FileSaveAsButton_Click;
            // 
            // EditDropDownButton
            // 
            EditDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            EditDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { EditConfigButton });
            EditDropDownButton.Image = (Image)resources.GetObject("EditDropDownButton.Image");
            EditDropDownButton.ImageTransparentColor = Color.Magenta;
            EditDropDownButton.Name = "EditDropDownButton";
            EditDropDownButton.Size = new Size(40, 22);
            EditDropDownButton.Text = "Edit";
            // 
            // EditConfigButton
            // 
            EditConfigButton.Name = "EditConfigButton";
            EditConfigButton.Size = new Size(110, 22);
            EditConfigButton.Text = "Config";
            EditConfigButton.Click += EditConfigButton_Click;
            // 
            // MainWindowToolStrip
            // 
            MainWindowToolStrip.Items.AddRange(new ToolStripItem[] { FileDropDownButton, EditDropDownButton, ViewDropDownButton, CreateSnapshotButton });
            MainWindowToolStrip.Location = new Point(0, 0);
            MainWindowToolStrip.Name = "MainWindowToolStrip";
            MainWindowToolStrip.Size = new Size(1184, 25);
            MainWindowToolStrip.TabIndex = 2;
            MainWindowToolStrip.Text = "toolStrip1";
            // 
            // ViewDropDownButton
            // 
            ViewDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ViewDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { ViewCurrenciesButton });
            ViewDropDownButton.Image = (Image)resources.GetObject("ViewDropDownButton.Image");
            ViewDropDownButton.ImageTransparentColor = Color.Magenta;
            ViewDropDownButton.Name = "ViewDropDownButton";
            ViewDropDownButton.Size = new Size(45, 22);
            ViewDropDownButton.Text = "View";
            // 
            // ViewCurrenciesButton
            // 
            ViewCurrenciesButton.Name = "ViewCurrenciesButton";
            ViewCurrenciesButton.Size = new Size(130, 22);
            ViewCurrenciesButton.Text = "Currencies";
            ViewCurrenciesButton.Click += ViewCurrenciesButton_Click;
            // 
            // CreateSnapshotButton
            // 
            CreateSnapshotButton.Alignment = ToolStripItemAlignment.Right;
            CreateSnapshotButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            CreateSnapshotButton.Image = (Image)resources.GetObject("CreateSnapshotButton.Image");
            CreateSnapshotButton.ImageTransparentColor = Color.Magenta;
            CreateSnapshotButton.Name = "CreateSnapshotButton";
            CreateSnapshotButton.Size = new Size(97, 22);
            CreateSnapshotButton.Text = "Create Snapshot";
            CreateSnapshotButton.ToolTipText = "Create new snapshot.\r\n";
            CreateSnapshotButton.Click += CreateSnapshotButton_Click;
            // 
            // WalletDataGridView
            // 
            WalletDataGridView.AllowUserToAddRows = false;
            WalletDataGridView.AllowUserToDeleteRows = false;
            WalletDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            WalletDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            WalletDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WalletDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Time, Description });
            WalletDataGridView.Dock = DockStyle.Fill;
            WalletDataGridView.Location = new Point(0, 25);
            WalletDataGridView.Margin = new Padding(4, 3, 4, 3);
            WalletDataGridView.MultiSelect = false;
            WalletDataGridView.Name = "WalletDataGridView";
            WalletDataGridView.ReadOnly = true;
            WalletDataGridView.RowTemplate.ReadOnly = true;
            WalletDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            WalletDataGridView.Size = new Size(1184, 536);
            WalletDataGridView.TabIndex = 1;
            WalletDataGridView.Click += WalletDataGridView_Click;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 75;
            // 
            // Time
            // 
            Time.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Time.HeaderText = "Time";
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.Width = 150;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // SnapshotDetailsDataGridView
            // 
            SnapshotDetailsDataGridView.AllowUserToAddRows = false;
            SnapshotDetailsDataGridView.AllowUserToDeleteRows = false;
            SnapshotDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SnapshotDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { CurrencyIcon, CurrencyName, CurrencyValue, CurrencyChange });
            SnapshotDetailsDataGridView.Dock = DockStyle.Bottom;
            SnapshotDetailsDataGridView.Location = new Point(0, 309);
            SnapshotDetailsDataGridView.MultiSelect = false;
            SnapshotDetailsDataGridView.Name = "SnapshotDetailsDataGridView";
            SnapshotDetailsDataGridView.ReadOnly = true;
            SnapshotDetailsDataGridView.RowTemplate.Height = 40;
            SnapshotDetailsDataGridView.RowTemplate.ReadOnly = true;
            SnapshotDetailsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SnapshotDetailsDataGridView.Size = new Size(1184, 252);
            SnapshotDetailsDataGridView.TabIndex = 3;
            // 
            // CurrencyIcon
            // 
            CurrencyIcon.HeaderText = "Icon";
            CurrencyIcon.ImageLayout = DataGridViewImageCellLayout.Stretch;
            CurrencyIcon.Name = "CurrencyIcon";
            CurrencyIcon.ReadOnly = true;
            CurrencyIcon.Width = 40;
            // 
            // CurrencyName
            // 
            CurrencyName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CurrencyName.HeaderText = "Name";
            CurrencyName.Name = "CurrencyName";
            CurrencyName.ReadOnly = true;
            // 
            // CurrencyValue
            // 
            CurrencyValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CurrencyValue.HeaderText = "Value";
            CurrencyValue.Name = "CurrencyValue";
            CurrencyValue.ReadOnly = true;
            // 
            // CurrencyChange
            // 
            CurrencyChange.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CurrencyChange.HeaderText = "Change";
            CurrencyChange.Name = "CurrencyChange";
            CurrencyChange.ReadOnly = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1184, 561);
            Controls.Add(SnapshotDetailsDataGridView);
            Controls.Add(WalletDataGridView);
            Controls.Add(MainWindowToolStrip);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(800, 600);
            Name = "MainWindow";
            Text = "GW2 Wallet Snapshots";
            MainWindowToolStrip.ResumeLayout(false);
            MainWindowToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WalletDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SnapshotDetailsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ToolStripDropDownButton FileDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem FileNewButton;
        private System.Windows.Forms.ToolStripMenuItem FileLoadButton;
        private System.Windows.Forms.ToolStripMenuItem FileSaveButton;
        private System.Windows.Forms.ToolStripMenuItem FileSaveAsButton;
        private System.Windows.Forms.ToolStripDropDownButton EditDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem EditConfigButton;
        private System.Windows.Forms.ToolStrip MainWindowToolStrip;
        private System.Windows.Forms.DataGridView WalletDataGridView;
        private ToolStripDropDownButton ViewDropDownButton;
        private ToolStripMenuItem ViewCurrenciesButton;
        private ToolStripButton CreateSnapshotButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Description;
        private DataGridView SnapshotDetailsDataGridView;
        private DataGridViewImageColumn CurrencyIcon;
        private DataGridViewTextBoxColumn CurrencyName;
        private DataGridViewTextBoxColumn CurrencyValue;
        private DataGridViewTextBoxColumn CurrencyChange;
    }
}

