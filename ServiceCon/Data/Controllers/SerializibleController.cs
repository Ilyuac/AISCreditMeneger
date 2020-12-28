using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ServiceCon.Data.Controllers
{
    public abstract class SerializibleController
    {
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
            return obj;
        }
    }
}
