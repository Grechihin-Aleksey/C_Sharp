// See https://aka.ms/new-console-template for more information

void Print(double[,] arr)
{
  int row_size = arr.GetLength(0);
  int column_size = arr.GetLength(1);

  for (int i = 0; i < row_size; i++)
  {
    for (int j = 0; j < column_size; j++)
      Console.Write($" {arr[i, j], 4} ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

double[,] MassNums(int row, int column)
{
  double[,] arr = new double[row, column];
  Random n_new = new Random();

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      arr[i, j] = Math.Round(n_new.NextDouble() * (10-2) - 2, 1);
  return arr;
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

double[,] mass = MassNums(row_num, column_num);
Print(mass);
