using Microsoft.VisualBasic;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VencedoresCDS
{
    internal class Vencedores
    {
        public string? Data { get; set; }
        public string? Lider { get; set; }
        public string? Tema { get; set; }
        public string? Vencedor { get; set; }
        public string? Segundo { get; set; }
        public string? Terceiro { get; set; }
        public string? Quarto { get; set; }
        public string? Quinto { get; set; }
        public string? StringQntd { get; set;}
        //public int Qntd { get
        //    {
        //        return ParseInt(Qntd);
        //    } 
    }

}

