// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"m = {m}, n = {n}.");
double[,] array = new double[m, n];
CreateArrayDouble(array);
WriteArray(array);
Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}
*/






// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
Console.WriteLine("Номер строки искомого элемента: ");
int posInRow = int.Parse(Console.ReadLine()!);
Console.WriteLine("Номер столбца искомого элемента: ");
int posInColumn = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] GetMatrix(int rows, int columns, int minNumber, int maxNumber)
{
    int[,] matrix = new int[rows, columns];

    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minNumber, maxNumber);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++) //m
    {
        for (int j = 0; j < mtrx.GetLength(1); j++) //n
        {
            if (j == 0) Console.Write(" | ");
            Console.Write($"{mtrx[i, j],4} | ");
        }
        Console.WriteLine();
    }
}

int FindElementInMatrix(int[,] mtrx, int posInRow, int posInColumn)
{
    int element = 0;

    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (i == posInRow - 1 && j == posInColumn - 1) element = mtrx[i, j];
        }
    }
    return element;
}

int[,] array = GetMatrix(4, 3, 0, 100);
PrintMatrix(array);
Console.WriteLine();

if (FindElementInMatrix(array, posInRow, posInColumn) > 0)
{
    Console.WriteLine("Значение выбранного элемента: " + FindElementInMatrix(array, posInRow, posInColumn));
}
else
{
    Console.WriteLine("Такого элемента в этом массиве нет!");
}
*/



// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int[,] GetMatrix(int rows, int columns, int minNumber, int maxNumber)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minNumber, maxNumber);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++) //m
    {
        for (int j = 0; j < mtrx.GetLength(1); j++) //n
        {
            if (j == 0) Console.Write(" | ");
            Console.Write($"{mtrx[i, j], 1} | ");
        }
        Console.WriteLine();
    }
}

void AverageOfColumns(int[,] mtrx)
{
    double sum = 0;

    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            sum += mtrx[i, j];
        }

        if (j == 0) Console.WriteLine("Среднее арифметическое по столбцам:");
        Console.WriteLine($" {Math.Round(sum / mtrx.GetLength(0), 2)}");

        sum = 0;
    }
}

int[,] array = GetMatrix(3, 4, 0, 10);
PrintMatrix(array);
Console.WriteLine();
AverageOfColumns(array);