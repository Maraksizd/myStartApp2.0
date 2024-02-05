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
            Console.WriteLine("Ввас вітає наша програма!");

            Client myClient = Client.InitializationClient();

            Console.WriteLine("Щоб розпочати роботу виберіть метод роботи:");
            Console.WriteLine("1. Додати показник");
            Console.WriteLine("2. Переглянути статистику");

            int chooseMethod = Convert.ToInt32(Console.ReadLine());

            switch (chooseMethod)
            {
                case 1:
                    int isValid = 0;
                    int permissionToSave;


                    while (isValid==0)
                    {
                        var service = Service.MakeService();

                        Payment payment = Payment.Create(service);

                        myClient.Payments.Add(payment);

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
                        Data.Serialize(myClient);
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