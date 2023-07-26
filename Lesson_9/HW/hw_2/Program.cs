// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Write("Введите первое число диапазона ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите последнее число диапазона ");
int N = int.Parse(Console.ReadLine()!);

int Sum(int M, int N)
{
  if (M == 0) return (N * (N + 1)) / 2;            
  else if (N == 0) return (M * (M + 1)) / 2;       
  else if (M == N) return M;                      
  else if (M < N) return N + Sum(M, N - 1); 
  else return N + Sum(M, N + 1);            
}
Console.ReadLine();
Console.WriteLine($"Сумма диапазона чисел от {M} до {N} --> {Sum(M, N)}");
