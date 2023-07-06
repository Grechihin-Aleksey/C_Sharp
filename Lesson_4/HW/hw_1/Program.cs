// Напишите цикл, который на входе принимает два числа А и В
// и возводит число А в степень В

Console.WriteLine("Введите число A: ");
Console.WriteLine("Введите число B: ");

void function(int A, int B)
{
  int rez = 1;
  if (B == 0) Console.WriteLine($"Число В равно нулю -> {rez}");
  else
  {
    for (int i = 1; i <= B; i++)
    {
      rez = rez * A;
    }
    Console.WriteLine($"Число А в степени В равно -> {rez}");
  }
}



function(int.Parse(Console.ReadLine()!), int.Parse(Console.ReadLine()!));
