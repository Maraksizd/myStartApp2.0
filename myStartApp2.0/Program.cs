//main fail
using System;

namespace myStartApp2._0
{
    internal class Program
    {
        static int Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Доброго дня!");
            Console.WriteLine("Вас вітає наша програма!");

            Data data = Data.InitTestData(); //створюємо тестову дату

            Client currentClient = Client.ManageClientSelection(data);

            if (currentClient == null)
            {
                Console.WriteLine("Клієнт не вибраний або не створений.");
                return 0;
            }   //перевірка чи клієнта обрано і чи він створений

            Console.WriteLine("Щоб розпочати роботу виберіть метод роботи:");
            Console.WriteLine("1. Додати показник");
            Console.WriteLine("2. Аналітика");

            int chooseMethod = Convert.ToInt32(Console.ReadLine());

            switch (chooseMethod)
            {
                case 1:
                    int isValid = 0;
                    int permissionToSave;

                    while (isValid == 0)
                    {
                        var service = Service.MakeService();
                        Payment payment = Payment.Create(service);

                        currentClient.Payments.Add(payment);

                        Console.WriteLine("Введіть 1, якщо ви хочете додати ще один показник");
                        Console.WriteLine("Введіть 2, якщо ви задоволені роботою:");

                        isValid = Int32.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Зберегти дані?");
                    Console.WriteLine("1-так");
                    Console.WriteLine("2-ні");

                    permissionToSave = Int32.Parse(Console.ReadLine());

                    if (permissionToSave == 1)
                    {
                        Data.Serialize(data);
                    }
                    else if (permissionToSave == 2)
                    {
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("Дані були введені некоректно!");
                        return 0;
                    }

                    break;

                case 2:
                    int choiseMethodStatistaic = 0;
                    Console.WriteLine("Виберіть:");
                    Console.WriteLine("1) Вивід статистики");
                    Console.WriteLine("2) Перегляд оплат");
                    choiseMethodStatistaic= Int32.Parse(Console.ReadLine());

                    switch (choiseMethodStatistaic)
                    {
                        case 1:
                            DataAnalytics.Stats(currentClient);
                            break;

                        case 2:
                            DataAnalytics.PrintInfo(currentClient);
                            break;

                        default:
                            Console.WriteLine("Помилка вибору");
                            return 0;
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Метод повинен бути 1 або 2.");
                    break;
            }
            return 0;
        }


    }
}