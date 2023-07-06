int function (int num)
{
  int rez = 0;
  for (int i = 1; num != 0; i++)
  {
    num /= 10;
    rez = i;
  }
  return rez;
}

Console.WriteLine("Введите число N: ");
Console.WriteLine(function(int.Parse(Console.ReadLine()!)));
