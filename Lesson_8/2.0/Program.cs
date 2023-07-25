﻿// Поменять местами строки и столбцы в двумерном массиве
Console.Write("Кол-во строк ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов ");
int col = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[row, col];

Console.Write("Введите минимальное значение элемента массива : ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
int max = int.Parse(Console.ReadLine()!);

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

void Obmen(int[,] matrix)
{
  if (col != row) Console.Write("Невозможно поменять местами строки и столбцы");
  else
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < i; j++)
      {
        (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);
      }
    }
  }
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Obmen(matrix);
PrintArray(matrix);
