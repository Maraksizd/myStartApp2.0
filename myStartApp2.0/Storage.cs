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

        public static void CreatFail(string path)
        {
            File.Create(path).Close();
            Console.WriteLine("File created");
        }

        public static void Load(string data)
        {
            if (FileExists(FilePath))
            {
                Console.WriteLine("Файл за вказаною адресею існує, виконуємо завантаження...");

                File.AppendAllText(FilePath, data);

                Console.WriteLine("Текст додано до файлу успішно!");
            }
            else
            {
                Console.WriteLine("Файл за вказаною адресею Не існує, створюємо файл...");

                CreatFail(FilePath);

                Console.WriteLine("Виконуємо завантаження...");
                File.AppendAllText(FilePath, data);

                Console.WriteLine("Текст додано до файлу успішно!");
            }
        }

        public static string UpLoad()
        {
            var data = "";

            if (File.Exists(FilePath))
            {
                Console.WriteLine("Файл існує.");

                data = File.ReadAllText(FilePath);
                
                if (data.Length < 104)
                {
                    Console.WriteLine("Fatal error, file void");
                }

                //Storage.DeleteFail("D:\\c#\\myStartApp2.0\\Data.txt");

            }
            else
            {
                Console.WriteLine("Файл не знайдений.");
            }

            return data;
        }

    }
}