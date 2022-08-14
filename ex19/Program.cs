// Задание 19
int number = ReadInt("Введите пятизначное число: ");
string num = number.ToString();

 if ((num [0]== num[4]) && (num [1] == num[3]))
    {
        Console.WriteLine("число палиндром");
       
    }
else 
    {
        Console.WriteLine("число не палиндром");
    
    }

//*************************
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

