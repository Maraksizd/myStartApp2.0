using System;
using System.Collections.Generic;

namespace myStartApp2._0
{
    public class Client
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Payment> Payments { get; set; }
        public static Client Create()
        {
            Client client = new Client();

            Console.WriteLine("Введіть своє імя:");
            string name = Console.ReadLine();
            client.Name = name;

            Console.WriteLine("enter your address:");
            string address = Console.ReadLine();
            client.Address = address;

            client.Payments = new List<Payment>();

            return client;
        }
    }
}