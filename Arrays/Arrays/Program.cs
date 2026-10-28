//1. Elemanlarımın ne olacağı baştan belli

//                     0.          1        2            3          4        5          6
string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

Console.WriteLine(gunler[0]);

//2. Elemanların ne olduğunu bilmiyorum. Ama kaç elemanım olduğunu biliyorum.
int[] puanlar = new int[20];
Console.WriteLine(puanlar[19]);

puanlar[0] = 75;
puanlar[1] = 63;


Console.WriteLine(gunler[gunler.Length-1]);
Console.WriteLine(gunler[^2]);