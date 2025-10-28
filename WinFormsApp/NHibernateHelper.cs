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

    public static class NHibernateHelper
    {
        private static ISessionFactory sessionFactory;

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
    }

}
