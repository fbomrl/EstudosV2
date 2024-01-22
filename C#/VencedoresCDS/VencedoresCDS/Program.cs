

using System.Data.OleDb;
using VencedoresCDS;

Console.WriteLine("Leitura planilha excel: ");
Console.WriteLine();

List<Vencedores> listaVencedores = ObterExcel();
if (listaVencedores != null)
{
    foreach (var v in listaVencedores)
    {
        Console.WriteLine(String.Format($"LIDER_FC: {v.Lider} - TEMA: {v.Tema} - VENCEDOR: {v.Vencedor}"));
    }
}
else
{
    Console.WriteLine("Sem Retorno.");
}

static List<Vencedores> ObterExcel()
{
    //OleDbConnection connect = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\fabio\Documents\FBO\Vencedores FC - ban advt.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES';");
    OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\" + C:\\Users\\fabio\\Documents\\FBO\\Vencedores FC - ban advt.xlsx+ \";Extended Properties=\\\"Excel 8.0;HDR=Yes;IMEX=1\\\"");
    string comandoSql = "select * from [Plan1$]";
    OleDbCommand comando = new OleDbCommand(comandoSql, connect);
    List<Vencedores> listaVencedores = new List<Vencedores>();
    try
    {
        connect.Open();
        OleDbDataReader rd = comando.ExecuteReader();

        while (rd.Read())
        {
            listaVencedores.Add(new Vencedores()
            {
                Lider = rd["LIDER_FC"].ToString(),
                Tema = rd["TEMA"].ToString(),
                Vencedor = rd["VENCEDOR"].ToString(),
                Segundo = rd["2º COLOCADO"].ToString(),
                Terceiro = rd["3º COLOCADO"].ToString(),
                Quarto = rd["4º COLOCADO"].ToString(),
                Quinto = rd["5º COLOCADO"].ToString(),
            });
        }
        if (listaVencedores.Count > 0)
            return listaVencedores;
        else
            return null;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Não foi possível ler a planilha do excel.");
        return null;
    }
    finally { connect.Close(); }
}


internal class Vencedores
{
    public static object OleDbConnection { get; private set; }
    public string Lider { get; set; }
    public string Tema { get; set; }
    public string Vencedor { get; set; }
    public string Segundo { get; set; }
    public string Terceiro { get; set; }
    public string Quarto { get; set; }
    public string Quinto { get; set; } 
}
