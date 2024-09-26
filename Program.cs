using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone("(16) 123456-4789", "15 PRO MAX", "51654789461651", 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");


Smartphone Nokia = new Nokia("(11) 45687-1234", "3310", "2", 8);
Nokia.Ligar();
Nokia.ReceberLigacao();
Nokia.InstalarAplicativo("Facebook");
