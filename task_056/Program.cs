using Lib;
using static System.Console;

int[,] matrix = Arrays.Create2DArrayInt32(4, 4, 0, 9);
int[] rowSum = Arrays.SumByRows(matrix);
Arrays.PrintArray(matrix);

WriteLine($"Строка с наименьшей суммой элементов = {Arrays.GetMinIdx(rowSum) + 1}");