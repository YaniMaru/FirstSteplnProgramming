/*---------------------------------------------------------------------------------
Задача №58
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
---------------------------------------------------------------------------------*/
Console.Clear();
int countRow;
int countColumn;

MatrixSize(msg: "Введите размер первой матрицы.");
int[,] firstMartrix = FillTwoDimArray(countRow, countColumn);
PrintTwoDimArray(firstMartrix);

MatrixSize(msg: "Введите размер второй матрицы.");
int[,] secondMartrix = FillTwoDimArray(countRow, countColumn);
PrintTwoDimArray(secondMartrix);
Result();


//метод задает размер матрицы
void MatrixSize(string msg)
{
    Console.WriteLine(msg);
    Console.Write("Кол-во строк: ");
    countRow = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Кол-во столбцов: ");
    countColumn = int.Parse(Console.ReadLine() ?? "");
}
// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    int[,] matrix = new int[countRow, countColumn];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new System.Random().Next(0, 10);
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
//метод перемножения матриц
int[,] Multiplication(int[,] firstMartrix, int[,] secondMartrix)
{
    int[,] resultMatrix = new int[firstMartrix.GetLength(0), secondMartrix.GetLength(1)];

    for (int i = 0; i < firstMartrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMartrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMartrix.GetLength(0); k++)
            {
                resultMatrix[i, j] += firstMartrix[i, k] * secondMartrix[k, j];
            }
        }
    }

    return resultMatrix;
}
//вывод результата
void Result()
{
    if ((firstMartrix.GetLength(0) == secondMartrix.GetLength(1))
        && (firstMartrix.GetLength(1) == secondMartrix.GetLength(0)))
    {
        Console.WriteLine("Произведение двух матриц: ");
        PrintTwoDimArray(Multiplication(firstMartrix, secondMartrix));
    }
    else
        Console.WriteLine("Перемножение двух матриц невозможно.");
}

