// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] MassNums(int size, int from, int to)
{
  int[] arr = new int[size];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(from, to);
  }
  return arr;
}

void PrintArray(int[] arr)
{
  int sumOdd = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write(arr[i] + " ");
  }

  for (int i = 2; i < arr.Length; i += 2)
  {
    sumOdd = sumOdd + arr[i];
  }
  Console.Write($"Сумма чисел на нечетных позициях -> {sumOdd}");
}

int[] mass = MassNums(8, 1, 10);
PrintArray(mass);
