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
    /// <summary>
    /// WinForms aplikaziotik familiak lortzeko logika zentralizatzen duen kontrolatzailea.
    /// </summary>
    public class FamiliakController
    {
        // Hobe konfiguraziotik etortzea; momentuz konstante bat
        private static readonly ApiZerbitzua _api = new ApiZerbitzua();

        /// <summary>
        /// Familia guztiak API-tik modu asinkronoan lortzen ditu.
        /// </summary>
        /// <param name="eager">
        /// <c>true</c> bada, familiaren erabiltzaileak ere itzuliko dira; <c>false</c> bada, oinarrizko datuak bakarrik.
        /// </param>
        /// <returns>APIak itzulitako familien zerrenda (<see cref="FamiliaDto"/>).</returns>
        public static Task<List<FamiliaDto>> DenakLortuAsync(bool eager = false)
        {
            return _api.FamiliakLortuAsync(eager);
        }
    }
}
