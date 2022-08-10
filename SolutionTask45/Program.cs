/* Задача №45
Напишите программу, которая будет создавать копию заданного одномерного 
массива с помощью поэлементного копирования.*/

int[] FillingArray()
{
    int[] outArray = new int[12];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 12)
    {
        outArray[i] = numberSintezator.Next(-1000,1000);
        i++;
    }
    return outArray;
}

//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    //Буфферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + ", ");
        //Увеличиваем инкремент
        i++;
    }
    //Выводим элемент массива
    Console.WriteLine(inputArray[i]);
}

int[] CopyArrayStandartTool(int[] inputArray)
{
    int[] buferArray = new int [inputArray.Length];
    inputArray.CopyTo(buferArray, 0);
    return buferArray;
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
int[] resultArray = CopyArrayStandartTool(buferArray);
PrintIntArray(resultArray);