// Напишите программу, которая принимает на вход число N и выдаёт произведение 
//чисел от 1 до N. Например: 4 -> 24    5 -> 120

Console.Write("Введите число: ");
int inputNum = int.Parse(Console.ReadLine());
Console.WriteLine(sumNums(inputNum));
Console.WriteLine(mulRec(inputNum));
int sumNums(int num)
{
    int sum = 1;
    for (int i = 1; i <= inputNum; i++)
    {
        sum *= i;
    }
    return sum;
}

int mulRec(int num)
{
    if (num==1)
    {
        return 1;
    }
    else
    {
        return num*mulRec(num-1);
    }
}