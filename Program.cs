using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace GW2_Wallet_Snapshots
{
    internal static class Program
    {
        private static string _config_file_path = "config.json";


        [STAThread]
        static void Main()
        {
            System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            LoadConfig();

            GW2API.InitCurrencies();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        public static void SaveConfig()
        {
            Config.Save(_config_file_path);
        }

        public static bool LoadConfig()
        {
            return Config.Load(_config_file_path);
        }

        public static ProgramConfig Config { get; set; } = new();
        public static SnapshotsFile Data { get; set; } = new();
        public static string? CurrentFile { get; set; } = null;
    }
}
