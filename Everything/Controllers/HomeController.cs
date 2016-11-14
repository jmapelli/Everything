using Everything.Models.Business;
using Everything.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Everything.Controllers
{
    public class HomeController : Controller
    {
        ProductoBusiness productoBusiness = new ProductoBusiness();
        public ActionResult Index()
        {
            return View(productoBusiness.findAll());
        }

        public ActionResult Buscar(string nombre, string etiqueta)
        {
            List<producto> productos = new List<producto>();

            if (nombre != null)
            {
                productos = productoBusiness.findByNombre(nombre);
            }

            if (etiqueta != null)
            {
                productos = productoBusiness.findByEtiqueta(etiqueta);
            }

            return View(productos);
        }

    }
}