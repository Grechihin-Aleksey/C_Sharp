// Задайте двумерный массив. Найдите элементы у которых обе позыции четные и
// замените эти элемнты их квадратами
void Print(int[,] arr)
{
int row_size = arr.GetLength(0);
int column_size = arr.GetLength(1);

for (int i = 0; i < row_size; i++)
{
for (int j = 0; j < column_size; j++)
Console.Write($" {arr[i, j], 1} ");
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

int[,] ArrayNums(int[,] array)
{
for (int i = 1; i < array.GetLength(0); i+=2)
for (int j = 1; j < array.GetLength(1); j+=2)
array[i, j] *= array[i, j];

return array;
}



Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);



int[,] mass = MassNums(row_num, column_num);


Print(mass);
Console.WriteLine();
ArrayNums(mass);
Print(mass);

