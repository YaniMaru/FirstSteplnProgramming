// Программа, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    char[] M = inputLine.ToCharArray();
    Console.WriteLine(M[2]);
}

//     int inputNumber = int.Parse(inputLine);

//     int outputNumber = inputNumber%10;

// Console.WriteLine(outputNumber);
// }   
// string? inputLkneOne = Console.ReadLine();

// if(inputLkneOne != null)
// {
//     string lastNum = inputLkneOne.Substring(2,1);
//     Console.WriteLine(lastNum);
// }
