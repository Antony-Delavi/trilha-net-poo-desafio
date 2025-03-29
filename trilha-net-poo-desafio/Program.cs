using DesafioPOO.Models;

Console.WriteLine("Nokia");
Nokia nokia = new Nokia(numero: "12348412", modelo: "Minizinha", imei: "120984371", memoria: 124);
nokia.Ligar();
nokia.InstalarAplicativo("Linkedin");

Console.WriteLine("\n");

Console.WriteLine("SIphone");
Iphone iphone = new Iphone(numero: "12348412", modelo: "Minizinha", imei: "1201", memoria: 124);
iphone.Ligar();
iphone.InstalarAplicativo("Youtube");