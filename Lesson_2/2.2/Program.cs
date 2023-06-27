int num1 = int.Parse(Console.ReadLine()!); 
int num2 = int.Parse(Console.ReadLine()!);

void function (int num1, int num2)
{
  if (num1 % num2 == 0)
  {
    Console.WriteLine("Число кратное");
  }else {
    Console.WriteLine(num1 % num2);
  }
}

function (num1, num2);
// Console.WriteLine("Hello, World!");
