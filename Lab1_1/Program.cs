double x, y, f=0, a;
int n = 0;

Console.Write("Введите X = ");
string? s = Console.ReadLine();
x = Convert.ToDouble(s);
Console.Write("Введите Y = ");
s = Console.ReadLine();
y = Convert.ToDouble(s);

Console.WriteLine("Выберите f:\n1 - x^2\n2 - e^x\n3 - sh(x)");
s = Console.ReadLine();
n = Convert.ToInt16(s);
switch(n)
{
    case 1: f=Math.Pow(x,2); break;
    case 2: f=Math.Exp(x); break;
    case 3: f=Math.Sinh(x); break;
}

if (x*y>0)
    a=Math.Pow(f+y, 2)-Math.Pow(Math.Abs(f), 1.0/3);
else if (x*y<0)
    a=Math.Pow(f+y, 2)+Math.Sin(x);
else
    a=Math.Pow(f+y, 2)+Math.Pow(y, 3);

Console.WriteLine("Ответ: "+Convert.ToString(a));



