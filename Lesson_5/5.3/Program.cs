// Задайте массив из 123 случайных чисел.
//  Найти колличество числе, лежащих в отрезке от 10 до 99.

int[] Array(int num)
{
  int[] arr = new int[num];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(0, 200);
    Console.Write(arr[i] + " ");
  }
  return arr;
}

int printArr(int[] col)
{
  int sam = 0;
  for (int j = 0; j < col.Length; j++)
  {
    if (col[j] > 10 && col[j] < 99) sam += 1;
  }
  return sam;
}

int[] newArray = Array(123);
Console.WriteLine("");
Console.WriteLine("Элементов: " + printArr(newArray) + 
" находящихся в диапазоне");


