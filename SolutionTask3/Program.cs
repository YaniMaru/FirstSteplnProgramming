// Программа, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N До N
string? inputLkOne = Console.ReadLine();

if(inputLkOne != null)
{

    int inputNumber = int.Parse(inputLkOne);

    int startNumber = 1;

    string lineOutput = "0";

    while (startNumber <= inputNumber)
    {
        lineOutput = startNumber*(-1)+", "+lineOutput+", "+startNumber;
        startNumber++;
    }
    
    //LineOutput=LineOutput+inputNumber;

    Console.WriteLine(lineOutput);
}
