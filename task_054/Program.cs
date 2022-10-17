using Lib;
using static System.Console;

int[,] matrix = Arrays.Create2DArrayInt32(3, 4, 0, 9);
Arrays.PrintArray(matrix);
Arrays.BubbleSort(matrix);
WriteLine();
Arrays.PrintArray(matrix);