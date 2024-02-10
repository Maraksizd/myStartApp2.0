using System;
using System.Collections.Generic;

namespace myStartApp2._0
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Payment> Payments { get; set; }

        public static Client InitializationClient(int id)
        {
            Client client = new Client
            {
                Id = id
            };
            Console.WriteLine("Введіть своє імя:");
            string name = Console.ReadLine();
            client.Name = name;

            Console.WriteLine("Введіть вашу адресу:");
            string address = Console.ReadLine();
            client.Address = address;

            client.Payments = new List<Payment>();

            return client;
        }

        public static Client ManageClientSelection(Data data)
        {
            int clientId = 0;
            Client currentClient = null;

            Console.WriteLine("Ви бажаєте створити нового клієнта, чи працювати з наявним?");
            Console.WriteLine("1-Створити нового");
            Console.WriteLine("2-Вибрати наявного");

            int clientChoice = Int32.Parse(Console.ReadLine());

            switch (clientChoice)
            {
                case 1:
                    if (data.ClientsList != null)
                    {
                        clientId = data.ClientsList.Count;
                    }

                    currentClient = Client.InitializationClient(clientId);
                    data.ClientsList.Add(currentClient);
                    break;

                case 2:
                    Console.WriteLine("Список наявних клієнтів:");
                    for (int i = 0; i < data.ClientsList.Count; i++)
                    {
                        Console.WriteLine(data.ClientsList[i].Id + " " + data.ClientsList[i].Name);
                    }
                    Console.WriteLine("Виберіть бажаного клієнта:");

                    clientId = int.Parse(Console.ReadLine());
                    clientId--;
                    if (clientId >= 0 && clientId < data.ClientsList.Count)
                    {
                        currentClient = data.ClientsList[clientId];
                    }
                    else
                    {
                        Console.WriteLine("Некоректний індекс клієнта.");
                    }
                    break;

                default:
                    Console.WriteLine("Дані введенно не коректно!");
                    break;
            }
            return currentClient;
        }
    }

}