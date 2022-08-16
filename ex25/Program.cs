// Задача 25 Цикл принимает на вход два числа А и B и возводит число A в натур.ст. B
int numberA = ReadInt("Первое число: ");
int numberB = ReadInt("Второе число: ");
int numberC = 1;
int numberD = 1;

for(int i = 1; i <= numberB; i++)
{
    numberC = numberA * numberA;
    numberD *= numberA;

}

Console.WriteLine(numberD);



//************************************
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


