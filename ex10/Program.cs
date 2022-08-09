// Задание 10

Console.WriteLine("Введите трехзначное число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber >= 100 && firstNumber <= 999)
{
    int SecondDigit (int number)
{
    int result = (firstNumber / 10) % 10;

    return result;
}
Console.WriteLine( SecondDigit (firstNumber));
}

else 
{
    Console.WriteLine("это не трехзначное число:");
}