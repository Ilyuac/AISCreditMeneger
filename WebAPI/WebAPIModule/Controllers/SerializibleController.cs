using Newtonsoft.Json;
using System;
using System.IO;

namespace WebAPIModule.Controllers
{
    /// <summary>
    /// Класс для конвертации JSON
    /// </summary>
    public static class SerializibleController
    {
        /// <summary>
        /// Преобразование в JSON строку.
        /// </summary>
        /// <typeparam name="T">Тип преобразовываемого объекта.</typeparam>
        /// <param name="obj">Объект, который будет преобразован.</param>
        /// <returns>JSON строка.</returns>
        public static string ConvertToJsonString<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// Преобразование JSON строки в объект.
        /// </summary>
        /// <typeparam name="T">Тип в который необходимо преобразовать строку.</typeparam>
        /// <param name="json">Строка.</param>
        /// <returns>Объект в который будет прообразована строка.</returns>
        public static T ConvertToObject<T>(string json)
        {
            var obj = JsonConvert.DeserializeObject<T>(json);

            return obj;
        }

        /// <summary>
        /// Сохранение объекта в файл в формате JSON.
        /// </summary>
        /// <typeparam name="T">Тип объекта, который необходимо сохранить.</typeparam>
        /// <param name="obj">Объект, который необходимо сохранить.</param>
        /// <param name="path">Путь к файлу.</param>
        public static void Save<T>(T obj, string path)
        {
            string st = JsonConvert.SerializeObject(obj);
            File.WriteAllText(path, st);
            Console.WriteLine("Data has been saved to file");
        }

        /// <summary>
        /// Загрузка объекта из файла.
        /// </summary>
        /// <typeparam name="T">Тип объекта в который необходимо загрузить.</typeparam>
        /// <param name="path">Путь к файлу.</param>
        /// <returns>Обект, который был загружен.</returns>
        public static T Load<T>(string path)
        {
            string json = File.ReadAllText(path);
            var obj = JsonConvert.DeserializeObject<T>(json);
            Console.WriteLine("Data has been loaded for file");

            return obj;
        }
    }
}
