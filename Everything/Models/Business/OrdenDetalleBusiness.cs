using Everything.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Everything.Models.Business
{
    public class OrdenDetalleBusiness
    {

        EverythingEntities context = new EverythingEntities();

        public void create(orden_detalle orden_detalle)
        {
            context.orden_detalle.Add(orden_detalle);
            context.SaveChanges();
        }
    }
}