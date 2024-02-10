using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStartApp2._0
{
    public class DataAnalytics
    {
        public static void AvaragePrice(Client client)
        {
            double sumAllPrices = 0;
            int paymentsCount = client.Payments.Count;

            for (int i = 0; i < paymentsCount; i++)
            {
                sumAllPrices += client.Payments[i].TotalPrice;
            }

            double finelSum = sumAllPrices / paymentsCount;

            Console.WriteLine("Загальна сума всіх оплат = " + sumAllPrices);
            Console.WriteLine("Середня оплата становить = " + finelSum);
        }

        public static void AvarageUnitsPrice(Client client)
        {
            double sumAllUnitsPrices = 0;
            int paymentsCount = client.Payments.Count;

            for (int i = 0; i < paymentsCount; i++)
            {
                sumAllUnitsPrices += client.Payments[i].Service.UnitPrice;
            }

            double finelSum = sumAllUnitsPrices / paymentsCount;

            Console.WriteLine("Загальна кількісьть використаного= " + sumAllUnitsPrices);
            Console.WriteLine("Середня ціна за одиницю = " + finelSum);
        }

        public static void AvarageAmountUsage(Client client)
        {
            double sumAllAmountUsage = 0;
            int paymentsCount = client.Payments.Count;

            for (int i = 0; i < paymentsCount; i++)
            {
                sumAllAmountUsage += client.Payments[i].AmountUsage;
            }
            double finelSum = sumAllAmountUsage / paymentsCount;
            Console.WriteLine("Загальна кількісьть використаного = " + sumAllAmountUsage);
            Console.WriteLine("Середнє використання = " + finelSum);
        }

        public static void Stats(Client curentClient)
        {
            int chooiseStatFunck;
            Console.WriteLine("Виберіть яка статистика вас цікавить:");

            Console.WriteLine("1-Середня ціна (по всіх оплатах)");
            Console.WriteLine("2-Середня ціна за одиницю (по всіх оплатах)");
            Console.WriteLine("3-Середнє використане (по всіх оплатах)");
            chooiseStatFunck = Int32.Parse(Console.ReadLine());


            switch (chooiseStatFunck)
            {
                case 1://AvaragePrice
                    AvaragePrice(curentClient);
                    break;

                case 2://AvarageUnitsPrice
                    AvarageUnitsPrice(curentClient);
                    break;

                case 3://AvarageAmountUsage
                    AvarageAmountUsage(curentClient);
                    break;

                case 4://all method for stats
                    break;

                default:

                    break;
            }
        }

        public static void PrintInfo(Client client)
        {

            int paymentsCount = client.Payments.Count;
            for (int i = 0; i < paymentsCount; i++)
            {
                int numberPayment = i + 1;
                Console.WriteLine("оплата номер " + numberPayment + ")");
                Console.WriteLine("Використано- "+client.Payments[i].AmountUsage);
                Console.WriteLine("Дата- " + client.Payments[i].Date);
                Console.WriteLine("Ціна послуги- " + client.Payments[i].TotalPrice);
                Console.WriteLine("Послуга- " + client.Payments[i].Service.ServiceName);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }
    }

}
