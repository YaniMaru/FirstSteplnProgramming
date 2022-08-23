/*---------------------------------------------------------------------------------
Задача 66:
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
---------------------------------------------------------------------------------*/

Console.Clear();
int numberM = ReadData("Задайте число M");
int numberN = ReadData("Задайте число N");
int sum = 0;
Result(numberM, numberN);

//метод считывания данных
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}
// метод нахождения суммы через рекурсию
void sumOfNaturalNumbers(int m, int n)
{
    if (m - 1 == n) return;
    sum += m;
    sumOfNaturalNumbers(m + 1, n);
}
//вывод результата
void Result(int m, int n)
{
    if (m < n)
    {
        sumOfNaturalNumbers(m, n);
        Console.WriteLine($"Сумма чисел от {m} до {n} равна {sum}");
    }
    else
    {
        sumOfNaturalNumbers(n, m);
        Console.WriteLine($"Сумма чисел от {n} до {m} равна {sum}");
    }

}