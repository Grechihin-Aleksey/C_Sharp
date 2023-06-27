
void function (int num)
{
  if (num % 7 == 0 && num % 23 == 0){
    Console.WriteLine("Число кратно");
  }else {
    Console.WriteLine("Число не кратно");
  }
}


int numA = int.Parse(Console.ReadLine()!); 
function(numA);


