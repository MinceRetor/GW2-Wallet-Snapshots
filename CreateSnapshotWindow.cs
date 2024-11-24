using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GW2_Wallet_Snapshots
{
    public partial class CreateSnapshotWindow : Form
    {
        public CreateSnapshotWindow()
        {
            InitializeComponent();
        }

        private void CreateSnapshotButton_Click(object sender, EventArgs e)
        {
            WalletSnapshot? snapshot = GW2API.GetWalletState(Program.Config.APIKey);

            if (snapshot == null)
            {
                return;
            }

            snapshot.Description = SnapshotDescriptionTextBox.Text;

            Program.Data.Snapshots.Add(snapshot);

            Close();
        }
    }
}
