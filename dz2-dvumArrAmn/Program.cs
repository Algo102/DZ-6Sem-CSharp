//Задать двумерный массив следующим правилом: Aₘₙ = m+n
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
for (int i = 0; i<array.GetLength(0); i++)
{
  for (int j = 0; j<array.GetLength(1); j++)
  {
      array[i,j] = i + j;
  }
}

PrintArray(array);
