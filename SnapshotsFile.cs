using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GW2_Wallet_Snapshots
{
    internal class SnapshotsFile
    {
        public string User { get; set; } = "";

        public List<WalletSnapshot> Snapshots { get; set; } = [];

        public bool Load(string p_path)
        {
            Clear();

            SnapshotsFile? deserialized_data = Utilities.DeserializeJsonFromFile<SnapshotsFile>(p_path);

            if (deserialized_data == null)
            {
                return false;
            }

            User = deserialized_data.User;
            Snapshots = deserialized_data.Snapshots;
            return true;
        }

        public bool Save(string p_path)
        {
            return Utilities.SerializeJsonToFile(this, p_path);
        }

        public void Clear()
        {
            User = "";
            Snapshots.Clear();
        }
    }
}
