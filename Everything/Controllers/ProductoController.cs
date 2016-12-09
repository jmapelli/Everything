using Everything.Models.Business;
using Everything.Models.Entities;
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
        TipoBusiness tipoBussiness = new TipoBusiness();

        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listar()
        {
            return View(productoBusiness.findAll());
        }

        public ActionResult crear()
        {
            ViewBag.tipos = tipoBussiness.findAll();
            return View();
        }

        [HttpPost]
        public ActionResult crear(producto producto)
        {
            if (ModelState.IsValid)
            {
                productoBusiness.create(producto);
                return RedirectToAction("listar");
            }
            else
            {
                return RedirectToAction("crear");
            }
        }

        public ActionResult editar(int id)
        {
            ViewBag.tipos = tipoBussiness.findAll();
            return View(productoBusiness.findById(id));
        }

        [HttpPost]
        public ActionResult editar(producto producto)
        {
            if (ModelState.IsValid)
            {
                productoBusiness.edit(producto);
                return RedirectToAction("listar");
            }
            else
            {
                return RedirectToAction("editar", new { id = producto.id });
            }
        }

    }
}