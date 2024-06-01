// See https://aka.ms/new-console-template for more information
int GetSubtraction(int[] array)
{
   int min = array[0];
   int max = array[0];
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] <= min)
      {
        min = array[i];
      }
      if (array[i] >= max)
      {
        max = array[i];
      }  
   }
   return max-min;
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

int[] array = GetRandomArray(7, 0, 100);
Console.WriteLine("[" + string.Join(",", array) + "]");
Console.WriteLine($"разница между максимальным и минимальным элементами: {GetSubtraction(array)}");
