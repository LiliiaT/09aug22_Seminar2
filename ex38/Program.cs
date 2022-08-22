// Задача 38

double [] numbers = new double[5];
FillArrayRandomNumbres(numbers);
PrintArray(numbers);
double min = numbers [0];
double max = numbers [0];
DifMaxMin (numbers);


for(int i = 0; i < numbers.Length; i++)
    {
         if (numbers[i] < min) min = numbers[i];
         if (numbers[i] > max) max = numbers[i];
         
    }   

//****************************

double DifMaxMin (double[] array)
{
    return max - min;
}

Console.WriteLine($"Разница между {max} и {min} равна: {DifMaxMin(numbers)}");

void FillArrayRandomNumbres(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() *100;
    }
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("[" + array[i] + " "+"]");
    }
    Console.WriteLine();
}

