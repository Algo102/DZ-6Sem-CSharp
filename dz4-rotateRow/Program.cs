//Написать программу, которая обменивает элементы первой строки и последней строки
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
int[,] array1 = new int[m,n];
for (int i = 0; i<array1.GetLength(0); i++)
{
  for (int j = 0; j<array1.GetLength(1); j++)
  {
    if (i == 0) array1[i,j] = array[array.GetLength(0)-1,j];
    else array1[i,j] = array[i,j];
    if (i == array.GetLength(0)-1) array1[i,j] = array[0,j];
  }
}

PrintArray(array1);