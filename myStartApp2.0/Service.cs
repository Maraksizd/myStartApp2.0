using System;

namespace myStartApp2._0
{
    public class Service
    {
        public string ServiceName { get; set; }
        public double UnitPrice { get; set; }
        public string UnitType { get; set; }
        public string Company { get; set; }

        public static Service MakeService()
        {
            Console.WriteLine("Введіть номер послуги яку бажаєте заповнити:");
            Console.WriteLine("1. Вода");
            Console.WriteLine("2. Газ");
            Console.WriteLine("№. Електрика");

            int poslugaNumber = Convert.ToInt32(Console.ReadLine());
            var service = new Service();

            Console.WriteLine("Введіть ціну за одиницю:");
            double unitsPrice = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть постачальника послуги:");
            string coompany = Console.ReadLine();

            switch (poslugaNumber)
            {
                case 1:
                    service = new Water(unitsPrice, coompany);
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