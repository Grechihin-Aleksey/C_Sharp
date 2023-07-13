// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
  Console.WriteLine(message);
  int res = int.Parse(Console.ReadLine()!);
  return res;
}

int[] InputArray(int length)
{
  int[] array = new int[length];
  for (int i = 0; i < length; i++)
  {
    array[i] = Prompt($"Введите {i + 1} - элемент массива");
  }
  return array;
}

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    Console.Write($"  {array[i]}");
}

int CountPozArr(int[] array)
{
  int countPoz = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0) countPoz++;
  }
  return countPoz;
}

Console.WriteLine("Введите длинну массива");
int length = int.Parse(Console.ReadLine()!);
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Число элементов > 0 --> " + " " + CountPozArr(array));
