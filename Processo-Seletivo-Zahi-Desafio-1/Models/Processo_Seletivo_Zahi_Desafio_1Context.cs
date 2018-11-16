using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Processo_Seletivo_Zahi_Desafio_1.Models
{
    public class Processo_Seletivo_Zahi_Desafio_1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Processo_Seletivo_Zahi_Desafio_1Context() : base("name=Processo_Seletivo_Zahi_Desafio_1Context")
        {
        }

        public System.Data.Entity.DbSet<Zahi_Desafio_1.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<Zahi_Desafio_1.Models.Telefone> Telefones { get; set; }
    }
}
