using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text.Json;

namespace myStartApp2._0
{
    public class Data
    {
        public List<Client> ClientsList { get; set; }

        public static void Serialize(Data data)
        {
            var serialized = JsonSerializer.Serialize(data);
            Storage.Save(serialized);
        }

        public static Data Deserialize()
        {
            string client = Storage.Load();

            try
            {
                Data clients = JsonSerializer.Deserialize<Data>(client);
                return clients;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Помилка десеріалізації JSON: {ex.Message}");
                return null; // або обробте помилку в інший спосіб
            }
        }


    }
}