using Everything.Models.Business;
using Everything.Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Everything.Controllers
{
    public class CarritoController : Controller
    {

        ProductoBusiness productoBusiness = new ProductoBusiness();
        OrdenBusiness ordenBusiness = new OrdenBusiness();
        OrdenDetalleBusiness ordenDetalleBusiness = new OrdenDetalleBusiness();

        // GET: Carrito
        public ActionResult Index()
        {
            List<orden_detalle> carrito = (List<orden_detalle>)Session["carrito"];
            return View(carrito);
        }

        public ActionResult agregar(int id)
        {
            producto producto = productoBusiness.findById(id);
            orden_detalle item = new orden_detalle();

            item.producto = producto.id;
            item.detalle = producto.nombre;
            item.precio = producto.precio;
            item.cantidad = 1;
            item.total = item.cantidad * item.precio;

            ViewBag.producto = producto;

            return View(item);
        }

        [HttpPost]
        public ActionResult agregar(orden_detalle item)
        {
            if (ModelState.IsValid)
            {
                List<orden_detalle> carrito = (List<orden_detalle>)Session["carrito"];
                carrito.Add(item);

                Session["carrito"] = carrito;

                return RedirectToAction("index", "Home", null);
            }
            else
            {
                return RedirectToAction("add");
            }
        }

        public ActionResult editar(int id)
        {
            List<orden_detalle> carrito = (List<orden_detalle>)Session["carrito"];

            return View(carrito[id]);
        }

        [HttpPost]
        public ActionResult editar(int id, orden_detalle item)
        {
            List<orden_detalle> carrito = (List<orden_detalle>)Session["carrito"];
            carrito[id] = item;

            Session["carrito"] = carrito;

            return RedirectToAction("index");
        }

        public ActionResult finalizar()
        {
            usuario usuario = (usuario)Session["usuario"];
            List<orden_detalle> carrito = (List<orden_detalle>)Session["carrito"];

            if (usuario == null)
            {
                return RedirectToAction("login", "Account");
            }
            else if (carrito.Count > 0)
            {
                decimal total = 0;
                foreach (orden_detalle item in carrito)
                {
                    total += item.total;
                }

                orden orden = new orden();
                orden.orden_fecha = DateTime.Now.ToString("yyyy-MM-dd");
                orden.delivery_fecha = DateTime.Now.AddDays(4).ToString("yyyy-MM-dd");
                orden.tipo_documento = "BOLETA";
                orden.usuario = usuario.id;
                orden.total = total;

                ordenBusiness.create(orden);

                string productos = "";
                foreach (orden_detalle item in carrito)
                {
                    item.orden = orden.id;
                    ordenDetalleBusiness.create(item);
                    productos += item.detalle + " | " + item.cantidad + " |  s/." + item.precio + " | s/." + item.total + "\n";
                }

                productos += "TOTAL PAGAR: s/." + orden.total;

                OrdenBusiness.enviarCorreo(usuario.correo, productos);

                ViewBag.correo = usuario.correo;
                Session["carrito"] = new List<orden_detalle>();
            }

            return View();
        }

    }
}