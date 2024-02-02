using System;
using System.IO;


namespace myStartApp2._0
{
    public class Storage
    {
        public static void Load(string data)
        {
            string filePath = "D:\\c#\\myStartApp2.0\\Data.txt";

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

        public static string UpLoad()
        {
            var data = "";

            string filePath = "D:\\c#\\myStartApp2.0\\Data.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error. File not found!");
            }
            else
            {
                try
                {
                    // Зчитуємо вміст файлу у змінну data
                    data = File.ReadAllText(filePath);

                    // Виводимо зчитані дані на екран
                    Console.WriteLine("File content:");
                    Console.WriteLine(data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error reading file:" + ex.Message);
                }
            }

            return data;
        }

    }
}