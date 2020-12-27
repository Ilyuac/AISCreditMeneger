using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace ServiceCon.Data.Controllers
{
    public abstract class SerializibleController
    {
        public static async void SaveAsync<T>(T obj, string path)
        {
            // сохранение данных
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<T>(fs, obj);
            }
            Console.WriteLine("Data has been saved to file");
            throw new Exception("Data has been saved to file");
        }

        public static async Task<T> LoadAsync<T>(string path)
        {
            // чтение данных
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                T restoredPerson = await JsonSerializer.DeserializeAsync<T>(fs);
                return restoredPerson;
            }
        }

        public static void Save<T>(T obj, string path)
        {
            // сохранение данных
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                 JsonSerializer.SerializeAsync<T>(fs, obj);
                Console.WriteLine("Data has been saved to file");
            }
        }
    }
}
