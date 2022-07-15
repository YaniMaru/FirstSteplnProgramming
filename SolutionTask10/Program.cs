// Программа, которая принимает на вход трёхзначное число и на выходе
//показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int a = int.Parse(inputLine);
    int b = (a % 100) / 10;

    Console.WriteLine(b);
}


// Console.WriteLine("Введите трехзначное число: ");
// string? inputLine = Console.ReadLine();
// if (inputLine != null)
// {
//     string stringNum = inputLine.ToString();
//     Console.Write(stringNum[1]);
// }

