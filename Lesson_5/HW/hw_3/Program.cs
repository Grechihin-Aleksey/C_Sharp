// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void mass(double[] numbers)
{
  for (int i = 0; i < numbers.Length; i++)
  {
    numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
  }
}
void PrintArray(double[] numbers)
{
  double min = numbers[0];
  double max = numbers[0];
  for (int i = 0; i < numbers.Length; i++)
  {
    Console.Write(numbers[i] + " ");
    if (min > numbers[i]) min = numbers[i];
    if (max < numbers[i]) max = numbers[i];
  }
  Console.WriteLine();
  Console.WriteLine($"Минимальное число массива -> {min}");
  Console.WriteLine($"Максимальное число массива -> {max}");
  Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);

double[] numbers = new double[size];
mass(numbers);
PrintArray(numbers);
