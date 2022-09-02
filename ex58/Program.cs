// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 

int[,] matrfirst = FillMatrix(3, 4);
PrintMatrix(matrfirst);
int[,] matrsecond = FillMatrix(3, 4);
Console.WriteLine(String.Empty);
PrintMatrix(matrsecond);
int[,] matrthird = FillMatrix(3, 4);
GetThirdMatrix(matrfirst, matrsecond, matrthird);
Console.WriteLine(String.Empty);
PrintMatrix(matrthird);


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

void GetThirdMatrix(int[,] matrfirst, int[,] matrsecond, int[,] matrthird)
{

    for (int i = 0; i < matrthird.GetLength(0); i++)
    {
        for (int j = 0; j < matrthird.GetLength(1); j++)
        {
            {
                matrthird[i, j] = matrfirst[i, j] * matrsecond[i, j];
            }

        }
    }
}



