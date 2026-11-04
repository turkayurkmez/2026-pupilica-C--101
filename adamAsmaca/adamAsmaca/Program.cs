Console.WriteLine("Hello, World!");
/*
 * 1. Rastgele kelime listesi içinden bir kelime seç.
 * 2. Bu seçilen kelimeyi, maskeleyerek (---) göster.
 * 3. o ana kadar girilen kelimeleri, kalan hak sayısını göster.
 * 4. kullanıcıdan harf al
 * 5. Harf kelimede var mı kontrol et
 *    5a. Eğer harf varsa o harfin yerini aç
 *    5b. Eğer yoksa haktan bir düş ve uyar.
 * 6. Kazandı mı?
 * 7. Sonucu yazdır.   
 */
// Rastgele kelime listesi içinden bir kelime seç.
string chooseRandomWord(string[] words)
{
    int index = new Random().Next(words.Length);
    return words[index];
}


//  2. Bu seçilen kelimeyi, maskeleyerek (---) göster.

string maskWord(string word, string suggestion)
{
    string masked = string.Empty;

    //tahminler: cfv
    //- - - 
    //c - - 

    for (int i = 0; i < word.Length; i++)
    {
        char letter = word[i];
        if (suggestion.IndexOf(letter) >= 0)
        {
            masked += letter;
        }
        else
        {
            masked += "_";
        }
        masked += " ";
    }
    return masked.Trim();
}



//string randomWord = chooseRandomWord(words);
//Console.WriteLine(maskWord(randomWord,""));
//o ana kadar girilen kelimeleri, kalan hak sayısını göster.
void showReport(string maskedWord, int lastCount, string wrongLetters)
{
    Console.WriteLine();
    Console.WriteLine($"Maskeli kelime: {maskedWord}");
    Console.WriteLine($"Kalan hak: {lastCount}");
    Console.WriteLine($"Yanlış harfler: {wrongLetters}");
}


char getLetterFromUser(string suggests)
{
    while (true)
    {
        Console.Write("Bir harf giriniz...");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || input.Length != 1)
        {
            Console.WriteLine("Sadece tek bir harf giriniz...");
            continue;
        }

        char letter = char.ToLower(input[0]);
        //if (letter < 'a' || letter > 'z')
        //{
        //    Console.WriteLine("Lütfen a ile z arasında bir harf girin");
        //    continue;
        //}

        if (suggests.IndexOf(letter) >= 0)
        {
            Console.WriteLine("Bu harfi zaren denediniz");
            continue;
        }

        return letter;
    }
}

bool isWordIncludeLetter(char letter,  string word)
{
    return word.IndexOf(letter) >= 0;
}

bool isWin(string word,  string suggests)
{
    for (int i = 0; i < word.Length; i++)
    {
        if (suggests.IndexOf(word[i]) < 0)
        {
            return false;
        }
    }

    return true;
}

void finallyOutput(bool isWin, string word)
{
    Console.WriteLine();
    if (isWin)
    {
        Console.WriteLine("Tebrikler kazandınız!");
    }
    else
    {
        Console.WriteLine($"Hakkınız bitti. Kelime: {word} olacaktı.");
    }
}


string[] words = { "değişken", "long", "switch", "array", "random" };

int counter = 6;
string puzzle = chooseRandomWord(words);
string tryingLetters = string.Empty; //tüm harfler
string wrongLetters = string.Empty; //sadece yanlış harfler
int remainingCount = counter;

Console.WriteLine("================= Kelime tahmin oyunu ================= ");
Console.WriteLine();
while (remainingCount > 0 && !isWin(puzzle,tryingLetters))
{
    string masked = maskWord(puzzle, tryingLetters);
    showReport(masked, remainingCount, wrongLetters);
    char letter = getLetterFromUser(tryingLetters);
    tryingLetters += letter;
    if (!isWordIncludeLetter(letter,puzzle))
    {
        remainingCount--;
        wrongLetters += letter + " ";
    }

    
}

finallyOutput(isWin(puzzle, tryingLetters), puzzle);

