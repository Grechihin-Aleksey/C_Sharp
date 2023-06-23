Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

if (a == b) Console.WriteLine("Числа равны");
else if (a>b) Console.Write("max: " + a + " " + "min: " + b );
else Console.WriteLine("min: " + a + " " + "max: " + b);