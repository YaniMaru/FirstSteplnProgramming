/*---------------------------------------------------------------------------------
Задача №46
Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
---------------------------------------------------------------------------------*/

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)//передаем две переменные в метод
{
    System.Random numberSyntezator = new System.Random();
    //объявляем итераторы
    int i = 0; int j = 0;
    //создаем массив, который будем заполнять
    int[,] outArray = new int[countRow, countColumn];//[размеры массива(стр и столбцы)]

    while (i < countRow)//проходим по стр
    {
        j = 0;
        while (j < countColumn)//проходим по стлбц
        {
            //заполняем массив через гениратор чисел
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}

//метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray) //передаем наш массив
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        Console.Write("\n");
        i++;
    }
}
//массив цветов
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
//метод раскрашивает массив
void PrintColorTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {   //Console.ForegroundColor = ConsoleColor.Yellow;
            //устонавл цвет нашего текста. Выбираем из заполненного цветами массива
            Console.ForegroundColor = col[new System.Random().Next(0,16)]; 
            //печатаем этим цветом
            Console.Write(inputArray[i, j] + " ");
            //сбрасываем цвет до стандартного
            Console.ResetColor(); 
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }

    
}

int[,] twoDimArray = FillTwoDimArray(5, 8);
PrintTwoDimArray(twoDimArray);
PrintColorTwoDimArray(twoDimArray);