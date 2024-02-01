using System;
using System.IO;


namespace myStartApp2._0
{
    public class Storage
    {
        private string _fileName = "";
        private string _filePath = "";

        public static void Load(string data)
        {
            string filePath = "\"D:\\c#\\myStartApp2.0\\Data.txt\"";

            try
            {
                // Текст для додавання
                string contentToAdd = data;

                // Додавання тексту до існуючого файлу
                File.AppendAllText(filePath, contentToAdd);
                Console.WriteLine("Текст додано до файлу успішно!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }

        public static string UpLOad()
        {
            // TODO Load data from file 
            var data = "";
            return data;
        }

    }
}