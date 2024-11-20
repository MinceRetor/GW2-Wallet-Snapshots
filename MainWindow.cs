using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GW2_Wallet_Snapshots
{
    public partial class MainWindow : Form
    {
        private static string _file_filter = "GW2 Wallet Snapshots File (*.gw2ws)|*.gw2ws";

        private EditConfigWindow? _edit_config_window = null;
        private CurrencyWindow? _view_currency_window = null;

        public MainWindow()
        {
            InitializeComponent();

            Utilities.EnableDoubleBufferingForDataGridView(SnapshotDetailsDataGridView);
        }

        private void UpdateAllSnapshotsDataGrid()
        {
            if (Program.Data.Snapshots == null)
            {
                return;
            }

            WalletDataGridView.Rows.Clear();

            int index = 0;

            foreach (var snapshot in Program.Data.Snapshots)
            {
                WalletDataGridView.Rows.Add(index, DateTimeOffset.FromUnixTimeSeconds(snapshot.Timestamp).DateTime, snapshot.Description);
                index++;
            }

            WalletDataGridView.Sort(WalletDataGridView.Columns[0], ListSortDirection.Descending);
        }

        private void EditConfigButton_Click(object sender, EventArgs e)
        {
            _edit_config_window = new EditConfigWindow();
            _edit_config_window.ShowDialog();
        }

        private void ViewCurrenciesButton_Click(object sender, EventArgs e)
        {
            _view_currency_window = new CurrencyWindow();
            _view_currency_window.ShowDialog();
        }

        private void CreateSnapshotButton_Click(object sender, EventArgs e)
        {
            GW2WalletSnapshot? snapshot = GW2API.GetWalletState(Program.Config.APIKey);

            if (snapshot == null)
            {
                return;
            }

            Program.Data.Snapshots?.Add(snapshot);

            WalletDataGridView.Rows.Add(WalletDataGridView.RowCount, DateTimeOffset.FromUnixTimeSeconds(snapshot.Timestamp).DateTime, snapshot.Description);

            WalletDataGridView.Sort(WalletDataGridView.Columns[0], ListSortDirection.Descending);
        }

        private void WalletDataGridView_Click(object sender, EventArgs e)
        {
            SnapshotDetailsDataGridView.Rows.Clear();

            if (WalletDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            GW2WalletSnapshot? snapshot = Program.Data.Snapshots?[(int)WalletDataGridView.SelectedRows[0].Cells[0].Value];

            if (snapshot == null)
            {
                return;
            }


            foreach (var currency in snapshot.Data)
            {
                GW2Currency? gw2_currency = GW2API.GetCurrencyByID(currency.ID);

                if (gw2_currency == null)
                {
                    continue;
                }

                SnapshotDetailsDataGridView.Rows.Add(gw2_currency.Icon, gw2_currency.Name, currency.Value, 0);
            }
        }

        private void FileNewButton_Click(object sender, EventArgs e)
        {
            Program.Data.Clear();
            Program.CurrentFile = null;

            WalletDataGridView.Rows.Clear();
            SnapshotDetailsDataGridView.Rows.Clear();
        }

        private void FileLoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = _file_filter;
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Program.CurrentFile = openFileDialog.FileName;
                Program.Data.Load(openFileDialog.FileName);

                UpdateAllSnapshotsDataGrid();
            }
        }

        private void FileSaveButton_Click(object sender, EventArgs e)
        {
            if(Program.CurrentFile != null)
            {
                Program.Data.Save(Program.CurrentFile);
                return;
            }

            FileSaveAsButton_Click(sender, e);
        }

        private void FileSaveAsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new();

            saveFileDialog.Filter = _file_filter;
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Program.Data.Save(saveFileDialog.FileName);
                Program.CurrentFile = saveFileDialog.FileName;
            }
        }
    }
}
