double[,] X;

Console.Write("\nРазмерность массива [n, m] \nВведите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

X = new double[n, m];
Console.WriteLine("\nВведите элементы массива:");
for (int i = 0; i < n; i++)
    for (int j = 0; j < m; j++)
    {
        Console.Write("X[" + (i + 1) + ", " + (j + 1) + "] ");
        X[i, j] = Convert.ToInt32(Console.ReadLine());
    }

for (int i = 0; i < n; i++)
    for (int j = 0; j < m; j++)
    {
        if (X[i, j] > 0)
            X[i, j] = X[i, j] * 5;
        else if (X[i, j] < 0)
            X[i, j] = X[i, j] / 2;
    }

Console.WriteLine("\nМассив:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write(X[i, j] + " ");
    Console.WriteLine();
}




