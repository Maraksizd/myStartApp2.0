using System;

namespace myStartApp2._0
{
    public class Payment
    {
        public string Date { get; set; }
        public double AmountUsage { get; set; }
        public double TotalPrice { get; set; }
        public Service Service { get; set; }
        

        public static Payment Create(Service service)
        {
            Payment payment = new Payment();

            Console.WriteLine("Введіть дату оплати:");
            string date = Console.ReadLine();
            payment.Date = date;

            Console.WriteLine("Введіть кількісьть спожитого:");
            double amountUsage = Double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            payment.AmountUsage = amountUsage;

            Console.WriteLine("Введіть загальну ціну:");
            double totalPrice = Double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            payment.TotalPrice = totalPrice;

            payment.Service = service;

            return payment;
        }
    }
}