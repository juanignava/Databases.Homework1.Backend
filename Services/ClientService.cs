using TecBankBackend.Models;
using System.Collections.Generic;
using System.Linq;

namespace TecBankBackend.Services
{
    public static class ClientService
    {
        // List where clients are stored
        static List<Client> Clients { get; }
        static ClientService() 
        {
            Clients = new List<Client>
            {
                new Client {Id = 1, Username = "juanignava", Password = "1234", ClientType = "legal", MonthlyIncome = 1000, Name = new Name("Juan", "Ignacio", "Navarro", "Navarro") , Adress = new Adress("Cartago", "Cartago", "Oriental", "Pitahaya", "Residencial")}
            };
        }

        // method that returns the clients list
        public static List<Client> GetAll() => Clients;

        // method that returns the client with the given id
        public static Client Get(int id) => Clients.FirstOrDefault(p => p.Id == id);

        // method that adds the client given in the request to the clients list
        public static void Add(Client client)
        {
            Clients.Add(client);
        }
    }
    
}