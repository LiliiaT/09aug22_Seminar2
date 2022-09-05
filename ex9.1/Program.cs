// 9.1 Показать натуральные числа от n до 1, n задано


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;

string numbersRec(int n, int m)
{
    if (n <= m) return numbersRec(n + 1, m) + $"{n} ";
    else return String.Empty;
}

Console.WriteLine(numbersRec(m,n)); 


