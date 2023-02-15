//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.Clear();

void CreateArrayRND(int[,] arr, int low, int hi)
{
  Random random = new Random();
  for (int i = 0; i<arr.GetLength(0); i++)
    for (int j = 0; j<arr.GetLength(1); j++)
      arr[i,j] = random.Next(low, hi);
}

void PrintArray(int[,] arr)
{
  for (int i = 0; i<arr.GetLength(0); i++)
  {
    for (int j = 0; j<arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
  }
}

int IntRead(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int m = IntRead("Введите количество строк в массиве");
int n = IntRead("Введите количество столбцов в массиве");
int[,] array = new int[m,n];
CreateArrayRND(array,0, 10);
PrintArray(array);

Console.WriteLine();

for (int i = 1; i<array.GetLength(0); i++)
{
  for (int j = 1; j<array.GetLength(1); j++)
  {
    if (i % 2 == 0 & j % 2 == 0) array[i,j] = array[i,j] * array[i,j];      
  }
}

PrintArray(array);
