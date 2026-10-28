Console.WriteLine("Lütfen seçiminizi yapın");
Console.WriteLine("1. Renkliler");
Console.WriteLine("2. Beyazlar");
Console.WriteLine("3. Narin kumaşlar");

string yapilanSecim = Console.ReadLine();

if (yapilanSecim == "1")
{
    Console.WriteLine("60 derecede yıkanıyor.");
}
else if (yapilanSecim == "2")
{
    Console.WriteLine("80 derecede yıklanıyor");
}
else if (yapilanSecim == "3")
{
    Console.WriteLine("45 derecede yıkanıyor");
}
else
{
    Console.WriteLine("Hatalı seçim yaptınız....");
}

switch (yapilanSecim)
{
    case "1":
        Console.WriteLine("60 derecede yıkanıyor.");
        break;
    case "2":
        Console.WriteLine("80 derecede yıklanıyor");
        break;
    case "3":
        Console.WriteLine("45 derecede yıkanıyor");
        break;
    default:
        Console.WriteLine("Hatalı seçim yaptınız....");

        break;
}

Console.WriteLine("Menüden bir seçim yapın:");
Console.WriteLine("1. Sinek");
Console.WriteLine("2. Kupa");
Console.WriteLine("3. Karo");
Console.WriteLine("4. Maça");

string sembol = Console.ReadLine();
switch (sembol)
{
    case "1":
    case "4":
        Console.WriteLine("Siyah");
        break;
    case "2":
    case "3":
        Console.WriteLine("Kırmızı");
        break;
    default:
        Console.WriteLine("Menüde böyle bir seçenek yok");
        break;
}



