using System;
using System.Collections.Generic;
using System.Text.Json;

namespace myStartApp2._0
{
    public class Data
    {
        public List<Client> Clients { get; set; }

        public static void Serialize(Client client)
        {
            var serialized = JsonSerializer.Serialize(client);
            Storage.Load(serialized);
        }

        public static List<Client> Deserialize()
        {
            string client = Storage.UpLoad();

            try
            {
                List<Client> clients = JsonSerializer.Deserialize<List<Client>>(client);
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