using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

var nokia = new Nokia("123", "Nokia", "123", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

var iphone = new Iphone("123", "Iphone", "123", 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
