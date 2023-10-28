using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando Nokia: ");
Nokia n1 = new("600390334", "9384759", "Nokia3310", 64);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Xwitter");

Console.WriteLine("\n");

Console.WriteLine("Testando Iphone: ");
Iphone iph = new("555097999", "23749768", "Iphone2", 16);
iph.Ligar();
iph.ReceberLigacao();
iph.InstalarAplicativo("Bluesky");
