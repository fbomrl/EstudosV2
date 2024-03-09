using System;
using System.Linq;
using ClosedXML.Excel;

namespace VencedoresCDSv2
{
    class Program
    {
        static void Main(string[] args)
        {
            var xls = new XLWorkbook(@"C:\Users\fabio\Desktop\Vencedores2023.xlsx");
            var planilha = xls.Worksheets.First(w => w.Name == "VencedoresCDS");
            var totalLinhas = planilha.Rows().Count();
            // primeira linha é o cabecalho
            for (int l = 2; l <= totalLinhas; l++)
            {
                DateTime data = planilha.Cell($"A{l}").Value;
                string lider = planilha.Cell($"B{l}").Value.ToString();
                string tema = planilha.Cell($"C{l}").Value.ToString();
                string vencedor = planilha.Cell($"C{l}").Value.ToString();
                string segundo = planilha.Cell($"C{l}").Value.ToString();
                string terceiro = planilha.Cell($"C{l}").Value.ToString();
                string quarto = planilha.Cell($"C{l}").Value.ToString();
                string quinto = planilha.Cell($"C{l}").Value.ToString();
                //int n_entradas = int.Parse(planilha.Cell($"C{l}").Value.ToString());
                Console.WriteLine($"{data} - {lider} - {tema} - {vencedor} - {segundo} " +
                    $"- {terceiro} - {quarto} - {quinto} - ");
            }
        }
    }
}