using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zahi_Desafio_1.Models
{
    public class Cliente
    {
        [Key]
        public int Client_ID { get; set; }
        public string Client_Name { get; set; }

        public virtual ICollection<Telefone> Telefones { get; set; }
    }
}