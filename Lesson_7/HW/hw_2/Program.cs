// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите число позиции в строке: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число позиции в столбце: ");
int m = int.Parse(Console.ReadLine()!);

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

string ArrayNum(int[,] array, int num1, int num2)
{
  if (array.GetLength(0) < num1 || array.GetLength(1) < num2) return $"Такого числа нет в массиве";
  else
  {
    for (int i = 0; i < array.GetLength(0); i++)
      for (int j = 0; j < array.GetLength(1); j++)
        if (array[i, j] == array[num2 - 1, num1 - 1])
          return $"Искомое число:  {array[i, j]} [{num1 - 1}, {num2 - 1}]";
  }
  return "";
}

int[,] mass = MassNums(row_num, column_num);
Print(mass);
Console.WriteLine(ArrayNum(mass, n, m));
