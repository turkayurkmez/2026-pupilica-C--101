Console.WriteLine("Lütfen kullanıcı adını giriniz");
string kullaniciAdi = Console.ReadLine();
Console.WriteLine("Şifrenizi girin");
string sifre = Console.ReadLine();

bool kullaniciAdiDogruMu = kullaniciAdi == "admin" || kullaniciAdi == "ADMIN";
bool sifreDogruMu = sifre == "admin!123";
bool kullaniciAdminMi = kullaniciAdiDogruMu && sifreDogruMu;

if (kullaniciAdminMi) //-> Burası doğruysa, yani değer true ise
{
    Console.WriteLine("Uygulamaya hoş geldiniz....");
    //buradaki işi yap
}
else if (kullaniciAdi == "user" && sifre == "u*987")
{
    Console.WriteLine("Hoşgeldin user....");
}
else
{
    Console.WriteLine("Giremezsiniz...");
}






