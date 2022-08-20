/*---------------------------------------------------------------------------------
Задача №62
Заполните спирально массив 4 на 4.
---------------------------------------------------------------------------------*/
Console.Clear();
int countRow = SizeMatrix("Введите кол-во строк и столбцов квадратной матрицы: ");
int countColumn = countRow;
Console.WriteLine($"Матрица размером {countRow}х{countColumn} заполненная по спирали: ");
PrintMatrix(FillSpiralArray(countRow, countColumn));
//задаем размер матрицы
int SizeMatrix(string line)
{
    Console.WriteLine(line);
    int buf = int.Parse(Console.ReadLine() ?? "");
    return buf;
}
//заполнение матрицы по спирали
int[,] FillSpiralArray(int countRow, int countColumn)
{
    int[,] spiralMatrix = new int[countRow, countColumn];
    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
    {
        spiralMatrix[i, j] = num;

        num++;

        if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return spiralMatrix;
}
//печать матрицы
void PrintMatrix(int[,] matrix)
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


