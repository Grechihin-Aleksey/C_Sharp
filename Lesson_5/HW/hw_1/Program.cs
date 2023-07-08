// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] MassNums (int size, int from, int to)
{
 int[] arr = new int[size];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(from, to);
  }
  return arr;
}

void PrintArray (int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write(arr[i] + " ");
    if (arr[i] % 2 == 0) count = count + 1;
  }
  Console.WriteLine();
  Console.Write("Колличество четных чисел в массиве -> " + count);
}


int[] mass = MassNums (8, 100, 1000);
PrintArray (mass);