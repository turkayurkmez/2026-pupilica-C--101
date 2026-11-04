Console.WriteLine("Hello, World!");

void showMessage(string message)
{
    Console.WriteLine(message);
}

void sendEmail(string from, string to, string message)
{
    Console.WriteLine($"{from} adresinden {to} adresine mail gönderildi: {message}");
}

bool isEven(int value)
{
    return value % 2 == 0;
}


showMessage("Bu bir mesajdır");
showMessage("Bu da başka bir mesajdır");

sendEmail("turkay.urkmez@gmail.com", "turkay@hotmail.com", "Merhaba");

string converToTurkishReading(int number)
{
    //1. number 99'dan büyük olamaz.
    if (number >= 100)
    {
        throw new ArgumentException("sayı 100'den küçük olmalı!");

    }
    string[] readingForTen = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
    string[] readingForOne = { "", "bir", "iki", "üç", "dort", "bes", "altı", "yedi", "sekiz", "dokuz" };
    int valueOfTen = number / 10;
    int valueOfOne = number % 10;

    string turkishReading = $"{readingForTen[valueOfTen]} {readingForOne[valueOfOne]}";
    return turkishReading;
}

void showTurkishReading()
{
    for (int i = 1; i < 100; i++)
    {
        string turkish = converToTurkishReading(i);
        Console.WriteLine(turkish);
    }
}



if (isEven(16))
{
    Console.WriteLine("Çift");
}
else
{
    Console.WriteLine("Tek");
}

showTurkishReading();



void convertOneNumber()
{
    bool isValid = true;
    do
    {
        Console.WriteLine("Lütfen bir sayı girin:");
        int number = Convert.ToInt32(Console.ReadLine());

        try
        {
            isValid = true;
            string reading2 = converToTurkishReading(number);
            Console.WriteLine(reading2);

        }
        catch (ArgumentException ex)
        {
            isValid = false;
            Console.WriteLine(ex.Message);

        }

    } while (!isValid);
}



convertOneNumber();