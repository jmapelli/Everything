using Everything.Models.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Everything.Controllers
{
    public class ProductoController : Controller
    {

        ProductoBusiness productoBusiness = new ProductoBusiness();

        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listar()
        {
            return View(productoBusiness.findAll());
        }

    }
}