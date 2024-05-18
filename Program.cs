using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia("99998888", "NokiaOne", "111", 248);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone");

Smartphone iphone = new Iphone("11112222", "Iphone 17 pro max", "222", 1024);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");