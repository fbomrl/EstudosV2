


using System.ComponentModel.Design.Serialization;
using System.Globalization;

DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

//Console.WriteLine(d);
//Console.WriteLine("1 - Date: "+ d.Date);
//Console.WriteLine("2 - Day: "+d.Day);
//Console.WriteLine("3 - Month: "+ d.Month);
//Console.WriteLine("4 - Day of Week: " + d.DayOfWeek);
//Console.WriteLine("5 - Day of Year: " + d.DayOfYear);
//Console.WriteLine("6 - Kind: " + d.Kind);


//string s1 = d.ToLongDateString();
//string s2 = d.ToLongTimeString();
//string s3 = d.ToShortDateString();
//string s4 = d.ToShortTimeString();

//string s5 = d.ToString();
//string s6 = d.ToString("yyyy-mm-dd HH:mm:ss");
//string s7 = d.ToString("yyyy-mm-dd HH:mm:ss.fff");

//Console.WriteLine(s1);
//Console.WriteLine(s2);
//Console.WriteLine(s3);
//Console.WriteLine(s4);
//Console.WriteLine(s5);
//Console.WriteLine(s6);
//Console.WriteLine(s7);

DateTime d2 = d.AddHours(2);
DateTime d3 = d.AddMinutes(3);

Console.WriteLine(d);
Console.WriteLine(d2);
Console.WriteLine(d3);


//MNuito util para calcular datas de vencimentos.
//Exemplo: 

DateTime geracaoBoleto =  DateTime.Now;

DateTime vencimentoBoleto = geracaoBoleto.AddDays(30);
Console.WriteLine();
Console.WriteLine("Data Emissão Boleto: " + geracaoBoleto);
Console.WriteLine("Data Vencimento Boleto: " + vencimentoBoleto);

Console.WriteLine();

//diferença entre datas:

DateTime dataInicial = new DateTime(2023, 05 , 17);
DateTime dataFinal = new DateTime(2024, 03, 20);

TimeSpan diferenca = dataFinal.Subtract(dataInicial);

Console.WriteLine("Diferença: " + diferenca);
