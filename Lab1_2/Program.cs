int n=1;
double y=0;

Console.Write("Введите x: ");
Double x = Convert.ToDouble(Console.ReadLine());

while (n <= 20)
{   
    y = y + Math.Pow(x, n-1)/(2*n+1);
    n ++;
}

Console.WriteLine("Ответ: "+Convert.ToString(y));



