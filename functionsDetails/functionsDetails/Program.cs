using functionsDetails;

Console.WriteLine("Hello, World!");




int divide(int a, int b)
{
    
    return a / b;
}

int divideWithOutput(int a, int b, out int modulo)
{
    modulo = a % b;
    return a / b;
}

bool isConvertToInt(string value,  out int result)
{
	try
	{
		result = Convert.ToInt32(value);
		return true;

	}
	catch (Exception)
	{
		result = 0;
		return false;
		
	}
}


int result = divide(10, 2);


int kova = 0;
int result2 = divideWithOutput(13,3,out kova);

Console.WriteLine($"Bölme işleminin sonucu: {result2}. Bu işlemden kalan değer (mod): {kova}");

Console.WriteLine("Bir sayı giriniz:");
string value = Console.ReadLine();
int output = 0;
if (isConvertToInt(value, out output))
{
    Console.WriteLine(output);
}

int getAverage(params int[] values)
{
	int total = 0;
    foreach (var item in values)
    {
		total += item;
    }

	return total / values.Length;
}


void someThing(ref int number)
{
	//karavanın içindeki sayı *2;
	number *= 2;
    Console.WriteLine("Burası, metodun içi: "  + number);
}

int avg = getAverage(13, 6, 9, 25, 36, 44,25,10,1,231);
Console.WriteLine(avg);

//karavandaki değer:
int x = 5;
Console.WriteLine("Metodu çağırmadan önce:" + x);

//karavandaki birlikte git
someThing(ref x);
//karan içindeki değer hala 10:
Console.WriteLine("Metodu çağırdıktan sonra:"+ x);

Geometry geo = new Geometry();
geo.getArea(5, Geometry.KARE);
geo.getArea(4, 5, Geometry.UCGEN);




