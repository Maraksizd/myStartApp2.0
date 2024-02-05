using System;
using System.IO;


namespace myStartApp2._0
{
    public class Storage
    {
        private const string FilePath = "D:\\c#\\myStartApp2.0\\Data.txt";

        public static bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        } // перевірка на наявньсьть такого файлу

        public static void DeleteFail(string path)
        {
            File.Delete(path);
            Console.WriteLine("File delete");
        }

        public static void CreateFile(string path)
        {
            File.Create(path).Close();
            Console.WriteLine("File created");
        }

        public static void Save(string data)
        {
            if (!FileExists(FilePath))
            {
                CreateFile(FilePath);
                Console.WriteLine("Виконуємо запис...");
            }
            
            File.WriteAllText(FilePath, data);
            Console.WriteLine("Текст додано до файлу успішно!");
        }

        public static string Load()
        {
            if (File.Exists(FilePath))
            {
                Console.WriteLine("Файл існує.");

                var data = File.ReadAllText(FilePath);

                if (data.Length < 104)
                {
                    Console.WriteLine("Fatal error, file void");
                    return "";
                }

                return data;
                //Storage.DeleteFail("D:\\c#\\myStartApp2.0\\Data.txt");

            }
            else
            {
                Console.WriteLine("Файл не знайдений.");
            }

            return "";
        }

    }
}