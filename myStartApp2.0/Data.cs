using System;
using System.Collections.Generic;
using System.Text.Json;

namespace myStartApp2._0
{
    public class Data
    {
        public List<Client> ClientsList { get; set; }

        public Data()
        {
            ClientsList = new List<Client>();
        }

        public static void Serialize(Data data)
        {
            var serialized = JsonSerializer.Serialize(data);
            Storage.Save(serialized);
        }

        public static Data Deserialize()
        {
            string jsonString = Storage.Load();
            var data = new Data();

            try
            {

                data = JsonSerializer.Deserialize<Data>(jsonString);

                return data;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Помилка десеріалізації JSON: {ex.Message}");
                return null; // або обробте помилку в інший спосіб
            }
        }

        public static Data InitTestData()
        {
            var testData = DemoData();
            Data.Serialize(testData);

            return testData;
        }

        public static Data DemoData()
        {
            var data = new Data
            {
                ClientsList = new List<Client>
                {
                    new Client
                    {
                        Id = 1,
                        Name = "John Doe",
                        Address = "123 Main St",
                        Payments = new List<Payment>
                        {
                            new Payment
                            {
                                Date = "2024-02-08",
                                AmountUsage = 100.00,
                                TotalPrice = 120.00,
                                Service = new Service
                                {
                                    ServiceName = "Electricity",
                                    UnitPrice = 1.20,
                                    UnitType = "kWh",
                                    Company = "Power Inc."
                                }
                            },
                            new Payment
                            {
                                Date = "2024-01-15",
                                AmountUsage = 50.00,
                                TotalPrice = 75.00,
                                Service = new Service
                                {
                                    ServiceName = "Water",
                                    UnitPrice = 1.50,
                                    UnitType = "gal",
                                    Company = "Water Corp."
                                }
                            }
                        }
                    },
                    new Client
                    {
                        Id = 2,
                        Name = "Jane Smith",
                        Address = "456 Oak St",
                        Payments = new List<Payment>
                        {
                            new Payment
                            {
                                Date = "2024-02-08",
                                AmountUsage = 80.00,
                                TotalPrice = 100.00,
                                Service = new Service
                                {
                                    ServiceName = "Gas",
                                    UnitPrice = 1.25,
                                    UnitType = "therm",
                                    Company = "Gas Co."
                                }
                            }
                        }
                    }
                }
            };
            return data;
        }
    }
}