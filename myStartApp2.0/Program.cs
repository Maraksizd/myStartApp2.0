//main fail
using System;
using System.Collections.Generic;
using System.Text.Json;


namespace myStartApp2._0
{

    internal class Program
    {
        static int Main()
        {


            Console.WriteLine("Доброго дня!");
            Console.WriteLine("Ввас вітає наша програма!");

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            int clientId = 0;
            int clientChoise = 0;
            Data data = Data.Deserialize();

            Console.WriteLine("Ви бажаєте створити нового клієнта, чи працювати з наявним?");
            Console.WriteLine("1-Створити нового");
            Console.WriteLine("2-Вибрати наявного");

            clientChoise = Int32.Parse(Console.ReadLine());

            switch (clientChoise)
            {
                case 1:
                    if (data.ClientsList != null)
                    {
                        clientId = data.ClientsList.Count - 1;

                    }

                    Client curentClient = Client.InitializationClient(clientId);
                    data.ClientsList.Add(curentClient);
                  
                    break;

                case 2:
                    Console.WriteLine("Список наявних клієнтів:");
                    for (int i = 0; data.ClientsList.Count > i; i++)
                    {
                        Console.WriteLine(data.ClientsList[i].Id + " " + data.ClientsList[i].Name);
                    }
                    Console.WriteLine("Виберіть бажаного клієнта:");

                    clientId=int .Parse(Console.ReadLine());
                    break;

                default:
                    Console.WriteLine("Данні введенно не коректно!");
                    break;
            }

            Console.WriteLine("Щоб розпочати роботу виберіть метод роботи:");
            Console.WriteLine("1. Додати показник");
            Console.WriteLine("2. Переглянути статистику");

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

                        data.ClientsList[clientId].Payments.Add(payment);

                        Console.WriteLine("Введіть 1 якщо ви хочете додати ще один показник");
                        Console.WriteLine("Введіть 2 якщо ви задоволенні роботою:");
                        isValid = Int32.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Зберегти данні?");
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
                        Console.WriteLine("Данні були введені не коректно!");
                        return 0;
                    }
                    //load data to txt

                    break;

                case 2:
                    

                case 2:
                    var data = Data.Deserialize();
                    Console.WriteLine(data);

                    break;

                default:
                    Console.WriteLine("chooseMethod must be 1 or 2.");
                    break;
            }

            return 0;
        }

    }
}