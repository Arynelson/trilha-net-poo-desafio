using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("NOKIA");
var nokia = new Nokia("123456789", "Nokia 3310", "Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("-------------------");
Console.WriteLine("IPHONE");
var iphone = new Iphone("987654321", "iPhone 12", "Apple");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
