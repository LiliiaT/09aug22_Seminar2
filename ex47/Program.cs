// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine()); 

double[,] matr = FillMatrix(m, n, 1, 10);

double[,] FillMatrix(int rowsCount, int columnsCount,int leftRange, int rightRange)
{
    double[,] matrix = new double[rowsCount, columnsCount];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            matrix[i, j] = new Random().NextDouble()*10;
            
        }
    }

    return matrix;
}

void PrintRoundArray (double[,] matr)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double shortNumber = Math.Round(matr[i, j], 1);
        Console.Write(shortNumber + " ");
      }
      Console.WriteLine();
  }
}
PrintRoundArray(matr);