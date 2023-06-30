Console.WriteLine("Введите число дня недели");
int a = int.Parse(Console.ReadLine()!);

if (a > 0 && a < 6) {
  Console.WriteLine("Это будний день недели");
}else if (a == 6) {
  Console.WriteLine("Это суббота - выходной");
}else if (a == 7) {
  Console.WriteLine("Это воскресенье - выходной");
}else {Console.WriteLine("Такого дня недели не существует!");}

