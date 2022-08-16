// Задача 29. Задает массив из N элементов и выводит на экран отдельным методом
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[number];
FillArray(numbers);
PrintArray(numbers);

//********************

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}