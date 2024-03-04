using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VencedoresCDS
{
    internal class VencedoresMap : ClassMap<Vencedores>
    {
        public VencedoresMap()
        {
            Map(v => v.Data).Name("Data");
            Map(v => v.Lider).Name("Lider");
            Map(v => v.Tema).Name("TEMA");
            Map(v => v.Vencedor).Name("VENCEDOR");
            Map(v => v.Segundo_Lugar).Name("SEGUNDO_LUGAR");
            Map(v => v.Terceiro_Lugar).Name("TERCEIRO_LUGAR");
            Map(v => v.Quarto_Lugar).Name("QUARTO_LUGAR");
            Map(v => v.Quinto_Lugar).Name("QUINTO_LUGAR");
            Map(v => v.N_Entradas).Name("N_ENTRADAS");

        }
    }
}
