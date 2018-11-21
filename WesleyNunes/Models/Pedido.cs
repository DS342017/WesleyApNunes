using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WesleyNunes.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public string NomeMedicamento { get; set; }
        public int QtdeMedicamento { get; set; }
        public int CodCliente { get; set; }
        public DateTime DataEntreg { get; set; }
    }
}