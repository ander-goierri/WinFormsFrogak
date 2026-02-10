using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsApp.DTOak
{
    internal class DtoZerrenda
    {
    }

    public class FamiliaDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("izena")]
        public string Izena { get; set; } = "";

        // Solo vendrá si llamas con eager=true
        [JsonPropertyName("erabiltzaileak")]
        public List<ErabiltzaileaDto>? Erabiltzaileak { get; set; }
    }

    public class ErabiltzaileaDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("izena")]
        public string Izena { get; set; } = "";

        [JsonPropertyName("abizena")]
        public string Abizena { get; set; } = "";
    }
}


