Console.WriteLine("Hello, World!");
/*
 * Sayısal: matematikel 
 *   - Tam sayı
 *   - Ondalıklı sayı
 * 
 * Sözel
 * 
 * Mantıksal 
 *  
 */

byte enKucuk = 255;

sbyte isaretAlabilenByte = -1;

short onaltiBit = 32767;

ushort isaretsizOnalti = 65535;

int varsayilanTamsayi = 2_147_483_647;

//int a = 1;
//int b = 5;
//int c = a + b;

long altmisDortBit = 9_223_372_036_854_775_807;

//Ondalıklı
double pi = 3.14d;
float floatPi = 3.14f;
decimal decimalPi = 3.145901234272738384845858686837476456566768658873763636547457578687987899899898m;

//sözel:
char sembol = '?';

string isim = "Türkay";
String soyad = "Ürkmez";

bool havaYagmurluMu = false;

Console.WriteLine("Lütfen doğum yılınızı giriniz:");


int dogumYili = Convert.ToInt16(Console.ReadLine());
int suaAnkiYil = DateTime.Now.Year;

int yas = suaAnkiYil - dogumYili;
Console.WriteLine(yas);

byte x = 30;
int y = x;

byte a = 255;
byte b = 2;

int sonuc = a + b;
checked
{
    byte hadiBakalim = (byte)(a + b);
    Console.WriteLine(hadiBakalim);
}



Console.WriteLine(sonuc);