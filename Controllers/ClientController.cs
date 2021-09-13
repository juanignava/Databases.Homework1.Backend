using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TecBankBackend.Models;
using TecBankBackend.Services;

namespace TecBankBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        public ClientController()
        {
        }

        // GET all clients action
        [HttpGet]
        public ActionResult<List<Client>> GetAll() =>
            ClientService.GetAll();

        // GET client by Id action
        [HttpGet("id/{id}")]
        public ActionResult<Client> GetID(string id)
        {
            var client = ClientService.GetID(id);

            if(client ==  null)
                return NotFound();

            return client;
        }

        // GET client by username action
        [HttpGet("username/{username}")]
        public ActionResult<Client> GetUsername(string username)
        {
            var client = ClientService.GetUsername(username);

            if(client ==  null)
                return NotFound();

            return client;
        }

        // POST client action
        [HttpPost]
        public IActionResult Create(Client client)
        {
            ClientService.Add(client);
            return NoContent();
        }
    }
}