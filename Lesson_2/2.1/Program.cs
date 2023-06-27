int maxNum = 0;

int Max (int num)
{
  Console.WriteLine(num);
  int num1 = num / 10;
  int num2 = num % 10;
  
  if(num1 > num2) {
    maxNum = num1;
  }
  else if(num1 == num2) {
    maxNum = num1;
  }else{
    maxNum = num2;
  }

return maxNum;
}



int thNum = new Random().Next(10, 100);
int resultMax = Max(thNum);
Console.WriteLine(resultMax);
