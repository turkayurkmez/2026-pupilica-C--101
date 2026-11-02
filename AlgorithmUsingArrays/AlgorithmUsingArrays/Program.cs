/*
 * Kullanıcının klavyeden girdiği iki basamaklı sayıyı türkçe okunuşuna çeviren uygulama.
 * 
 * 93 
 * Doksan üç
 * 
 */

string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };

//Console.WriteLine(onlar[9] + " " + birler[3]);

/*
 * YAP
 * ...
 * ...
 * ..
 *   OLDUĞU SÜRECE
 */

do
{
    Console.WriteLine("100'den küçük bir sayı girin...");
    //birler basağmağının sayısal değerini bulmak için mod'unu alırız.
    //onlar basamağı için sayıyı 10'a bölüp snucunu olurum.
    int sayi = Convert.ToInt32(Console.ReadLine());

    int birlerBasamagi = sayi % 10;
    int onlarBasamagi = sayi / 10;

    Console.WriteLine(onlar[onlarBasamagi] + " " + birler[birlerBasamagi]);
    Console.WriteLine("Başka bir sayı çevirmek ister misiniz (E/H)?");
} while (Console.ReadLine().ToUpper() != "H");





int tamSayi = 562646525;
int basamakSayisi = 0;
while (tamSayi >0)
{
    tamSayi = tamSayi / 10;
    basamakSayisi = basamakSayisi + 1;
   //yap:    
}

Console.WriteLine($"Tam sayı içindeki değer {basamakSayisi} bsamaklıdır");




//while (yasiyorum)
//{
//    Console.WriteLine("Seni Seviyorum");
//}













