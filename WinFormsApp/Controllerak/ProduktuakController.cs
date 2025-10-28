using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Modeloak;

namespace WinFormsApp.Controllerak
{
    public class ProduktuakController
    {
        public static List<Produktua> DenakLortu()
        {
            using (ISession session = NHibernateHelper.SessionFactory.OpenSession())
            {
                return session.Query<Produktua>().ToList();
            }
        }
    }
}
