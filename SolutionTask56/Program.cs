/*---------------------------------------------------------------------------------
Задача №56
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов
---------------------------------------------------------------------------------*/
Console.Clear();
int countRow = 4;
int countColumn = 4;
int indexStr = int.MaxValue;
int[,] buferArray = FillTwoDimArray(countRow, countColumn);
PrintTwoDimArray(buferArray);

FindRow(buferArray);
Console.WriteLine($"Cтрока с наименьшей суммой элементов: {indexStr}");
PrintArray(FillArrayStr(buferArray));

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    int[,] matrix = new int[countRow, countColumn];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new System.Random().Next(0, 100);
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

//Метод нахождения строки с min суммой эл-ов.
int FindRow(int[,] matrix)
{
    int min = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }

        if (sum < min)
        {
            min = sum;
            indexStr = i;
        }
    }
    return indexStr;
}

//метод заполнения одномерного массива значениями из строки матрицы 
int[] FillArrayStr(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[j] = matrix[indexStr, j];
        }
    }
    return array;
}

//печать одномерного массива
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(" ", array)}]");
}
