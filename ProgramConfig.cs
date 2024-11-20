using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace GW2_Wallet_Snapshots
{
    internal class ProgramConfig
    {
        public string APIKey { get; set; } = "";

        public bool Save(string p_path)
        {
            return Utilities.SerializeJsonToFile(this, p_path);
        }

        public bool Load(string p_path)
        {
            ProgramConfig? deserialized_data = Utilities.DeserializeJsonFromFile<ProgramConfig>(p_path);

            if (deserialized_data == null)
            {
                APIKey = "";
                return false;
            }

            APIKey = deserialized_data.APIKey;
            return true;
        }
    }
}
