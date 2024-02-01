//main fail
using System;


namespace myStartApp2._0
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Доброго дня!");
            Console.WriteLine("Ввас вітає наша програма!");

            Client myClient = Client.Create();

            var s = Initialise.MakeService();
            var p = Payment.Create(s);
            //myClient.Payments.

            Console.WriteLine("Щоб розпочати роботу виберіть метод роботи:");
            Console.WriteLine("1. Додати показник");
            Console.WriteLine("2. Переглянути статистику");

            int chooseMethod = Convert.ToInt32(Console.ReadLine());
            if (chooseMethod != 1 && chooseMethod != 2)
            {
                throw new ArgumentException("chooseMethod must be 1 or 2.");
            }

            switch (chooseMethod)
            {
                case 1:
                    int isValid = 1;

                    while (isValid == 1)
                    {
                        var service = Initialise.MakeService();

                        Payment payment = Payment.Create(service);

                        Client client = Client.Create();
                        client.AddPayment(payment);

                        Console.WriteLine("Введіть 1 якщо ви хочете додати ще один показник");
                        Console.WriteLine("Введіть 2 якщо ви задоволенні роботою:");
                        isValid = Int32.Parse(Console.ReadLine());
                    }

                    int permissionToSave = 0;

                    Console.WriteLine("Зберегти данні?");
                    Console.WriteLine("1-так");
                    Console.WriteLine("2-ні");
                    permissionToSave = Int32.Parse(Console.ReadLine());

                    if (permissionToSave == 1)
                    {

                    }
                    else if (permissionToSave == 2)
                    {

                    }
                    else
                    {

                    }

                    break;
                    

                case 2:
                    //analitics
                    break;

                default:
                    Console.WriteLine("chooseMethod must be 1 or 2.");
                    break;
            }
        }
    }
}