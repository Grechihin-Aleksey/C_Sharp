// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

string function(int item)
{
  if (item >= 10000 && item <= 99999)
  {
    if (item / 10000 == item % 10 &&
        item / 1000 % 10 == item / 10 % 10) return "Число полиндром";

    return "Число не полиндром";
  }
  else
  {
    return "Число должно быть пятизначным: ";
  }
}

Console.WriteLine("Введите пятизначное число: ");
Console.WriteLine(function(int.Parse(Console.ReadLine()!)));

