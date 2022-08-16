// Задача 27 принимает на вход число и выдает сумму цифр в числе - 452 - 11
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

//*************************
int DigitsSum (int number)
{
    int sum = 0;
    while( number > 0)
    {
        sum += number %10;
    number /=10;
    }

return sum;
}
Console.WriteLine (DigitsSum (number));









