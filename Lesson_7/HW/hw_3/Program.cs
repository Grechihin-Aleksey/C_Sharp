// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num);

void Print(int[,] arr)
{
  int row_size = arr.GetLength(0);
  int column_size = arr.GetLength(1);

  for (int i = 0; i < row_size; i++)
  {
    for (int j = 0; j < column_size; j++)
      Console.Write($" {arr[i, j],1} ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

int[,] MassNums(int row, int column)
{
  int[,] arr = new int[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      arr[i, j] = new Random().Next(1, 10);

  return arr;
}

void ArrayNum(int[,] arr)
{
  for (int j = 0; j < arr.GetLength(1); j++)
  {
    double sum = 0;
    double rez = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      sum += mass[i, j];
      rez = sum / arr.GetLength(0);
    }
    Console.Write("  " + "{0:0.00}", rez);
  }
}

Print(mass);
ArrayNum(mass);


