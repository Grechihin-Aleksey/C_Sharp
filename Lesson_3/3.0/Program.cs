﻿void Quarters (int x, int y)
{
  if (x == 0  || y == 0)
    Console.WriteLine ("x == 0  or y == 0");
  else if (x > 0 || y > 1)
    Console.WriteLine ("I");
  else if (x < 0 || y > 1)
    Console.WriteLine ("II");
  else if (x < 0 || y < 1)
    Console.WriteLine ("III");
  else if (x > 0 || y < 1)
    Console.WriteLine ("IV");
}

int num1 = int.Parse (Console.ReadLine ()!);
int num2 = int.Parse (Console.ReadLine ()!);

Quarters (num1, num2);
