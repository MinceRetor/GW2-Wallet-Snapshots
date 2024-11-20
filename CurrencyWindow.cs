using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GW2_Wallet_Snapshots
{
    public partial class CurrencyWindow : Form
    {
        public CurrencyWindow()
        {
            InitializeComponent();

            Utilities.EnableDoubleBufferingForDataGridView(CurrencyDataGridView);
        }

        private void CurrencyWindow_Load(object sender, EventArgs e)
        {
            CurrencyDataGridView.Rows.Clear();

            foreach(GW2Currency currency in GW2API.GetCurrencies())
            {
                CurrencyDataGridView.Rows.Add(currency.ID, currency.Order, currency.Icon, currency.Name, currency.Description);
            }
        }
    }
}
