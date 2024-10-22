using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", _IMEI: "21452541", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("Smartphone iphone");
Smartphone iphone = new Iphone(numero: "789456", modelo: "Modelo 2", _IMEI: "25365241", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
