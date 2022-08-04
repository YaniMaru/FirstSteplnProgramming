/*---------------------------------------------------------------------------------
 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
 натуральную степень B.  2, 4 -> 16
----------------------------------------------------------------------------------*/

int numberA;
int numberB;
// Method for reading data from the console
void Read()
{
    Console.Write("Введите первое число: ");
    numberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    numberB = Convert.ToInt32(Console.ReadLine());
}
// Methods for raising the number A to a natural power of the number B.
int Calculate(int numberA, int numberB)
{
    return (int)Math.Pow(numberA, numberB);
}

int Calculate2(int numberA, int numberB)
{
    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result = (result * numberA);
    }
    return result;
}
//Print method
void Print(int calculate, int calculate2)
{
    Console.WriteLine($"Ответ (через Math.Pow): {calculate}");
    Console.WriteLine($"Ответ (через цикл for): {calculate2}");
}

Read();
Print(Calculate( numberA, numberB), Calculate2( numberA, numberB));