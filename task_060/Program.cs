using Lib;
using static System.Console;

Write("Укажите размер массива x,y,z: ");
int[] arg = Parser.GetUserInput(",");

int [,,] cube = Arrays.Create3DArrayInt32(arg[0], arg[1], arg[2], 10, 99, true);

if (cube != null) Arrays.Print3DArray(cube);
else WriteLine("Невозможно заполнить неповторяющимися двузначными числами массив указанного размера");