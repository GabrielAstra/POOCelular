using InterfacePOO.Models;

Console.WriteLine("Modelo do celular Nokia");

Smartphone nokia = new Nokia(numero: "123456", modelo: "NokiaSprit", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");


Console.WriteLine("Modelo do celular Iphone");
Smartphone iphone = new Iphone(numero: "123", modelo:"12 Pro MAX", imei:"2131421124", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");