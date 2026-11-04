/*
 * Bilgisayar, 1 - 100 arasında bir sayı tutar.
 * Kullanıcı, sayıyı tahmin eder.
 * Eğer tutulan sayı, kullanıcının tahmin ettiğinden küçükse "AŞAĞI" yazar.
 *  "                                                büyükse "YUKARI" yazar
 * Kullanıcı bilene kadar oyun devam eder.
 */

int min = 0;
int max = 100;

int randomNumber = generateNumber(min, max);

bool isGameOver = false;
while (!isGameOver)
{
    int suggestedNumber = getNumberFromUser();
    isGameOver = duringGame(randomNumber, suggestedNumber);
}










static int generateNumber(int min, int max)
{
    Random randomNumberGenerator = new Random();
    int randomNumber = randomNumberGenerator.Next(min, max);
    return randomNumber;
}

static bool duringGame(int randomNumber, int suggestedNumber)
{
    bool state = false;
    if (randomNumber < suggestedNumber)
    {
        Console.WriteLine("AŞAĞI");
    }
    else if (randomNumber > suggestedNumber)
    {
        Console.WriteLine("YUKARI");
    }
    else
    {
        Console.WriteLine("Bildiniz!");
        state = true;
    }

    return state;
}

static int getNumberFromUser()
{
    Console.WriteLine("Sayıyı tahmin edin:");
    int suggestedNumber = Convert.ToInt32(Console.ReadLine());
    return suggestedNumber;
}