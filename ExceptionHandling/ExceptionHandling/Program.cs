/*
 * Kullanıcının verdiği iki tam sayıyı 
 * birbirlerine bölüp sonucu veren bir uygulama.
 * 
 * 1. Birinci sayıyı kullanıcıdan ister.
 * 2. Girilen değeri int tipine çevirir.
 * 
 * 3. İkinci sayıyı kullanıcıdan ister.
 * 4. Bu değeri de int tipine çevirir.
 * 
 * 5. 2 ve 4. adımlardaki değişkeni böler.
 */

try
{
	Console.WriteLine("Birinci sayıyı giriniz");
	int sayi1 = Convert.ToInt32(Console.ReadLine());

    if (sayi1 < 0)
    {
		throw new Exception("Sayı 0'dan küçük olamaz. Lütfen 0'dan daha büyük bir sayı giriniz");
    }

    Console.WriteLine("İkinci sayıyı giriniz");
	int sayi2 = Convert.ToInt32(Console.ReadLine());

	int sonuc = sayi1 / sayi2;
	Console.WriteLine($"Bölüm sonucu: {sonuc} "); //string interpolation
}
catch (FormatException)
{

	Console.WriteLine("Lütfen sadece sayı giriniz.");
	//throw;
}
catch (DivideByZeroException)
{
	Console.WriteLine("Tam sayılar 0'a bölünemez");
}
catch (Exception error )
{
	Console.WriteLine($"Bilinmeyen bir hata oluştu. Hata mesajı: {error.Message}");
	
}

