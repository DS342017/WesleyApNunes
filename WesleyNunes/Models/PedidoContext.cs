using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WesleyNunes.Models
{
    public class PedidoContext : DbContext
    {
        public DbSet<Pedido> Pedido { get; set; }


    }
}