int AckermanFunc(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (m == 0)
    {
        return AckermanFunc(n - 1, 1);
    }
    else
    {
        return AckermanFunc(n - 1, AckermanFunc(n, m - 1));
    }
}

int InputNumber()
{
    Console.WriteLine("Введите натуральное число:");
    return Convert.ToInt32(Console.ReadLine());
}

int M = InputNumber();
while (M < 0)
{
    Console.WriteLine("Число не должно быть отрицательным!");
    M = InputNumber();
}

int N = InputNumber();
while (N < 0)
{
    Console.WriteLine("Число не должно быть отрицательным!");
    N = InputNumber();
}

Console.WriteLine();

Console.Write($"M - {M}; N = {N} -> A(m,n) = {AckermanFunc(N, M)}");

Console.WriteLine();
