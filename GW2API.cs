using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace GW2_Wallet_Snapshots
{
    internal class GW2API
    {
        private static string _cache_directory = "cache";
        private static string _api_url_currencies = "https://api.guildwars2.com/v2/currencies?ids=all";
        private static string _api_url_wallet = "https://api.guildwars2.com/v2/account/wallet";

        private static GW2Currency[]? _currencies = null;
        private static Dictionary<uint, GW2Currency> _currencies_dictionary = [];

        private static string RequestJSON(string p_url, string? p_api_key = null)
        {
            try
            {
                if (p_api_key != null)
                {
                    p_url = String.Concat(p_url, "?access_token=", p_api_key);
                }

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(p_url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

                return reader.ReadToEnd();
            }
            catch
            {
                return "";
            }
        }

        public static GW2WalletSnapshot? GetWalletState(string p_api_key)
        {
            try
            {
                string json = RequestJSON(_api_url_wallet, p_api_key);

                GW2WalletSnapshot wallet = new();
                wallet.Data = JsonSerializer.Deserialize<GW2WalletSnapshot.WalletData[]>(json)!;
                wallet.Timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                return wallet;
            }
            catch 
            {
                return null;
            }
        }

        public static GW2Currency[] GetCurrencies()
        {
            if(_currencies == null)
            {
                InitCurrencies();
            }

            return _currencies!;
        }

        public static GW2Currency? GetCurrencyByID(uint p_id)
        {
            if(_currencies == null)
            {
                return null;
            }

            GW2Currency? currency;

            if(_currencies_dictionary.TryGetValue(p_id, out currency))
            {
                return currency;
            }

            return null;
        }

        public static void InitCurrencies()
        {
            try
            {
                _currencies = JsonSerializer.Deserialize<GW2Currency[]>(RequestJSON(_api_url_currencies))!;

                foreach(GW2Currency currency in _currencies)
                {
                    _currencies_dictionary.Add(currency.ID, currency);
                }
            }
            catch
            {
                _currencies = [];
                return;
            }

            if (!Directory.Exists(_cache_directory))
            {
                Directory.CreateDirectory(_cache_directory);
            }

            WebClient web = new();

            foreach (GW2Currency currency in _currencies)
            {
                string icon_path = String.Concat(_cache_directory, '/', currency.ID.ToString(), ".png");

                
                if (!File.Exists(icon_path) && currency.IconURL != null)
                {
                    web.DownloadFile(currency.IconURL, icon_path);
                }


                if (File.Exists(icon_path))
                {
                    currency.Icon = new Bitmap(icon_path);
                    currency.IconPath = icon_path;
                }
            }
        }
    }
}
