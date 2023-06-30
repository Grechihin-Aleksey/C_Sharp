Console.WriteLine("Введите любое число");
int a = int.Parse(Console.ReadLine()!);

while (a >= 1000)
{
  a = a / 10;
}

if (a > 99 && a <= 999 ) {
  if (a >=100) {
    Console.WriteLine(a % 10);
  }
}else if (a > 0 && a <= 99) {
  Console.WriteLine("Нет третьего числа");
}

// Console.WriteLine(a);
