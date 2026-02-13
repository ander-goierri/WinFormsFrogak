using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http.Json;
using WinFormsApp.DTOak;

namespace WinFormsApp.Zerbitzuak
{
    /// <summary>
    /// WinForms aplikaziotik API REST zerbitzura deiak egiteko zerbitzua.
    /// </summary>
    public class ApiZerbitzua
    {
        // Hemen jarri zure APIaren base URL-a (adib. https://localhost:xxxx)
        private readonly HttpClient _http;

        private readonly string _url = "http://localhost:";
        private readonly int _port = 5093;

        /// <summary>
        /// HttpClient-a konfiguratzen du APIaren oinarrizko helbidearekin.
        /// </summary>
        public ApiZerbitzua()
        {
            _http = new HttpClient
            {
                BaseAddress = new Uri(_url + _port + "/")
            };
        }

        /// <summary>
        /// Familia guztiak API-tik modu asinkronoan lortzen ditu.
        /// </summary>
        /// <param name="eager">
        /// <c>true</c> bada, familiaren erabiltzaileak ere itzuliko dira;
        /// <c>false</c> bada, oinarrizko datuak bakarrik.
        /// </param>
        /// <returns>APIak itzulitako familien zerrenda.</returns>
        public async Task<List<FamiliaDto>> FamiliakLortuAsync(bool eager = false)
        {
            var url = $"api/familia?eager={eager.ToString().ToLower()}";

            var result = await _http.GetFromJsonAsync<List<FamiliaDto>>(url);

            return result ?? new List<FamiliaDto>();
        }

        /// <summary>
        /// ID baten arabera familia bat API-tik lortzen du.
        /// </summary>
        /// <param name="id">Bilatu nahi den familiaren identifikatzailea.</param>
        /// <param name="eager">
        /// <c>true</c> bada, familiaren erabiltzaileak ere itzuliko dira.
        /// </param>
        /// <returns>Familia aurkitzen bada, <see cref="FamiliaDto"/>; bestela <c>null</c>.</returns>
        public async Task<FamiliaDto?> FamiliaLortuAsync(int id, bool eager = false)
        {
            var url = $"api/familia/{id}?eager={eager.ToString().ToLower()}";
            return await _http.GetFromJsonAsync<FamiliaDto>(url);
        }
    }
}
