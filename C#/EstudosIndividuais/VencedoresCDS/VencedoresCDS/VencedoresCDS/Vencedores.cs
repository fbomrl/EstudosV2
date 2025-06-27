using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VencedoresCDS
{
    internal class Vencedores
    {
        public string? Data { get; set; }
        public string? Lider { get; set; }
        public string? Tema { get; set; }
        public string? Vencedor { get; set; }
        public string? Segundo_Lugar { get; set; }
        public string? Terceiro_Lugar { get; set; }
        public string? Quarto_Lugar { get; set; }
        public string? Quinto_Lugar { get; set; }
        public int? N_Entradas { get; set; }
    }
}
