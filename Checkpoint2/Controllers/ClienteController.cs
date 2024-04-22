using Checkpoint2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Checkpoint2.Controllers
{
    public class ClienteController : Controller
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public IActionResult Index()
        {
            return View(clientes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            cliente.IdCliente = clientes.Count + 1;
            clientes.Add(cliente);
            return RedirectToAction("Index");
        }

       
    }
}
