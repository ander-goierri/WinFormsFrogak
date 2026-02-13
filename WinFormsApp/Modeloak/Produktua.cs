using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Modeloak
{
    /// <summary>
    /// Datu-baseko produktu bat adierazten duen entitatea.
    /// </summary>
    /// <remarks>
    /// NHibernate-k mapatutako klasea da. Propietateak <c>virtual</c> dira
    /// lazy loading eta proxy mekanismoak ahalbidetzeko.
    /// </remarks>
    public class Produktua
    {
        public virtual int Id { get; set; }

        public virtual string Izena { get; set; }

        public virtual int Stock { get; set; }
    }
}
