using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GW2_Wallet_Snapshots
{
    internal class WalletSnapshot
    {
        public long Timestamp { get; set; } = 0;
        public Dictionary<uint, uint> Data { get; set; } = [];
        public string? Description { get; set; } = null;

    }
}
