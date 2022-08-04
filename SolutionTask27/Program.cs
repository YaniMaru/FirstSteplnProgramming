/*----------------------------------------------------------------------------------
 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 452 -> 11   82 -> 10  9012 -> 12
----------------------------------------------------------------------------------*/

Console.Write("Введите : ");
string inputLine = Console.ReadLine() ?? "";
int inputNumber = int.Parse(inputLine);

//method for calculating the sum of all digits in a number
int Calculate()
{
    int sumOfDigits = 0;
    while (inputNumber > 0)
    {
        sumOfDigits = sumOfDigits + (inputNumber % 10);
        inputNumber = inputNumber / 10;

    }
    return sumOfDigits;
}

int result = Calculate();
Console.WriteLine("Сумма цифр в числе: " + result);


