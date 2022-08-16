/*---------------------------------------------------------------------------------
№50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.
---------------------------------------------------------------------------------*/
int countRow = 3;
int countColumn = 4;
int[,] twoDimArray = FillTwoDimArray(countRow, countColumn);
PrintTwoDimArray(twoDimArray);
Console.WriteLine("Введите число для поиска: ");
int find = int.Parse(Console.ReadLine() ?? "");
PrintRes(SearchElemTwoDimArray(twoDimArray, find));

// метод  заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int[,] matrix = new int[countRow, countColumn];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = numberSyntezator.Next(1, 100);
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
// метод поиска заданного элемента. 
bool SearchElemTwoDimArray(int[,] matrix, int find)
{
    bool res = false;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == find)
            {
                res = true;
                break;
            }
        }
    }
    return res;

}
// метод печати результата
void PrintRes(bool res)
{
    if (res)
    {
        Console.WriteLine("Элемент найден");
    }
    else
    {
        Console.WriteLine("Элемент отсутствует");
    }
}

