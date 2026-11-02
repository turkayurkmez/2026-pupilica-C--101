/*
 * Kullanıcı, sınıfında kaç gişi olduğunu girer.
 * Uygulama; tek tek öğrencilerin isimlerini ve arkasından aldığı notu sorar.
 * Sınıftaki kişi kadar öğrenci ve not girildiğinde; uygulama ders ortalamasını, kaç kişinin başarılı olduğunu raporlar.
 * 
 * 
 */

Console.WriteLine("Sınıfta kaç öğrenci var?");
int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());
string[] isimler = new string[ogrenciSayisi];
int[] notlar = new int[ogrenciSayisi];



for (int index = 0; index < ogrenciSayisi; index++)
{
    Console.WriteLine($"{index+1}. Öğrencinin adını giriniz:");
    isimler[index] = Console.ReadLine();
    Console.WriteLine($"{index+1}. Öğrencinin notunu girin");
    notlar[index] = Convert.ToInt32(Console.ReadLine());




}
Console.WriteLine("--------------- Rapor ------------");
int toplam = 0;
int basariliOlanlarinSayisi = 0;
foreach (var puan in notlar)
{
    toplam += puan;
    if (puan >= 70)
    {
        basariliOlanlarinSayisi++;
    }
}
int ortalama = toplam / ogrenciSayisi;
Console.WriteLine($"Sınav ortalaması: {ortalama} ve toplam başarılı sayısı: {basariliOlanlarinSayisi}");

int enBuyuk = notlar[0];
int ogrenciIndex = 0;
for (int i = 1; i < notlar.Length; i++)
{
    if (notlar[i] > enBuyuk)
    {
        enBuyuk = notlar[i];
        ogrenciIndex = i;
    }
}

Console.WriteLine($"En yüksek puan:{enBuyuk} ve bu puanı {isimler[ogrenciIndex]} aldı");
