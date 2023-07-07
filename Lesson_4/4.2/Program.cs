// Вывести массив из случайных чисел от 0 до 1 длинной в 8 символов.

void Array(int[] collection)
{
  int index = 0;
  while (index < collection.Length)
  {
    collection[index] = new Random().Next(0, 2);
    index++;
  }
}

void PrintArray(int[] col)
{
  int i = 0;
  while (i < col.Length)
  {
    Console.Write(col[i]);
    i++;
  }
}

int[] array = new int[8];

Array(array);
PrintArray(array);