using Everything.Models.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Everything.Controllers
{
    public class CarritoController : Controller
    {

        ProductoBusiness productoBusiness = new ProductoBusiness();

        // GET: Carrito
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listarProductos()
        {
            return View(productoBusiness.findAll());
        }

    }
}