// Создать массив случайных чисел длиной N

// void function()
// {
//   Console.WriteLine("Введите длину массива N: ");
//   int[] Array = new int[int.Parse(Console.ReadLine()!)];

//   Console.WriteLine("Введите диапазон массива, старт: ");
//   int n = int.Parse(Console.ReadLine()!);

//   Console.WriteLine("Введите диапазон массива, конец: ");
//   int m = int.Parse(Console.ReadLine()!);

//   for (int i = 0; i < Array.Length; i++)
//   {
//     Array[i] = new Random().Next(n, m);
//     Console.Write(Array[i] + " ");
//   }
// }

// function();

// 


int[] Array(int array1, int a, int b)
{
  int[] arr = new int[array1];
  for (int index = 0; index < array1; index++)
    arr[index] = new Random().Next(a, b + 1);
  return arr;
}

void PrintArray(int[] col)
{
  for (int i = 0; i < col.Length; i++)
    Console.Write(col[i] + " ");
}

Console.WriteLine("Введите длину массива N: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите диапазон массива, старт: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите диапазон массива, конец: ");
int m = int.Parse(Console.ReadLine()!);

int[] mass = Array(num, n, m);
PrintArray(mass);



//Сортировка массива
// int[] array = {5, 6, 7, 8, 1, 2 , 5};

// void PrintArray (int[] array)
// {
//   int length = array.Length;
//   for (int i = 0; i < length; i++)
//   {
//     Console.Write (array [i] + " ");
//   }  
//   Console.WriteLine ();
// }



// void SelectionSort (int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     int minPosition = i;
//     for (int j = i + 1; j < array.Length; j++)
//     {
//       if (array [j] < array[ minPosition]) minPosition = j;
//     }
//     int tempArray = array[i];
//     array[i] = array [minPosition];
//     array [minPosition] = tempArray;
//       Console.Write (array [i] + " ");
//   }
// }

// PrintArray (array);
// SelectionSort (array);
