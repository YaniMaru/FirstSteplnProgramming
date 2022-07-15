// Программа, которая принимает на вход два числа и выводит, является ли второе число кратным первому. 
// Если второе число некратно первому, программа выводит остаток от деления.

// 1 вариант
// string? inputLkneOne = Console.ReadLine();
// string? inputLkneTwo = Console.ReadLine();

// if(inputLkneOne != null && inputLkneTwo != null)
// {
//     int inputNumberOne = int.Parse(inputLkneOne);
//     int inputNumberTwo = int.Parse(inputLkneTwo);

//     int div = inputNumberTwo%inputNumberOne;

//     if(div == 0)
//     {
//         Console.WriteLine("yes");
//     }
//     else
//     {
//         Console.WriteLine (div);
//     }
// }

//2 вариант

Console.Write("Enter first number: ");
string? firstLine = Console.ReadLine();
Console.Write("Enter second number: ");
string? secondLine = Console.ReadLine();
int first = int.Parse(firstLine);
int second = int.Parse(secondLine);

if (second%first == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine("Некратное, " + second%first);
}