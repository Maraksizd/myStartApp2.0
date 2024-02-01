using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Xml.Linq;

namespace myStartApp2._0
{
    public class Data
    {
        public List<Client> Clients { get; set; }

        
        public static Data Create(Client client)
        {
            Data data = new Data { Client = client, Payment = payment };
            return data;
        }
        public static void Save(Data data)
        {
            var serialized = JsonSerializer.Serialize(data);
            Storage.Save(serialized);
        }

        public static List<Client> Read()
        {
            var data = Storage.Load();
            var clients = JsonSerializer.Deserialize<List<Client>>(data);
            return clients;
        }


    }
}