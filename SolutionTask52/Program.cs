/*---------------------------------------------------------------------------------
 двумерный массив из целых чисел. Найдите среднее арифметическое
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
---------------------------------------------------------------------------------*/

int countRow = 4;
int countColumn = 3;
double[,] bufArray = FillTwoDimArray(countRow, countColumn);
PrintTwoDimArray(bufArray);
PrintResult(Count(Colculate(bufArray, countColumn), countRow));

// метод для заполнения двумерного массива
double[,] FillTwoDimArray(int countRow, int countColumn)
{
    double[,] matrix = new double[countRow, countColumn];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new System.Random().Next(0, 101);
        }
    }
    return matrix;
}
//метод печати двумерного массива
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
//метод заполнения одномерного массива значениями из столбцов матрицы 
double[] Colculate(double[,] matrix, int countColumn)
{
    double[] array = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[j] += matrix[i, j];
        }
    }
    return array;
}
//вычисление среднего арифметического 
double[] Count(double[] array, int countRow)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(array[i] / countRow, 1);
    }
    return array;
}
//метод печати результата
void PrintResult(double[] array)
{
    int i = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    while (i < array.Length - 1)
    {
        Console.Write(array[i] + "; ");
        i++;
    }

    Console.Write(array[i] + ".");
}




