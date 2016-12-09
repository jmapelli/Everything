using Everything.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Everything.Models.Business
{
    public class ProductoBusiness
    {
        EverythingEntities context = new EverythingEntities();

        public List<producto> findAll()
        {
            return context.producto.ToList();
        }

        public void create (producto producto)
        {
            context.producto.Add(producto);
            context.SaveChanges();
        }

        public void edit (producto producto)
        {
            context.Entry(producto).State = EntityState.Modified;
            context.SaveChanges();
        }

        public producto findById(int id)
        {
            return context.producto.Find(id);
        }

        public List<producto> findByNombre(string nombre)
        {
            return context.producto.Where(p => p.nombre.ToUpper().Contains(nombre.ToUpper())).ToList();
        }

        public List<producto> findByTipo(int tipo)
        {
            //var data = from p in context.producto
            //           where p.tipo == tipo
            //           select p;

            //return data.ToList();

            return context.producto.Where(p => p.tipo == tipo).ToList();
        }

        public List<producto> findByEtiqueta(string etiqueta)
        {
            //var data = from p in context.producto
            //           where p.etiquetas.ToUpper().Contains(etiqueta.ToUpper())
            //           select p;

            //return data.ToList();

            return context.producto.Where(p => p.etiquetas.ToUpper().Contains(etiqueta.ToUpper())).ToList();
        }

        public List<producto> findByTipoAndEtiqueta(int tipo, string etiqueta)
        {
            //var data = from p in context.producto
            //           where p.tipo == tipo && p.etiquetas.ToUpper().Contains(etiqueta.ToUpper())
            //           select p;

            //return data.ToList();
            return context.producto.Where(p => p.tipo == tipo && p.etiquetas.ToUpper().Contains(etiqueta.ToUpper())).ToList();
        }
    }
}