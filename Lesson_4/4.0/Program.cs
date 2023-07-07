int function (int num)
{
  int sum = 0;
  for (int i = 1;  i <= num; i++)
    sum += i;

    return sum;
}

Console.WriteLine("Введите число N: ");
Console.WriteLine(function(int.Parse(Console.ReadLine()!)));
