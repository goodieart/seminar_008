using Lib;
using static System.Console;

WriteLine("m1:");
int[,] m1 = Arrays.Create2DArrayInt32(2, 2, 1, 4);
Arrays.PrintArray(m1);
WriteLine($"\nm2:");
int[,] m2 = Arrays.Create2DArrayInt32(2, 2, 1, 4);
Arrays.PrintArray(m2);
WriteLine($"\nРезультат:");
int[,] result = Arrays.Array2DMultiplicate(m1, m2);

if (result != null)
{
    Arrays.PrintArray(result);
}
else
{
    WriteLine($"Невозможно вычислить произведение заданных матриц");
}