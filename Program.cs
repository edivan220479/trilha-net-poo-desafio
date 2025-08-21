
using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone("123456789", "iPhone 13", "Apple", 256);
Console.WriteLine($"Smartphone iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Smartphone nokia = new Nokia("987654321", "Nokia 3310", "Nokia", 128);
Console.WriteLine($"Smartphone nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");
