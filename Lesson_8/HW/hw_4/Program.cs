// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
Console.Write("Кол-во строк ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов ");
int col = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[row, col];


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

int[] MinElem(int[,] arr)
{
  int minNum = arr[0, 0];
  int[] index = new int[2];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (minNum > arr[i, j])
      {
        minNum = arr[i, j];
        index[0] = i;
        index[1] = j;
      }
    }
  }
  Console.WriteLine(arr[index[0], index[1]]);
  return index;
}

void RowColumnDelete(int[,] arr, int[] index)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (index[0] == i || index[1] == j) continue;
      else Console.Write($"{arr[i, j],2}");

    }
    Console.WriteLine();
  }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int[] matrixMin = MinElem(matrix);
RowColumnDelete(matrix, matrixMin);
