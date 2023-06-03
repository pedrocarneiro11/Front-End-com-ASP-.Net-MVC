using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _11_Frontend_com_ASP_NET_MVC.Context;

namespace _11_Frontend_com_ASP_NET_MVC.Controllers;

    public class ContatoController : Controller
    {
        private readonly AgendaContext _context;

        // EXIBIR TODOS OS CONTATOS CADASTRADOS \/
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contatos = _context.Contatos.ToList();
            return View(contatos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
