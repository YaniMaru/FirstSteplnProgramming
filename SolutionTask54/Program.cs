/*---------------------------------------------------------------------------------
Задача №54
 Задайте двумерный массив. Напишите программу, которая упорядочит по 
 убыванию элементы каждой строки двумерного массива.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
---------------------------------------------------------------------------------*/
Console.Clear();
int countRow = 4;
int countColumn = 4;
int[,] buferArray = FillTwoDimArray(countRow, countColumn);
PrintTwoDimArray(buferArray);
Console.WriteLine("Массив после сортировки: ");
PrintTwoDimArray(SortMatrix(buferArray));

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    int[,] matrix = new int[countRow, countColumn];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new System.Random().Next(0, 101);
        }
    }
    return matrix;
}

//метод  печати двумерного массива
void PrintTwoDimArray(int[,] matrix)
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

//Метод, сортирующий массив чисел каждой строки(по убыванию)
int[,] SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }

    }
    return matrix;
}

