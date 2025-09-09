﻿using DesafioPOO.Models;

Nokia nokia = new Nokia("99999-9999", "Nokia Tijolão", "111111", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("-----------------------------");

Iphone iphone = new Iphone("88888-8888", "iPhone 14 Pro", "222222", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
