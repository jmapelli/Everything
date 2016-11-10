using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Everything.Models.Entities;

namespace Everything.Models.Business
{

    public class TipoBusiness
    {

        EverythingEntities context = new EverythingEntities();

        public List<tipo> findAll()
        {
            return context.tipo.ToList();
        }

    }
}