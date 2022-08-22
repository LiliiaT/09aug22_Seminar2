// Задача 34
int size = 10;
int[] numbers = new int[size] ;
int count = 0;
FillArrayRandomNumbres(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)

{
    if( numbers[i] %2 == 0)
    {
        count++;
    }
        
}
Console.WriteLine($"количество четных чисел в данном массиве: {count}");

//***********************

void FillArrayRandomNumbres(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

