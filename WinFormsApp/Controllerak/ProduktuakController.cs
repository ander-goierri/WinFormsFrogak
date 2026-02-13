using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Modeloak;

namespace WinFormsApp.Controllerak
{
    /// <summary>
    /// Produktuak datu-basetik lortzeko kontrolatzailea (WinForms aplikazioa).
    /// </summary>
    public class ProduktuakController
    {
        /// <summary>
        /// Produktu guztiak datu-basetik lortzen ditu.
        /// </summary>
        /// <returns>Datu-basean dauden <see cref="Produktua"/> guztien zerrenda.</returns>
        public static List<Produktua> DenakLortu()
        {
            using (ISession session = NHibernateHelper.SessionFactory.OpenSession())
            {
                return session.Query<Produktua>().ToList();
            }
        }
    }
}
