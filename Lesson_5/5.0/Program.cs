// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

int[] Array (int lenght, int start, int end)
{
  int[] arr = new int[lenght];
  for (int i = 0; i < lenght; i++)
  arr[i] = new Random().Next(start, end);
  return arr;
}

void printArray(int[] col)
{ 
  int sum = 0;
  for (int i = 0; i < col.Length; i++)
  Console.Write(col[i] + " ");
  Console.WriteLine();

  // Можно реализовать внутри функции printArray

  // int pos, neg;
  // pos = neg = 0;

  // for (int i = 0; i < col.Length; i++)
  // {
  //   if (col[i] >= 0) pos += col[i];
  //   else neg += col[i];
  // }
  // Console.WriteLine($"Сумма положительных чисел : {pos}");
  // Console.WriteLine($"Сумма Отрицательных чисел : {neg}");
}

void SumPosNeg (int[] array)
{
  int pos, neg;
  pos = neg = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] >= 0) pos += array[i];
    else neg += array[i];
  }
  Console.WriteLine($"Сумма положительных чисел : {pos}");
  Console.WriteLine($"Сумма Отрицательных чисел : {neg}");
}

int[] mass = Array (12, -9, 10)!;
printArray (mass);
SumPosNeg (mass);
