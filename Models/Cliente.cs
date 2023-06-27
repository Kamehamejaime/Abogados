using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abogados.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}

        public string Rut { get; set; }
        public string Email { get; set; }


    }

    public class ClienteDBContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set;}
    }
}