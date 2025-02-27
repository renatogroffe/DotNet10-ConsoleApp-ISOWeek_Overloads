using System.Globalization;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com .NET 10 | Novos overloads na classe estatica ISOWeek *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

var currentDate = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine();
Console.WriteLine($"Data atual: {currentDate}");
Console.WriteLine($"Semana do ano: {ISOWeek.GetWeekOfYear(currentDate)}");
Console.WriteLine($"Ano: {ISOWeek.GetYear(currentDate)}");

var firstFriday2025 = ISOWeek.ToDateOnly(2025, 1, DayOfWeek.Friday);
Console.WriteLine($"Primeira sexta-feira de 2025: {firstFriday2025}");