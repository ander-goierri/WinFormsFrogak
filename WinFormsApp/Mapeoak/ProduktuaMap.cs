using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Modeloak;

namespace WinFormsApp.Mapeoak
{
    using FluentNHibernate.Mapping;
    public class ProduktuaMap: ClassMap<Produktua>
    {
        public ProduktuaMap()
        {
            Table("produktuak");

            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Izena);
            Map(x => x.Stock);
        }
    }
}
