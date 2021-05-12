using Newtonsoft.Json;
using System;
using System.IO;

namespace WebAPIModule.Controllers
{
    public static class SerializibleController
    {
        public static string ConvertToJsonString<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T ConvertToObject<T>(string json)
        {
            var obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }

        public static void Save<T>(T obj, string path)
        {
            // сохранение данных
            string st = JsonConvert.SerializeObject(obj);
            File.WriteAllText(path, st);
            Console.WriteLine("Data has been saved to file");
        }

        public static T Load<T>(string path)
        {
            // чтение данных
            string json = File.ReadAllText(path);
            var obj = JsonConvert.DeserializeObject<T>(json);
            Console.WriteLine("Data has been loaded for file");
            return obj;
        }
    }
}
