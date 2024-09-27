using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Nokia celularNokia = new Nokia("1234", "modelo 1", "imei1", 8);
celularNokia.Ligar();
celularNokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Iphone celularIphone = new Iphone("5679", "modelo 16", "imei2", 16);
celularIphone.ReceberLigacao();
celularIphone.InstalarAplicativo("WhatsApp");