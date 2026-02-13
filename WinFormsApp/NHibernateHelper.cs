using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate;
    using System;
    using WinFormsApp.Modeloak;

    /// <summary>
    /// WinForms aplikaziorako NHibernate konfigurazioa eta laguntza metodo osagarriak.
    /// </summary>
    public static class NHibernateHelper
    {
        private static ISessionFactory sessionFactory;

        /// <summary>
        /// Aplikazioan erabiliko den <see cref="ISessionFactory"/> instantzia bakarra.
        /// </summary>
        /// <remarks>
        /// Lehen aldiz eskatzen denean sortzen da (lazy initialization).
        /// </remarks>
        public static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    sessionFactory = Fluently.Configure()
                        .Database(MySQLConfiguration.Standard
                            .ConnectionString(c => c
                                .Server("localhost")
                                .Database("da_windows_form")
                                .Username("root")
                                .Password("1MG32025")))
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Produktua>())
                        .BuildSessionFactory();
                }
                return sessionFactory;
            }
        }

        /// <summary>
        /// Elementu bat panel baten barruan bertikalki eta horizontalki zentratzen du.
        /// </summary>
        /// <param name="elem">Zentratu nahi den kontrola.</param>
        /// <param name="panel">Kontrola kokatuko den panela.</param>
        public static void zentratuBertikalEtaHorizontalki(Control elem, Panel panel)
        {
            int panelWidth = panel.Width;
            int panelHeight = panel.Height;

            int labelWidth = elem.Width;
            int labelHeight = elem.Height;

            elem.Location = new Point(
                (panelWidth - labelWidth) / 2,
                (panelHeight - labelHeight) / 2
            );
        }
    }
}
