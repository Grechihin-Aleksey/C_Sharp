Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int count = -a;
Console.Write(count);
while(a!=count) {
  if (a>0) count++;
  else count--;
  Console.Write(count);
}



