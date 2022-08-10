// Задание 16
Console.WriteLine("Введите число от 1 до 7");
int Number = Convert.ToInt32(Console.ReadLine());
if  ((Number == 1) || (Number == 2) || (Number == 3) || (Number == 4) || (Number == 5 ))
{
    Console.WriteLine("нет");
}
else
{
    if ((Number == 6) || (Number == 7))
      {
        Console.WriteLine("да");
      }
      else
      {
        Console.WriteLine("нет такого дня недели");
      }
}

    