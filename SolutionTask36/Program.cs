/* ---------------------------------------------------------------------------------
Задайте одномерный массив, заполненный случайными числами. Найдите сумму
элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19                 [-4, -6, 89, 6] -> 0
* Найдите все пары в массиве и выведите пользователю
---------------------------------------------------------------------------------*/
//Метод возвращает массив заполненый случайными числами от -99 до 99
int[] FillingArrey(int length)
{
    int[] array = new int[length];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < length)
    {
        array[i] = numberSintezator.Next(-99, 100);
        i++;
    }
    return array;
}
//Метод печатает массив
void PrintIntArray(int[] array)
{
    int i = 0;
    Console.Write("[");
    while (i < array.Length - 1)
    {
        Console.Write(array[i] + ", ");
        i++;
    }

    Console.Write(array[i]);
    Console.WriteLine("]");
}
// Метод подсчета суммы элементов, стоящих на нечётных позициях.
int SumOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int length = 15;
int[] bufferArrey = FillingArrey(length);
PrintIntArray(bufferArrey);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {SumOddPositions(bufferArrey)}.");


