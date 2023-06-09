using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _11_Frontend_com_ASP_NET_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace _11_Frontend_com_ASP_NET_MVC.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos{ get; set; }
    }
}