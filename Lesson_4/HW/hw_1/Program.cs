// Напишите цикл, который на входе принимает два числа А и В
// и возводит число А в степень В

Console.WriteLine("Введите число A: ");
Console.WriteLine("Введите число B: ");

void function(int A, int B)
{
  double rez = 1;
  int b_abs = Math.Abs(B);


  if (B == 0) Console.WriteLine($"Число В равно нулю -> {rez}");
  else
  {
    for (int i = 1; i <= b_abs; i++)
    {
      if (A > 0) rez *= A;
      else
        rez /= A;
    }
    Console.WriteLine($"Число А в степени В равно -> {rez}");
  }
}



function(int.Parse(Console.ReadLine()!),
        int.Parse(Console.ReadLine()!));
