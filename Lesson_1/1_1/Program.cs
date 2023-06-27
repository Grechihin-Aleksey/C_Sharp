Console.WriteLine("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine()!);

if(num_1 / num_2 == num_2){
  Console.WriteLine("Второе число является квадратом превого");
}else {
  Console.WriteLine("Второе число не является квадратом первого");
}
