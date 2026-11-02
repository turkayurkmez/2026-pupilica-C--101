Console.WriteLine("Hello, World!");
int[] sayilar = { 95, 50, 65 };// -10, 44, 3, 78 };

//sayilar isimli array içinde yer alan sayıları toplamak istiyorum.
//array'in son elemanına gelmediğim SÜRECE

int index = 0;
int toplam = 0;
while (index < sayilar.Length) //döngünün koşulu mantıksal
{
    toplam += sayilar[index++];
    
}

Console.WriteLine(toplam);
toplam = 0;
for (int inx = 0; inx < sayilar.Length; inx++) //sayısal bir başlangıç....
{
    toplam += sayilar[inx];
}

toplam = 0;
foreach (var sayi in sayilar)
{
    toplam += sayi;
}



