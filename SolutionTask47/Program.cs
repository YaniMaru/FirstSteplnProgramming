/*---------------------------------------------------------------------------------
№47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
---------------------------------------------------------------------------------*/

// метод заполнения двумерного массива вещественными числами
double[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random randomNum = new Random();

    double[,] matrix = new double[countRow, countColumn];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(randomNum.NextDouble() * 10, 4);
        }
    }


    return matrix;
}
//метод для печати двумерного  
void PrintTwoDimArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.Write("\n");

    }
}
//массив 16 цветов
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
//печать цветного массива
void PrdoubleColorTwoDimArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.Write("\n");
    }
}

int countRow = 3;
int countColumn = 4;

PrintTwoDimArray(FillTwoDimArray(countRow, countColumn));
Console.Write("\n");
PrdoubleColorTwoDimArray(FillTwoDimArray(countRow, countColumn));








