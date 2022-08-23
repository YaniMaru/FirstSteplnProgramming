/*---------------------------------------------------------------------------------
Задача 68:
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два
неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
------------------------------------------------------------------------------------*/

Console.Clear();
uint numberM = ReadData("Задайте положительное число M");
uint numberN = ReadData("Задайте положительное число N");
Console.WriteLine(AckermanFunction(numberN, numberM));
//метод считывания данных
uint ReadData(string line)
{
    Console.WriteLine(line);
    return uint.Parse(Console.ReadLine() ?? "");
}

// функция Аккермана
uint AckermanFunction(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return AckermanFunction(n - 1, 1);
    else
        return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}