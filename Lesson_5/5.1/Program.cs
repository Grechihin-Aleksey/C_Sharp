int[] Array (int lenght, int start, int end)
{
  int[] arr = new int[lenght];
  for (int i = 0; i < arr.Length; i++)
  arr[i] = new Random().Next(start, end);
  return arr;
}

void printArray (int[] mass)
{
  for (int i = 0; i < mass.Length; i++)
    Console.Write (mass [i] + " ");
  Console.WriteLine ("");
}

void PrintArr (int[] colection)
{
  for (int j = 0; j < colection.Length; j++)
  {
    colection[j] *= -1;
    Console.Write (colection [j] + " ");
  }
}

int[] col = Array (12, -9, 9);
printArray (col);
PrintArr (col);


