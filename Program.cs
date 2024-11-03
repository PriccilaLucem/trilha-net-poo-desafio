// Arquivo: Program.cs ou TesteSmartphone.cs (para testes rápidos)
using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("123456789", "Nokia Modelo X", "111111111111111", 64);
        Console.WriteLine("Testando Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Smartphone iphone = new Iphone("987654321", "iPhone Modelo Y", "222222222222222", 128);
        Console.WriteLine("Testando iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
