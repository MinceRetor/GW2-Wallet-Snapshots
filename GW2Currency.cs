using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GW2_Wallet_Snapshots
{
    internal class GW2Currency
    {
        [JsonPropertyName("id")]
        public uint ID { get; set; } = 0;

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("description")]
        public string Description { get; set; } = "";

        [JsonPropertyName("icon")]
        public string? IconURL { get; set; } = null;

        public string? IconPath { get; set; } = null;

        public Bitmap? Icon { get; set; } = null;

        [JsonPropertyName("order")]
        public int Order { get; set; } = 0;
    }
}
