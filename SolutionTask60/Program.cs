/*---------------------------------------------------------------------------------
Задача №60
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы 
каждого элемента.
---------------------------------------------------------------------------------*/
Console.Clear();
int x = 3;
int y = 3;
int z = 3;
int[,,] buf = Fill3DArray(x, y, z);
Print3DArray(buf);

//печать трёхмерного массива с выводом индексов
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.Write("\n");
        }
        Console.Write("\n");
    }
}

// метод для заполнения трехмерного массива
int[,,] Fill3DArray(int x, int y, int z)
{
    List<int> numbers = new List<int>();
    int num = 0;
    System.Random numberSynteztor = new System.Random();
    int[,,] matrix = new int[x, y, z];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                num = numberSynteztor.Next(10, 100);
                if (numbers.Contains(num))
                {
                    num = numberSynteztor.Next(10, 100);
                }
                else
                {
                    numbers.Add(num);

                }
                matrix[i, j, k] = num;
            }

        }
    }
    return matrix;
}





