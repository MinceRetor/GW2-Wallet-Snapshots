using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GW2_Wallet_Snapshots
{
    internal class Utilities
    {
        public static void EnableDoubleBufferingForDataGridView(DataGridView p_datagridview)
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, p_datagridview, new object[] { true });
        }

        public static bool SerializeJsonToStream<T>(T p_object, Stream p_stream)
        {
            try
            {
                string json = JsonSerializer.Serialize(p_object);

                StreamWriter writer = new(p_stream);

                writer.Write(json);
                writer.Flush();
                writer.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SerializeJsonToFile<T>(T p_object, string p_path)
        {
            try
            {
                return SerializeJsonToStream(p_object, File.Open(p_path, FileMode.CreateNew));
            }
            catch 
            {
                return false;
            }
        }

        public static T? DeserializeJsonFromStream<T>(Stream p_stream)
        {
            try
            {
                StreamReader reader = new StreamReader(p_stream);

                string json = reader.ReadToEnd();

                reader.Close();

                T? deserialized_object = JsonSerializer.Deserialize<T>(json);

                return deserialized_object;
            }
            catch
            {
                return default(T);
            }
        }

        public static T? DeserializeJsonFromFile<T>(string p_path)
        {
            try
            {
                return DeserializeJsonFromStream<T>(File.Open(p_path, System.IO.FileMode.Open));
            }
            catch
            {
                return default(T);
            }
        }
    }
}
