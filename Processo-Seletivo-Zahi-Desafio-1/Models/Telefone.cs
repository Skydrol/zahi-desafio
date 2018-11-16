using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zahi_Desafio_1.Models
{
    public class Telefone
    {
        [Key]
        public int Telefone_ID { get; set; }
        public string DDD { get; set; }
        public string Telefone_Number { get; set; }
        public int Client_ID { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}