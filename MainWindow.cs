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
        private static string _coin_format = "0# | ## | ##";

        private EditConfigWindow? _edit_config_window = null;
        private CurrencyWindow? _view_currency_window = null;
        private CreateSnapshotWindow? _create_snapshot_window = null;

        public MainWindow()
        {
            InitializeComponent();

            Utilities.EnableDoubleBufferingForDataGridView(SnapshotDetailsDataGridView);
        }

        private void LoadFile(string p_path)
        {
            if (Program.Data.Load(p_path))
            {
                Program.CurrentFile = p_path;
            }
            else
            {
                Program.CurrentFile = null;
                MessageBox.Show(System.String.Join(null, "Failed to load file: ", p_path, "\n\nError:\n\n", Utilities.LastDeserializeJsonError ?? "Unknown"), "Failed to load file.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Program.CurrentFile = Program.Data.Load(p_path) ? p_path : null;

            UpdateAllSnapshotsDataGrid();
        }

        private bool SaveFile(string p_path)
        {
            if (!Program.Data.Save(p_path))
            {
                MessageBox.Show(System.String.Join(null, "Failed to save to file: ", p_path, "\n\nError:\n\n", Utilities.LastSerializeJsonError ?? "Unknown"), "Failed to save to file.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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
            int snapshot_count_before = Program.Data.Snapshots.Count;

            _create_snapshot_window = new CreateSnapshotWindow();
            _create_snapshot_window.ShowDialog();


            if (Program.Data.Snapshots.Count > snapshot_count_before)
            {
                WalletDataGridView.Rows.Add(WalletDataGridView.RowCount, DateTimeOffset.FromUnixTimeSeconds(Program.Data.Snapshots.Last().Timestamp).DateTime, Program.Data.Snapshots.Last().Description);
                WalletDataGridView.Sort(WalletDataGridView.Columns[0], ListSortDirection.Descending);
            }
        }

        private void WalletDataGridView_Click(object sender, EventArgs e)
        {
            int scroll_index = SnapshotDetailsDataGridView.FirstDisplayedScrollingRowIndex;

            SnapshotDetailsDataGridView.Rows.Clear();

            if (WalletDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            int snapshot_index = (int)WalletDataGridView.SelectedRows[0].Cells[0].Value;

            WalletSnapshot? previous_snapshot = snapshot_index > 0 ? Program.Data.Snapshots?[snapshot_index - 1] : null;
            WalletSnapshot? snapshot = Program.Data.Snapshots?[snapshot_index];

            if (snapshot == null)
            {
                return;
            }



            foreach (var currency in snapshot.Data)
            {
                GW2Currency? gw2_currency = GW2API.GetCurrencyByID(currency.Key);

                if (gw2_currency == null)
                {
                    continue;
                }

                int change = previous_snapshot != null ? (int)currency.Value - (int)previous_snapshot.Data[currency.Key] : 0;


                string value_formatted = currency.Value.ToString(currency.Key == 1 ? _coin_format : "N0");
                string change_formatted = change != 0 ? change.ToString(currency.Key == 1 ? _coin_format : "N0") : "";



                int row_index = SnapshotDetailsDataGridView.Rows.Add(gw2_currency.Icon, gw2_currency.Name, value_formatted, change_formatted);

                if (change < 0)
                {
                    SnapshotDetailsDataGridView.Rows[row_index].Cells[3].Style.ForeColor = Color.Red;
                }
                else if (change > 0)
                {
                    SnapshotDetailsDataGridView.Rows[row_index].Cells[3].Style.ForeColor = Color.Green;
                }
            }

            if (scroll_index > SnapshotDetailsDataGridView.RowCount)
            {
                SnapshotDetailsDataGridView.FirstDisplayedScrollingRowIndex = SnapshotDetailsDataGridView.RowCount;
            }
            else if (scroll_index > 0)
            {
                SnapshotDetailsDataGridView.FirstDisplayedScrollingRowIndex = scroll_index;
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
                LoadFile(openFileDialog.FileName);
            }
        }

        private void FileSaveButton_Click(object sender, EventArgs e)
        {
            if (Program.CurrentFile != null || Program.CurrentFile == "")
            {
                SaveFile(Program.CurrentFile);
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

            if (saveFileDialog.ShowDialog() == DialogResult.OK && SaveFile(saveFileDialog.FileName))
            {
                Program.CurrentFile = saveFileDialog.FileName;
            }
        }

        private void MainWindow_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                return;
            }

            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                string? item = e.Data.GetData(DataFormats.Text)?.ToString();

                if (item != null && (e.Effect == DragDropEffects.Copy || e.Effect == DragDropEffects.Move))
                {
                    LoadFile(item);
                }
            }
        }

        private void SnapshotDetailsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            SnapshotDetailsDataGridView.ClearSelection();
        }
    }
}
