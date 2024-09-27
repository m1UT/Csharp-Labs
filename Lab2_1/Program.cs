int[] numbers = {10, 22, 31, 45, 25, 17, 6, 34};
int sum = 0;

Console.Write("Выберите диапазон (P<T) \nВведите P: ");
int P = Convert.ToInt32(Console.ReadLine());
Console.Write("Выведите T: ");
int T = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 5; i++)
    if (numbers[i] > P && numbers[i] < T) 
        sum = sum + numbers[i];
Console.WriteLine("Ответ: " + Convert.ToString(sum));



