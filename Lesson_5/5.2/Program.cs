// Присутствует ли заданное число пользователем в массие

Console.WriteLine("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите диапазон старта: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите введите финиш массива: ");
int k = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число для сравнения: ");
int Num = int.Parse(Console.ReadLine()!);

int[] Array (int lenght, int start, int end)
{
  int[] mass = new int[lenght];
  for (int i = 0; i < mass.Length; i++)
  {
    mass[i] = new Random().Next(start, end);
  }
  return mass;
  Console.WriteLine($"Созданный массив -> {mass}");
}

void arrNew (int[] randomMass)
{
  for (int i = 0; i < randomMass.Length; i++) 
  Console.Write(randomMass[i] + " ");
} 

string printArray (int[] col, int Num)
{
  for (int j = 0; j < col.Length; j++) 
  {
    if (col[j] == Num) return "Yes";
  }
  return "No";
}



int[] newArray = Array (n, m, k);
Console.WriteLine(printArray (newArray, Num));
arrNew (newArray);

