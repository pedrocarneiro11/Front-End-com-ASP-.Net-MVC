using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _11_Frontend_com_ASP_NET_MVC.Context;
using _11_Frontend_com_ASP_NET_MVC.Models;

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


        // CADASTRAR NOVO CONTATO \/
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            if(ModelState.IsValid)
            {
                _context.Contatos.Add(contato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            } else
            {
                return View(contato);
            }
        }

        // Método POST para editar contato
        
        public IActionResult Editar(int id)
        {
            var contato = _context.Contatos.Find(id);

            if(contato == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(contato);
        }

        public IActionResult EditarContato(int id)
        {
            var contato = _context.Contatos.Find(id);

            if(contato == null){
                return RedirectToAction(nameof(Index));
            } else {
                return View(contato);
            }
        }


        // MÉTODO POST PARA EDITAR CONTATO
        [HttpPost]
        public IActionResult Editar(Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(contato.Id);

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // EXIBIR PAGINA DE DETALHES DO CONTATO

        public IActionResult Detalhes(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato == null)
            {
                return RedirectToAction(nameof(Index));
            } else 
            {
                return View(contato);
            }            
        }

        //Método POST para apagar um contato

        public IActionResult Deletar(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato == null)
            {
                return RedirectToAction(nameof(Index));
            } else 
            {
                return View(contato);
            }  
        }

        [HttpPost]
        public IActionResult Deletar(Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(contato.Id);

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
