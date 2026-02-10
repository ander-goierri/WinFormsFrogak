using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.DTOak;
using WinFormsApp.Modeloak;
using WinFormsApp.Zerbitzuak;

namespace WinFormsApp.Controllerak
{
    public class FamiliakController
    {
        // Hobe konfiguraziotik etortzea; momentuz konstante bat
        private static readonly ApiZerbitzua _api = new ApiZerbitzua();

        public static Task<List<FamiliaDto>> DenakLortuAsync(bool eager = false)
        {
            return _api.FamiliakLortuAsync(eager);
        }
    }
}
