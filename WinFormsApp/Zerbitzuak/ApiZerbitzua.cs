using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http.Json;
using WinFormsApp.DTOak;

namespace WinFormsApp.Zerbitzuak
{
    public class ApiZerbitzua
    {
        // Hemen jarri zure APIaren base URL-a (adib. https://localhost:xxxx)
        private readonly HttpClient _http;

        private readonly string _url = "http://localhost:";
        private readonly int _port = 5093;

        public ApiZerbitzua()
        {
            _http = new HttpClient
            {
                BaseAddress = new Uri(_url + _port + "/")
            };
        }

        public async Task<List<FamiliaDto>> FamiliakLortuAsync(bool eager = false)
        {
            var url = $"api/familia?eager={eager.ToString().ToLower()}";

            var result = await _http.GetFromJsonAsync<List<FamiliaDto>>(url);

            return result ?? new List<FamiliaDto>();
        }

        public async Task<FamiliaDto?> FamiliaLortuAsync(int id, bool eager = false)
        {
            var url = $"api/familia/{id}?eager={eager.ToString().ToLower()}";
            return await _http.GetFromJsonAsync<FamiliaDto>(url);
        }
    }
}
