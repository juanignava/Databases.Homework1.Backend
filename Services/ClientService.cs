using TecBankBackend.Models;
using System.Collections.Generic;
using System.Linq;

namespace TecBankBackend.Services
{
    public static class ClientService
    {
        // List where clients are stored
        static List<Client> Clients { get; }
        static int nextId = 2;
        static ClientService() 
        {
            Clients = new List<Client>
            {
                new Client {id = "1", ssn = "123456", username = "juannava", password = "123", firstName = "Juan", lastName = "Navarro", address = "cartago", phoneNumber = "87175508", income = "2000", clientType = "client", token = "123"}
            };
        }

        // method that returns the clients list
        public static List<Client> GetAll() => Clients;

        // method that returns the client with the given id
        public static Client GetID(string id) => Clients.FirstOrDefault(p => p.id == id);

        // method that returns the client with the given username
        public static Client GetUsername(string username) => Clients.FirstOrDefault(p => p.username == username);

        // method that adds the client given in the request to the clients list
        public static void Add(Client client)
        {
            client.id = nextId.ToString();
            nextId+=1;
            Clients.Add(client);
        }
    }
    
}