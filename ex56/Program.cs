// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matr = FillMatrix(3, 4);
PrintMatrix(matr);
int minSumRow = 0;
int sum = SumRowNumber(matr, 0);
for (int i = 1; i < matr.GetLength(0); i++)
{
    int temp = SumRowNumber(matr, i);
    if (sum > temp)
    {
        sum = temp;
        minSumRow = i;
    }
}
Console.WriteLine($"Строка с мин суммой: {minSumRow + 1}");

//**********************

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

int[,] FillMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 10);
        }
    }

    return matrix;

}

int SumRowNumber(int[,] matrix, int i)
{
    int sum = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
    return sum;


}
