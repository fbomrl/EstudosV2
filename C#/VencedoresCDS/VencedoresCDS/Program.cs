

using OfficeOpenXml;
using VencedoresCDS;

static void Main(string[] args)
{
    var pessoas = ReadXls();
    foreach (var item in pessoas)
    {
        Console.WriteLine($"Líder: {item.Lider} - Tema: {item.Tema}.");
    }
    Console.ReadKey();
} 
    static List<Vencedores> ReadXls()
    {
        var response = new List<Vencedores>();

        FileInfo existingFile = new FileInfo("C:\\Users\\fabio\\Documents\\FBO\\Vencedores FC - ban advt.xlsx");

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        using (ExcelPackage package = new ExcelPackage(existingFile))
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
            int colCount = worksheet.Dimension.End.Column;

            int rowCount = worksheet.Dimension.End.Row;

            for (int row = 2; row < rowCount; row++)
            {
                var pessoa = new Vencedores();
                pessoa.Lider = worksheet.Cells[row, 1].Value.ToString();
                pessoa.Tema = worksheet.Cells[row, 2].Value.ToString();

                response.Add(pessoa);
            }
        return response;
        }
    }

internal class Pessoa
{
    public string Nome { get; set; }
    public string Email { get; set; }
}
