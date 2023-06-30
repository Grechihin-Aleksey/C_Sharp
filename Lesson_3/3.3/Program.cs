// 3. Напишите программу, которая принимает на вход число (N) 
//    и выдаёт таблицу квадратов чисел от 1 до N.
int a = int.Parse(Console.ReadLine()!);
int count = 1;
if (a == 0)
{
  Console.WriteLine("1");
}
else
{
  while (count <= Math.Abs(a))
  {
    Console.WriteLine(Math.Pow(count, 2));
    count++;
  }
}

// Console.WriteLine("Введите число произведений в степень");
// int N = int.Parse(Console.ReadLine()!);
// int I = 1;
// double result = 1;

// if (N == 0)
//   Console.WriteLine("значение равно 1");
//   else do
//     {
//         result = Math.Pow(I, 2);
//         Console.WriteLine("Значения = " + result);
//         I=I+1;
//     }
//     while (I <= N);
