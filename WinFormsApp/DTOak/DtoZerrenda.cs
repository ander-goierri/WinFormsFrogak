using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsApp.DTOak
{
    /// <summary>
    /// APIak familia baten datuak itzultzeko erabiltzen duen DTOa (WinForms aldean).
    /// </summary>
    public class FamiliaDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("izena")]
        public string Izena { get; set; } = "";

        /// <summary>
        /// Familiari lotutako erabiltzaileak. eager=true denean bakarrik etor daiteke.
        /// </summary>
        [JsonPropertyName("erabiltzaileak")]
        public List<ErabiltzaileaDto>? Erabiltzaileak { get; set; }
    }

    /// <summary>
    /// APIak erabiltzaile baten oinarrizko datuak itzultzeko erabiltzen duen DTOa.
    /// </summary>
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
