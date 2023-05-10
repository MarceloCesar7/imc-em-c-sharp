using System.Globalization;
double peso, altura, imc;
Console.WriteLine("Entra com o valor do peso:");
peso = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Entra com o valor da altura:");
altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
imc = peso / (altura * altura);

if (imc <=18.5)
    Console.WriteLine("magreza");

if (imc >= 18.5 && imc <= 24.9)
    Console.WriteLine("Normal");

if (imc >= 25 && imc <= 29.9)
    Console.WriteLine("Sobrepeso");

if (imc >= 30 && imc <= 39.9)
    Console.WriteLine("obesidade");

if (imc >= 40.0)
    Console.WriteLine("obesidade grave");

Console.WriteLine("Seu imc é " + imc.ToString("F2"), CultureInfo.InvariantCulture);