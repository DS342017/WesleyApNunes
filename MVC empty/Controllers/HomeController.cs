using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Mvc;



namespace MVC_empty.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            HttpResponseMessage response = GlobalVari.WebApiClient.GetAsync("PedidosApi").Result;
            return View(response.Content.ReadAsAsync<IEnumerable<Models.PedidoMvc>>().Result);


        }
        public ActionResult Add(int id = 0)
        {
            return View(new Models.PedidoMvc());
        }

        [HttpPost]
        public ActionResult Add(Models.PedidoMvc Pedido)
        {
            HttpResponseMessage response = GlobalVari.WebApiClient.PostAsJsonAsync("Pedidos", Pedido).Result;
            return RedirectToAction("Index");
        }

    }
}