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
    public partial class EditConfigWindow : Form
    {
        public EditConfigWindow()
        {
            InitializeComponent();

            SavedLabel.Hide();

            api_key_textbox.Text = Program.Config.APIKey;
        }

        private void EditConfigSaveButton_Click(object sender, EventArgs e)
        {
            Program.Config.APIKey = api_key_textbox.Text;
            Program.SaveConfig();

            SavedLabel.Show();
        }

        private void EditConfigWindow_Load(object sender, EventArgs e)
        {
            api_key_textbox.Text = Program.Config.APIKey;
        }
    }
}
