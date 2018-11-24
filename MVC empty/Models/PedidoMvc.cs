using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web; 


namespace MVC_empty.Models
{
    public class PedidoMvc
    {
        [Key]
            public int IdPedido { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Nome  obrigatório", AllowEmptyStrings = false)]
        
        public string NomeMedicamento { get; set; }

            public int QtdeMedicamento { get; set; }

            public int CodCliente { get; set; }

            public DateTime DataEntreg { get; set; }  



        
    }
}