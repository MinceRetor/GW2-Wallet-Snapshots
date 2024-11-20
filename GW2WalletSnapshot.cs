using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GW2_Wallet_Snapshots
{
    internal class GW2WalletSnapshot
    {
        public class WalletData
        {
            [JsonPropertyName("id")]
            public uint ID { get; set; } = 0;

            [JsonPropertyName("value")]
            public uint Value { get; set; } = 0;
        }

        public long Timestamp { get; set; } = 0;

        public WalletData[] Data { get; set; } = [];

        public string? Description { get; set; } = null;
    }
}
