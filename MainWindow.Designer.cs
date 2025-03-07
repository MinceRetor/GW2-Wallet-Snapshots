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
            components = new System.ComponentModel.Container();
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
            TimerLabel = new ToolStripLabel();
            WalletDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            SnapshotDetailsDataGridView = new DataGridView();
            CurrencyIcon = new DataGridViewImageColumn();
            CurrencyName = new DataGridViewTextBoxColumn();
            CurrencyValue = new DataGridViewTextBoxColumn();
            CurrencyChange = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            TimerSnapshot = new System.Windows.Forms.Timer(components);
            MainWindowToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WalletDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SnapshotDetailsDataGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            FileNewButton.Size = new Size(114, 22);
            FileNewButton.Text = "New";
            FileNewButton.Click += FileNewButton_Click;
            // 
            // FileLoadButton
            // 
            FileLoadButton.Name = "FileLoadButton";
            FileLoadButton.Size = new Size(114, 22);
            FileLoadButton.Text = "Load";
            FileLoadButton.Click += FileLoadButton_Click;
            // 
            // FileSaveButton
            // 
            FileSaveButton.Name = "FileSaveButton";
            FileSaveButton.Size = new Size(114, 22);
            FileSaveButton.Text = "Save";
            FileSaveButton.Click += FileSaveButton_Click;
            // 
            // FileSaveAsButton
            // 
            FileSaveAsButton.Name = "FileSaveAsButton";
            FileSaveAsButton.Size = new Size(114, 22);
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
            MainWindowToolStrip.Items.AddRange(new ToolStripItem[] { FileDropDownButton, EditDropDownButton, ViewDropDownButton, CreateSnapshotButton, TimerLabel });
            MainWindowToolStrip.Location = new Point(0, 0);
            MainWindowToolStrip.Name = "MainWindowToolStrip";
            MainWindowToolStrip.Size = new Size(984, 25);
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
            // TimerLabel
            // 
            TimerLabel.Alignment = ToolStripItemAlignment.Right;
            TimerLabel.ForeColor = Color.Red;
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(37, 22);
            TimerLabel.Text = "Timer";
            TimerLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // WalletDataGridView
            // 
            WalletDataGridView.AllowUserToAddRows = false;
            WalletDataGridView.AllowUserToDeleteRows = false;
            WalletDataGridView.AllowUserToResizeRows = false;
            WalletDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            WalletDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WalletDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Time, Description });
            WalletDataGridView.Dock = DockStyle.Fill;
            WalletDataGridView.Location = new Point(4, 3);
            WalletDataGridView.Margin = new Padding(4, 3, 4, 3);
            WalletDataGridView.MultiSelect = false;
            WalletDataGridView.Name = "WalletDataGridView";
            WalletDataGridView.ReadOnly = true;
            WalletDataGridView.RowHeadersVisible = false;
            WalletDataGridView.RowTemplate.ReadOnly = true;
            WalletDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            WalletDataGridView.Size = new Size(484, 430);
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
            SnapshotDetailsDataGridView.AllowUserToResizeRows = false;
            SnapshotDetailsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            SnapshotDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SnapshotDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { CurrencyIcon, CurrencyName, CurrencyValue, CurrencyChange });
            SnapshotDetailsDataGridView.Dock = DockStyle.Fill;
            SnapshotDetailsDataGridView.Location = new Point(495, 3);
            SnapshotDetailsDataGridView.MultiSelect = false;
            SnapshotDetailsDataGridView.Name = "SnapshotDetailsDataGridView";
            SnapshotDetailsDataGridView.ReadOnly = true;
            SnapshotDetailsDataGridView.RowHeadersVisible = false;
            SnapshotDetailsDataGridView.RowTemplate.Height = 40;
            SnapshotDetailsDataGridView.RowTemplate.ReadOnly = true;
            SnapshotDetailsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SnapshotDetailsDataGridView.Size = new Size(486, 430);
            SnapshotDetailsDataGridView.TabIndex = 3;
            SnapshotDetailsDataGridView.SelectionChanged += SnapshotDetailsDataGridView_SelectionChanged;
            // 
            // CurrencyIcon
            // 
            CurrencyIcon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CurrencyIcon.HeaderText = "Icon";
            CurrencyIcon.ImageLayout = DataGridViewImageCellLayout.Stretch;
            CurrencyIcon.MinimumWidth = 15;
            CurrencyIcon.Name = "CurrencyIcon";
            CurrencyIcon.ReadOnly = true;
            CurrencyIcon.Resizable = DataGridViewTriState.False;
            CurrencyIcon.Width = 35;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(WalletDataGridView, 0, 0);
            tableLayoutPanel1.Controls.Add(SnapshotDetailsDataGridView, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(984, 436);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // TimerSnapshot
            // 
            TimerSnapshot.Interval = 1000;
            TimerSnapshot.Tick += TimerSnapshot_Tick;
            // 
            // MainWindow
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(MainWindowToolStrip);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(400, 400);
            Name = "MainWindow";
            Text = "GW2 Wallet Snapshots";
            DragDrop += MainWindow_DragDrop;
            MainWindowToolStrip.ResumeLayout(false);
            MainWindowToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WalletDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SnapshotDetailsDataGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewImageColumn CurrencyIcon;
        private DataGridViewTextBoxColumn CurrencyName;
        private DataGridViewTextBoxColumn CurrencyValue;
        private DataGridViewTextBoxColumn CurrencyChange;
        private ToolStripLabel TimerLabel;
        private System.Windows.Forms.Timer TimerSnapshot;
    }
}

