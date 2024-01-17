using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    internal class FileUtility
    {
        public static T? ReadDataFromFile<T>(string path) { 
            try
            {
                using StreamReader sr = new StreamReader("data/" + path);
                string data = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(data, 
                    new JsonSerializerSettings
                    {
                        TypeNameHandling= TypeNameHandling.All,
                        TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Full
                    });
            }
            catch(FileNotFoundException ex) { }
            return default;
        }

        public static void WriteDateToFile<T>(T data, string path)
        {
            using StreamWriter sr = new StreamWriter("data/" + path);
            string json = JsonConvert.SerializeObject(data, Formatting.Indented, 
                new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Full
                });
            sr.Write(json);
        }
    }
}
