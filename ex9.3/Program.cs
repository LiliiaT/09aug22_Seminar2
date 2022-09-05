// 9.3 Найти сумму элементов от M до n, n и M заданы

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;

string NumbersRec(int m, int n)
{
    if (m <= n) return NumbersRec(m + 1, n) + $"{m} ";
    else return String.Empty;
}

Console.WriteLine(NumbersRec(n, m));

if (m > n)
{
    m = n;
    n = temp;
}

SumRec(m, n, temp = 0);

void SumRec(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов от M до N = {sum} ");
        return;
    }
    SumRec(m, n - 1, sum);
}