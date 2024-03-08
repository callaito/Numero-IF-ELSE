// See https://aka.ms/new-console-template for more information
using System.Linq;

Console.WriteLine("Hello, World!");


Double numero;


Console.Write("numero: ");
numero = Convert.ToDouble(Console.ReadLine());

if (numero%2 ==0)
{
    Console.WriteLine("Es un numero par.");
}
else
{
    Console.WriteLine("Es un numero impar");
}