//  3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.
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

void ArraySumDiagonal(int[,] array)
{
  int sum = 0;
  if (array.GetLength(0) != array.GetLength(1))
      {
        Console.WriteLine("Нет прямой диагонали");
        return;
      }
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    {
    if (i == j) sum += array[i, j];
    }
  Console.WriteLine($"Сумма чисел основной диагонали {sum}");
}



Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);



int[,] mass = MassNums(row_num, column_num);


Print(mass);
ArraySumDiagonal(mass);



