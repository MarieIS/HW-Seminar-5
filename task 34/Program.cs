// See https://aka.ms/new-console-template for more information

int CountEvenNumbers(int[] array)
{
   int counter = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] % 2 == 0)
      {
         counter++;
      } 
   }
   return counter;
}

int[] GetRandomArray(int size, int start, int end) 
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(start, end+1);
  }
  return array;  
}

int[] array = GetRandomArray(20, 100, 999);
Console.WriteLine("[" + string.Join(",", array) + "]");
Console.WriteLine($"количество четных чисел в массиве равно: {CountEvenNumbers(array)}");