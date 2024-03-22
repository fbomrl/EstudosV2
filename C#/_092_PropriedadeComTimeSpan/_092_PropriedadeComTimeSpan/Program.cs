

//TimeSpan t1 = TimeSpan.MaxValue;
//TimeSpan t2 = TimeSpan.MinValue;
//TimeSpan t3 = TimeSpan.Zero;

//Console.WriteLine(t1);
//Console.WriteLine(t2);
//Console.WriteLine(t3);

//TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

//Console.WriteLine(t);

////Devolvem numeros inteiros
//Console.WriteLine("Days: " + t.Days);
//Console.WriteLine("Minutes: " + t.Minutes);
//Console.WriteLine("Hours: " + t.Hours);
//Console.WriteLine("Ticks: " + t.Ticks);

////As propriedades "total" devolvem os números quebrados
//Console.WriteLine("TotalDays: " + t.TotalDays);
//Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
//Console.WriteLine("TotalHours: " + t.TotalHours);


TimeSpan t1 = new TimeSpan(1, 30, 10);
TimeSpan t2 = new TimeSpan(0, 10, 5);

TimeSpan sum = t1.Add(t2);
TimeSpan dif = t1.Subtract(t2);
TimeSpan mult = t2.Multiply(2.0);
TimeSpan div = t2.Divide(2);

Console.WriteLine(sum);
Console.WriteLine(dif);
Console.WriteLine(mult);
Console.WriteLine(div);