using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Controller
{
    public static class ConverterController
    {
        public static string ConvertAnketToJson(Request anketa)
        {
            List<double> result = new List<double>();

            switch (anketa.Realty)
            {
                case "None":                    
                    result.Add(Properties.Settings.Default.RealtyMultiplier * (int)Realty.None);
                    break;
                case "House":
                    result.Add(Properties.Settings.Default.RealtyMultiplier * (int)Realty.House);
                    break;
                case "Apartment":
                    result.Add(Properties.Settings.Default.RealtyMultiplier * (int)Realty.Apartment);
                    break;
            }

            result.Add(Gender.Male.ToString() == anketa.Gender
                        ? Properties.Settings.Default.GenderMultiplier * (int)Gender.Male
                        : Properties.Settings.Default.GenderMultiplier * (int)Gender.Female);

            result.Add(Cars.No.ToString() == anketa.Gender
                        ? Properties.Settings.Default.CarMultiplier * (int)Cars.No
                        : Properties.Settings.Default.CarMultiplier * (int)Cars.Yes);

            result.Add(Marital_Status.Married.ToString() == anketa.Gender
                        ? Properties.Settings.Default.CarMultiplier * (int)Marital_Status.Married
                        : Properties.Settings.Default.CarMultiplier * (int)Marital_Status.Single);

            return ConvertToJsonString(result);
        }

        public static string ConvertToJsonString<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T ConvertToObject<T>(string json)
        {
            var obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }

        public static void SaveToFile<T>(T obj, string path)
        {
            // сохранение данных
            string st = JsonConvert.SerializeObject(obj);
            File.WriteAllText(path, st);
            Console.WriteLine("Data has been saved to file");
        }

        public static T LoadToFile<T>(string path)
        {
            // чтение данных
            string json = File.ReadAllText(path);
            var obj = JsonConvert.DeserializeObject<T>(json);
            Console.WriteLine("Data has been loaded for file");
            return obj;
        }
    }
}
