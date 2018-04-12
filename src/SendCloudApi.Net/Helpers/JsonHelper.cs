using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace SendCloudApi.Net.Helpers
{
    /// <summary>
    /// Summary description for JsonHelper
    /// </summary>
    public class JsonHelper
    {
        public static string Serialize<T>(T obj, string dateTimeFormat)
        {
            string retVal;
            var serializer = new DataContractJsonSerializer(typeof(T), new DataContractJsonSerializerSettings { DateTimeFormat = new DateTimeFormat(dateTimeFormat) });
            using (var ms = new MemoryStream())
            {
                serializer.WriteObject(ms, obj);
                retVal = Encoding.UTF8.GetString(ms.ToArray());
            }
            return retVal;
        }

        public static T Deserialize<T>(string json, string dateTimeFormat)
        {
            T obj;
            var serializer = new DataContractJsonSerializer(typeof(T), new DataContractJsonSerializerSettings { DateTimeFormat = new DateTimeFormat(dateTimeFormat) });
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                obj = (T)serializer.ReadObject(ms);
                ms.Close();
            }
            return obj;
        }

        public static Dictionary<string, T> DeserializeAsDictionary<T>(string json, string dateTimeFormat)
        {
            Dictionary<string, T> obj;
            var serializer = new DataContractJsonSerializer(typeof(Dictionary<string, T>), new DataContractJsonSerializerSettings { DateTimeFormat = new DateTimeFormat(dateTimeFormat), UseSimpleDictionaryFormat = true });
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                obj = (Dictionary<string, T>)serializer.ReadObject(ms);
                ms.Close();
            }
            return obj;
        }
    }
}