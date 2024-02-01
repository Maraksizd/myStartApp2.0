using System;
using System.Text.Json;


namespace myStartApp2._0
{
    internal class Initialise
    {
        public static Service MakeService()
        {
            int poslugaNumber = Convert.ToInt32(Console.ReadLine());
            var service = new Service();

            Console.WriteLine("Введіть ціну за одиницю:");
            double unitsPrice = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть постачальника послуги:");
            string coompany = Console.ReadLine();

            switch (poslugaNumber)
            {
                case 1:
                    service = new Water(unitsPrice,coompany);
                    break;

                case 2:
                    // випадок 2
                    break;

                case 3:
                    // випадок 3
                    break;

                default:
                    Console.WriteLine("Данні не коректні, спробуйте щараз!");
                    break;
            }

            return service;
        }
    }
}
