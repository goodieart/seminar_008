using Lib;
using static System.Console;

Write("Введите ширину квадратной матрицы: ");
int width = int.Parse(ReadLine()!);

int[,] matrix = Arrays.Create2DArrayInt32(width, width, 0, 0);
for (int i = 0; i < matrix.GetLength(0); i++) matrix[0, i] = i + 1;

int n = matrix.GetLength(0);
int z = 0;
int x = n - 1, y = 0, tx = 0, ty = 1;

while (n < Math.Pow(width, 2))
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < matrix.GetLength(0) - z - 1; j++)
        {
            x += tx;
            y += ty;
            n += 1;
            matrix[y, x] = n;
        }
        if (tx == 1)
        {
            tx = 0;
            ty = 1;
        }
        else if (tx == -1)
        {
            tx = 0;
            ty = -1;
        }
        else if (ty == 1)
        {
            tx = -1;
            ty = 0;
        }
        else if (ty == -1)
        {
            tx = 1;
            ty = 0;
        }
    }
    z += 1;
}

Arrays.PrintArray(matrix, string.Empty);