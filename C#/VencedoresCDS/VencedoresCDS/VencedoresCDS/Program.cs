
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using VencedoresCDS;

var config = new CsvConfiguration(cultureInfo: CultureInfo.InvariantCulture)
{
    HasHeaderRecord = true,
    Delimiter = ",",
    BadDataFound = null
};

using (var reader = new StreamReader("C:\\Users\\fabio\\Desktop\\Vencedores2023.xlsx"))
using (var csv = new CsvReader(reader, config))
{
    csv.Context.RegisterClassMap<VencedoresMap>();

    var vencedores = csv.GetRecords<Vencedores>();

    foreach (var vencedor in vencedores)
    {
        Console.WriteLine($"Lider: {vencedor.Lider} - " );
    }
}

Console.Read();