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
        public static string? LastSerializeJsonError { get; private set; } = null;
        public static string? LastDeserializeJsonError { get; private set; } = null;

        public static void EnableDoubleBufferingForDataGridView(DataGridView p_datagridview)
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, p_datagridview, new object[] { true });
        }

        public static bool SerializeJsonToStream<T>(T p_object, Stream p_stream)
        {
            try
            {
                JsonSerializerOptions options = new();
                options.WriteIndented = true;

                string json = JsonSerializer.Serialize(p_object, options);

                StreamWriter writer = new(p_stream);

                writer.Write(json);
                writer.Flush();
                writer.Close();

                LastSerializeJsonError = null;
                return true;
            }
            catch (Exception e)
            {
                LastSerializeJsonError = e.Message;
                return false;
            }
        }

        public static bool SerializeJsonToFile<T>(T p_object, string p_path)
        {
            try
            {
                FileStream filestream = File.Open(p_path, FileMode.Create);

                bool result = SerializeJsonToStream(p_object, filestream);

                filestream.Close();

                LastSerializeJsonError = null;
                return result;
            }
            catch (Exception e)
            {
                LastSerializeJsonError = e.Message;
                return false;
            }
        }

        public static T? DeserializeJsonFromStream<T>(Stream p_stream)
        {
            try
            {
                using(StreamReader reader = new(p_stream))
                {
                    string json = reader.ReadToEnd();

                    reader.Close();

                    LastDeserializeJsonError = null;
                    return JsonSerializer.Deserialize<T>(json);
                }
            }
            catch (Exception e)
            {
                LastDeserializeJsonError = e.Message;
                return default(T);
            }
        }

        public static T? DeserializeJsonFromFile<T>(string p_path)
        {
            try
            {
                FileStream filestream = File.Open(p_path, System.IO.FileMode.Open);

                T? result = DeserializeJsonFromStream<T>(filestream);

                filestream.Close();

                if(result != null)
                {
                    LastDeserializeJsonError = null;
                }

                return result;
            }
            catch (Exception e)
            {
                LastDeserializeJsonError = e.Message;
                return default(T);
            }
        }
    }
}
