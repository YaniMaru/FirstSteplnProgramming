/*---------------------------------------------------------------------------------
№41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
пользователь.
0, 7, 8, -2, -2 -> 2                           -1, -7, 567, 89, 223-> 3
---------------------------------------------------------------------------------*/
Console.Clear();
int m;
PrintResult(ColculateTask(Read()));

//метод чтения данных
int[] Read()
{
    Console.WriteLine($"Сколько всего чисел будет введено?: ");
    m = int.Parse(Console.ReadLine() ?? ""); ;
    int[] array = new int[m];
    int i = 0;
    Console.WriteLine("Введите числа. ");
    while (i < m)
    {
        Console.Write($"{i + 1} число: ");
        array[i] = int.Parse(Console.ReadLine() ?? "");
        i++;
    }
    return array;
}
//метод вычисления
int ColculateTask(int[] array)
{
    int countPosNum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
        {
            countPosNum++;
        }
    return countPosNum;
}
//метод печати
void PrintResult(int countPosNum)
{
    Console.WriteLine($"Кол-во чисел больше нуля: {countPosNum} ");
}




