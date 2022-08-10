// Задача 13
Console.Clear();
Console.WriteLine("Введите число:");
int Number = Convert.ToInt32(Console.ReadLine());
string num = Number.ToString();
if ( Number >= 100 )
{
    Console.WriteLine( num[2] );
}
else 
{
    Console.WriteLine ("третьей цифры нет");
}
