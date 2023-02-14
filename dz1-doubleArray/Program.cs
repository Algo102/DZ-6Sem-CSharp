void CreateArrayRND(double[,] arr, int low, int hi)
{
  Random random = new Random();
  for (int i = 0; i<arr.GetLength(0); i++)
    for (int j = 0; j<arr.GetLength(1); j++)
      arr[i,j] = random.Next(low, hi)+random.NextDouble();
}

void PrintArray(double[,] arr)
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
double[,] array = new double[m,n];
CreateArrayRND(array,1,10);
PrintArray(array);
