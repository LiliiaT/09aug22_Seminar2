// Задача 36

int size = 10;
int[] numbers = new int[size];
int count = 0;
FillArrayRandomNumbres(numbers);
PrintArray(numbers);
int sum = 0;


for (int i = 1; i < numbers.Length; i=i+2)
{
    sum += numbers[i];
    count++;
}
Console.WriteLine(sum);


void FillArrayRandomNumbres(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write( "[{0}]", string.Join (",", array[i] ));
    }
    Console.WriteLine();
}

