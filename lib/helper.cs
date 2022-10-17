namespace Lib;
using static System.Console;

public class Arrays
{
    /// <summary>
    /// Метод создает двумерный массив с вещественными числами
    /// </summary>
    /// <param name = "rows">Количество строк в результирующем массиве</param>
    /// <param name = "columns">Количество столбцов в результирующем массиве</param>
    /// <param name = "minValue">Минимально возможное значение при заполнении массива</param>
    /// <param name = "maxValue">Максимально возможное значение при заполнении массива</param>
    /// <returns>Новый массив, заполненный случайными вещественными числами</returns>
    public static double[,] Create2DArrayDouble(int rows, int columns, int minValue = -100, int maxValue = 100)
    {
        double[,] result = new double[rows, columns];
        Random rnd = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = Convert.ToDouble(rnd.Next(minValue, maxValue)) + rnd.NextDouble();
            }
        }

        return result;
    }
    /// <summary>
    /// Метод создает двумерный массив с целыми числами
    /// </summary>
    /// <param name = "rows">Количество строк в результирующем массиве</param>
    /// <param name = "columns">Количество столбцов в результирующем массиве</param>
    /// <param name = "minValue">Минимально возможное значение при заполнении массива</param>
    /// <param name = "maxValue">Максимально возможное значение при заполнении массива</param>
    /// <returns>Новый массив, заполненный случайными целыми числами</returns>
    public static int[,] Create2DArrayInt32(int rows, int columns, int minValue = -100, int maxValue = 100)
    {
        int[,] result = new int[rows, columns];
        Random rnd = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = rnd.Next(minValue, maxValue + 1);
            }
        }

        return result;
    }
    /// <summary>
    /// Метод выводит на экран содержимое переданного двумерного массива с вещественными числами
    /// </summary>
    /// <param name = "inArray">Массив, содержимое которого следует вывести на экран</param>
    /// <param name = "separator">Строковый разделитель между столбцами</param>
    public static void PrintArray(double[,] inArray, string separator = "\t")
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if (inArray[i, j] >= 0) Write(" ");
                Write($"{inArray[i, j]:f1}{separator}");
            }
            WriteLine();
        }
    }
    /// <summary>
    /// Метод выводит на экран содержимое переданного двумерного массива с целыми числами
    /// </summary>
    /// <param name = "inArray">Массив, содержимое которого следует вывести на экран</param>
    /// <param name = "separator">Строковый разделитель между столбцами</param>
    public static void PrintArray(int[,] inArray, string separator = "\t")
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if (inArray[i, j] >= 0) Write(" ");
                Write($"{inArray[i, j]:00}{separator}");
            }
            WriteLine();
        }
    }
    /// <summary>
    /// Метод выводит на экран содержимое переданного одномерного массива с вещественными числами
    /// </summary>
    /// <param name = "inArray">Массив, содержимое которого следует вывести на экран</param>
    /// <param name = "separator">Строковый разделитель между столбцами</param>
    public static void PrintArray(double[] inArray, string separator = "\t")
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            if (inArray[i] >= 0) Write(" ");
            Write($"{inArray[i]:f1}{separator}");
        }
    }
    /// <summary>
    /// Метод выводит на экран содержимое переданного одномерного массива с вещественными числами
    /// </summary>
    /// <param name = "inArray">Массив, содержимое которого следует вывести на экран</param>
    /// <param name = "separator">Строковый разделитель между столбцами</param>
    public static void PrintArray(int[] inArray, string separator = "\t")
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            if (inArray[i] >= 0) Write(" ");
            Write($"{inArray[i]}{separator}");
        }
    }
    /// <summary>
    /// Метод вычисляет средние арифметические среди элементов каждого столбца исходного массива
    /// </summary>
    /// <param name = "inArray">Массив, на основании колонок которого следует вычислить средние арифметические</param>
    /// <returns>Новый массив, заполненный средними арифметическими по каждому столбцу исходного массива</returns>
    public static double[] AverageByColumns(int[,] inArray)
    {
        double[] result = new double[inArray.GetLength(1)];
        double columnSum = 0;

        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            columnSum = 0;
            for (int i = 0; i < inArray.GetLength(0); i++)
            {
                columnSum += inArray[i, j];
            }
            result[j] = columnSum / inArray.GetLength(0);
        }
        return result;
    }
    /// <summary>
    /// Метод реализует алгоритм пузырьковой сортировки внутри строк двумерного массива (по убыванию / descending)
    /// </summary>
    /// <param name = "inArray">Массив, строки которого подлежат сортировке</param>
    public static void BubbleSort(int[,] inArray)
    {
        int temp;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
                for (int k = j + 1; k < inArray.GetLength(1); k++)
                {
                    if (inArray[i, j] < inArray[i, k])
                    {
                        temp = inArray[i, j];
                        inArray[i, j] = inArray[i, k];
                        inArray[i, k] = temp;
                    }    
                }
        }
    }
    /// <summary>
    /// Метод вычисляет суммы элементов строк двумерного массива
    /// </summary>
    /// <param name = "inArray">Массив, на основании строк которого следует вычислить их суммы</param>
    /// <returns>Новый массив, заполненный суммами элементов строк</returns>
    public static int[] SumByRows(int[,] inArray)
    {
        int[] result = new int[inArray.GetLength(0)];
        int temp = 0;

        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            temp = 0;
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                temp += inArray[i, j];
            }
            result[i] = temp;
        }
        return result;
    }
    /// <summary>
    /// Метод возвращает индекс минимального элемента массива
    /// </summary>
    /// <param name = "inArray">Массив с элементами, среди которых необходимо найти минимум</param>
    /// <returns>Индекс минимального элемента массива</returns>
    public static int GetMinIdx(int[] inArray)
    {
        int min = inArray[0];
        int minIdx = 0;

        for (int i = 0; i < inArray.Length; i++)
        {
            if (inArray[i] < min)
            {
                min = inArray[i];
                minIdx = i;
            }
        }
        return minIdx;
    }
    /// <summary>
    /// Метод вычисляет результат произведения двух матриц
    /// </summary>
    /// <param name = "m1">Первый массив с элементами, представляющих матрицу</param>
    /// <param name = "m2">Второй массив с элементами, представляющих матрицу</param>
    /// <returns>Результирующая матрица (массив)</returns>
    public static int[,] Array2DMultiplicate(int[,] m1, int[,] m2)
    {
        if (m1.GetLength(1) != m2.GetLength(0)) return null!;
        int[,] result = new int[m1.GetLength(0), m2.GetLength(1)];
        for (int i = 0; i < m1.GetLength(0); i++)
        {
            for (int j = 0; j < m2.GetLength(1); j++)
            {
                for (int k = 0; k < m2.GetLength(0); k++)
                {
                    result[i, j] += m1[i, k] * m2[k, j];
                }
            }
        }
        return result;
    }
    /// <summary>
    /// Метод создает трехмерный массив с целыми числами
    /// </summary>
    /// <param name = "rows">Количество строк в результирующем массиве</param>
    /// <param name = "columns">Количество столбцов в результирующем массиве</param>
    /// <param name = "height">Количество "слоев" в результирующем массиве</param>
    /// <param name = "minValue">Минимально возможное значение при заполнении массива</param>
    /// <param name = "maxValue">Максимально возможное значение при заполнении массива</param>
    /// <param name = "shuffleMethod">Если true, тогда массив заполняется неповторяющимися числами</param>
    /// <returns>Новый массив, заполненный случайными целыми числами</returns>
    public static int[,,] Create3DArrayInt32(int rows,
                                             int columns,
                                             int height, 
                                             int minValue = -100, 
                                             int maxValue = 100, 
                                             bool shuffleMethod = false
                                             )
    {
        int[,,] result = new int[rows, columns, height];

        if (shuffleMethod)
        {
            if (rows * columns * height <= maxValue - minValue)
            {
                int it = minValue;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        for (int z = 0; z < height; z++)
                        {
                            it += 1;
                            result[i, j, z] = it;
                        }
                    }
                }
            }
            else return null!;
        }
        else
        {
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int z = 0; z < height; z++)
                    {
                        result[i, j, z] = rnd.Next(minValue, maxValue + 1);
                    }
                }
            }
        }

        return result;
    }
    /// <summary>
    /// Метод выводит на экран содержимое переданного трехмерного массива с целыми числами
    /// </summary>
    /// <param name = "inArray">Массив, содержимое которого следует вывести на экран</param>
    /// <param name = "separator">Строковый разделитель между столбцами</param>
    public static void Print3DArray(int[,,] inArray, string separator = "\t")
    {
        for (int z = 0; z < inArray.GetLength(2); z++)
        {
            for (int i = 0; i < inArray.GetLength(0); i++)
            {
                for (int j = 0; j < inArray.GetLength(1); j++)
                {
                    if (inArray[i, j, z] >= 0) Write(" ");
                    Write($"{inArray[i, j, z]}({i},{j},{z}){separator}");
                }
                WriteLine();
            }
        }
    }
}

public class Parser
{
    /// <summary>
    /// Метод возвращает ввод пользователя, преобразованный в целочисленный массив
    /// </summary>
    /// <param name = "separator">Строковый разделитель; символы между ними в исходной строке будут
    /// преобразованы в элементы результирующего массива</param>
    /// <returns>Новый массив, заполненный преобразованными строковыми значениями в целочисленный тип</returns>
    public static int[] GetUserInput(string separator = " ")
    {
        return Console.ReadLine()!.Split(separator, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(item => int.Parse(item))
                                  .ToArray();
    }
}