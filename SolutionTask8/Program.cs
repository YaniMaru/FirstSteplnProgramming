//Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
string? inputLkOne = Console.ReadLine();
if (inputLkOne != null)
{
    int inputNumber = int.Parse(inputLkOne);
    string line = "";
    int x = 2;
    if (inputNumber > 1)
    {
        while (x <= inputNumber - 2)
        {
            line = line + x + ", ";
            x = x + 2;
        }
        if (x <= inputNumber)
        {
            line = line + x;
        }
        Console.WriteLine(line);
    }
}




// //Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Console.WriteLine("Введите число: ");
// string? inputLkOne = Console.ReadLine();

// if(inputLkOne != null)
// {
// int inputNumber = int.Parse(inputLkOne);

//     string line = "";
//     int x = 2;

//     if (inputNumber > 1)
//     {
//         while (x < inputNumber)
//         {
//             line = line + x + ", ";
//             x = x + 2;
//         }
//         if (inputNumber % 2 == 0)
//         {
//             line = line + inputNumber;
//         }

//         Console.WriteLine(line);

//     }
// }


