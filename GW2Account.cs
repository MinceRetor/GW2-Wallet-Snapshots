using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GW2_Wallet_Snapshots
{
    internal class GW2Account
    {
        public string APIKey { get; set; } = "";

        [JsonPropertyName("id")]
        public string ID { get; set; } = "";

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";
    }
}
