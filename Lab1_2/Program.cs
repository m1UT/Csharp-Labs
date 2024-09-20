int n=1;
double y=0;

Console.Write("Введите x: ");
Double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Convert.ToString(x));

while (n <= 20)
{   
    y = y + Math.Pow(x, n-1)/(2*n+1);
    n ++;
}

Console.Write("Ответ: "+Convert.ToString(y));