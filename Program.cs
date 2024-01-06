using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "8319", modelo: "Modelo G-3000", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Nokia(numero: "8581", modelo: "Modelo Nimbus-2000", imei: "934", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");