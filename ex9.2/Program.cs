//9.2 Показать натуральные числа от M до N, N и M заданы

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
string NumbersRec(int m, int n)
{
    if (m <= n) return NumbersRec(m + 1, n) + $"{m} ";
    else return String.Empty;
}

Console.WriteLine(NumbersRec(n,m)); 
