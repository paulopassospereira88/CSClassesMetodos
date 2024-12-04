using PartialClass;

MinhaPartialClass partialClass = new MinhaPartialClass();

Console.WriteLine("Idade para nascidos em : 07/08/2003\n");

var idade = partialClass.CalculaIdade(new DateTime(2003, 8, 7));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");

Console.WriteLine("\nIdadae para os nascidos em : 02/06/2005");

var data1 = DateTime.Now;
var data2 = new DateTime(2005, 06, 02);
var diferenca = partialClass.DiferencaEntreDatas(data1, data2);
Console.WriteLine($"{Math.Round(diferenca.TotalDays / 365)} anos");