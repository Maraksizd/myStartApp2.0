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
            var client = Storage.UpLoad();
            var clients = JsonSerializer.Deserialize<List<Client>>(client);
            return clients;
        }


    }
}