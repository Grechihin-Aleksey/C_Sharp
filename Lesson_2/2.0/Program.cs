int TakeNum(int num)
{
  Console.WriteLine(num);
  return num % 10;
}

int thNum = new Random().Next(100, 1000);
int resalt = TakeNum(thNum);
Console.WriteLine(resalt);