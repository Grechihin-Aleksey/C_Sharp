void function (int item) {
  int itemA = ((item / 10) - (item /10) % 10) + item % 10;
  Console.WriteLine(itemA);
}


int a = new Random().Next(100, 1001);

function(a);
Console.WriteLine(a);
// Console.WriteLine(b);
