using ConsoleCurrencyBalance.Entidade;
using System.Globalization;

Console.WriteLine("----------------------- BANCO JB ------------------- ");
Console.WriteLine("----------------------  Welcome  ------------------- ");

Account CurrentBalance = new Account();
Console.Write("Informe o número da conta :");
CurrentBalance.NumberAccount = int.Parse(Console.ReadLine());
Console.Write("Entre com o titular da conta: ");
CurrentBalance.NameAccount = Console.ReadLine();
Console.WriteLine("Haverá depósito Inicial (S/N) ? ");
char Question1 = Console.ReadKey().KeyChar;

if (Question1 == 'S')
{
    Console.WriteLine("Entre o valor de depósito inicial: ");
    CurrentBalance.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
    Console.WriteLine("Dados da conta: " + CurrentBalance);
}

Console.Write("Entre um valor para depósito:");
CurrentBalance.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
Console.WriteLine("Dados atualizados: " + CurrentBalance);
Console.Write("Entre com um valor para saque:");
CurrentBalance.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
Console.WriteLine("Dados da conta atualizados: " + CurrentBalance);
