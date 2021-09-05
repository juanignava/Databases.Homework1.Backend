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
        [HttpGet("{id}")]
        public ActionResult<Client> Get(int id)
        {
            var client = ClientService.Get(id);

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