Console.WriteLine("Hello, World!");

/*
 * Kullanıcının belirlediği şifrenin aşağıdaki kriterlere göre değerlendirilmesi gerekiyor:
 *   1. 6 karakterden az ise ZAYIF
 *   2. Harf ve sayıdan oluşuyorsa ORTA
 *   3. Harf, sayı ve sembol içeriyorsa GÜÇLÜ 
 *   
 *   Bunu yapan fonksiyona ihtiyacımız var
 */

string validatePassword(string password)
{
    if (password.Length < 6)
    {
        return "ZAYIF";
    }

    bool isDigit = false;
    bool isLetter = false;
    bool isSymbol = false;

    foreach (var item in password)
    {
        if (char.IsDigit(item))
        {
            isDigit = true;
        }
        else if (char.IsLetter(item)) 
        {
            isLetter = true;
        }
        else
        {
            isSymbol = true;
        }

    }

    bool isJustLetter = isLetter && !isDigit && !isSymbol;
    bool isJustDigit = isDigit && !isLetter && !isSymbol;

    if (isJustLetter || isJustDigit)
    {
        return "ZAYIF";
    }

    bool isLetterAndIsDigit = (isLetter && isDigit) && !isSymbol;
    if (isLetterAndIsDigit)
    {
        return "ORTA";
    }

    return "GÜÇLÜ";



}

Console.WriteLine("abc: " +  validatePassword("abc"));
Console.WriteLine("123456: " + validatePassword("123456"));
Console.WriteLine("abcdef:" + validatePassword("abcdef"));
Console.WriteLine("abc123 : " + validatePassword("abc123"));
Console.WriteLine("abc123? :" + validatePassword("abc123?"));


List<double> malzemeler = new List<double>();






