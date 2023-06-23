Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int count = 1;


while(count<=a) {
  if (count % 2 == 0) Console.WriteLine(count);
  count++;
}

