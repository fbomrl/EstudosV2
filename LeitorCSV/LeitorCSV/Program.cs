using System.Formats.Asn1;
using System.Globalization;

using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorArquivoCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Baixar CSVHelper
            //CriarClasse
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                //cabeçalho do arquivo
                HasHeaderRecord = true
            };

            List<Venda> vendas;

            //para fazer a leitura do arquivo
            using (var reader = new StreamReader("../../../NomeDoArquivo.csv"))

            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<VendaMap>();

                vendas = csv.GetRecords<Venda>().ToList();

                foreach (var venda in vendas)
                {
                    Console.WriteLine($"Clinte:  {venda.NomeCliente}, Pacote: {venda.NomePacote}");
                }
            }

            using (var writer = new StreamWriter("nomedoArquivo.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<VendaMap>();
                csv.WriteHeader<Venda>();
                csv.NextRecord();
                csv.WriteRecords(vendas);
            }


            Console.Read();
        }
    }
}





using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorArquivoCSV
{
    public class Venda
    {
        //[Name("id")]
        public int Id { get; set; }
        //[Name("nome_cliente")]
        public string NomeCliente { get; set; }
        //[Name("nome_pacote")]
        public string NomePacote { get; set; }
        //[Name("data_nascimento")]
        public DateTime DataNascimento { get; set; }
        //[Name("data_atendimento")]
        public DateTime DataAtendimento { get; set; }
        //[Name("cidade_estado")]
        public string CidadeEstado { get; set; }
    }
}

