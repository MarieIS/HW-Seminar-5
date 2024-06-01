// See https://aka.ms/new-console-template for more information
int GetSum(int[] array)
{
   int sum = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (i % 2 == 1)
      {
         sum += array[i];
      } 
   }
   return sum;
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

int[] array = GetRandomArray(7, 100, 999);
Console.WriteLine("[" + string.Join(",", array) + "]");
Console.WriteLine($"сумма элементов, стоящих на нечетных позициях: {GetSum(array)}");
