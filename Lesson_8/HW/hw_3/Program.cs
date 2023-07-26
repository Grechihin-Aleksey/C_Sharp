// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
Console.Write("Кол-во строк 1 матрицы");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов 1 матрицы");
int col1 = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во строк 2 матрицы");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов 2 матрицы");
int col2 = int.Parse(Console.ReadLine()!);
int[,] matrix1 = new int[row1, col1];
int[,] matrix2 = new int[row2, col2];
int[,] resultMatrix = new int[row1, col2];

Console.Write("Введите минимальное значение элемента массива : ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
int max = int.Parse(Console.ReadLine()!);

void FillArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(min, max);
    }
  }
}

void PrintArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
  }
}

void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{
  if (matrix1.GetLength(0) != matrix2.GetLength(1))
  {
    Console.WriteLine(" Нельзя перемножить ");
    return;
  }
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i, k] * matrix2[k, j];
      }
      resultMatrix[i, j] = sum;
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

Console.WriteLine("Матрица 1");
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine("Матрица 2");
FillArray(matrix2);
PrintArray(matrix2);
MultiplyMatrix(matrix1, matrix2, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);