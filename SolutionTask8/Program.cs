//Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
string? inputLkOne = Console.ReadLine();

if(inputLkOne != null)
{
int inputNumber = int.Parse(inputLkOne);

 
//         for(int x = 2; x <= inputNumber; x++)       
//         if (x % 2==0)             
     
//     Console.Write($"{x}, " );

    string line = "";
    int x = 2;
    
    if (inputNumber > 1)
    {
        while (x < inputNumber)
        {
            line = line + x + ", ";
            x = x + 2;
        }
        if (inputNumber % 2 == 0)
        {
            line = line + inputNumber;
        }
        
        Console.WriteLine(line);

    }
}

