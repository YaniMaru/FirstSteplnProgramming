/*---------------------------------------------------------------------------------
 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
 натуральную степень B.  2, 4 -> 16
----------------------------------------------------------------------------------*/

int numberA;
int numberB;
int result;
// Method for reading data from the console
void Read()
{
    Console.Write("Введите первое число: ");
    numberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    numberB = Convert.ToInt32(Console.ReadLine());
}
// Methods for raising the number A to a natural power of the number B.
void Calculate()
{
    result = (int)Math.Pow(numberA, numberB);

}

void Calculate2()
{
    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result = (result * numberA);
    }
    
}
//Print method
void Print()
{
    Console.WriteLine("Ответ: " + result);
}

Read();
Calculate();
Print();
Calculate2();
Print();



