// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] matr = FillMatrix(2, 2, 2);
PrintMatrix(matr);

//**********************

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            Console.Write($" {matrix[i, j, k]} ( {i},{j},{k}) \t");
        }
        Console.WriteLine();
    }
    
}

int[,,] FillMatrix(int rowsCount, int columnsCount, int xCount)
{
    int[,,] matrix = new int[rowsCount, columnsCount, xCount];
    Random rand = new Random();
    int count=1;


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = 9 + count;
                count++; 
            }
        }
    }

    return matrix;

}