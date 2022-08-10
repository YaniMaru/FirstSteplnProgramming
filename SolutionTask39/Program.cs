/*Задача №39
Напишите программу, которая перевернёт одномерный массив (последний элемент будет на
первом месте, а первый - на последнем и т.д.)
Например: [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]*/

//Метод возвращает массив заполненый случайными числами 
int[] FillingArray(int arrayLength)
{
    int[] outArray = new int[arrayLength];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < arrayLength)
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

//метод с созданием нового массива
int[] ReversNewArray(int[] array)
{
    int length = array.Length;
    int[] newArray = new int[length];

    for(int i = 0; i< length; i++)
    {
        newArray[length-1 - i] = array[i];
        //i=0  length-1 - i = 12
        //i=1  length-1 - i = 11
    } return newArray;
}

int[] RewersSwapArray(int[] array)
{
int length = array.Length;
int buf;
for( int i = 0; i< length/2; i++)
{
//i = 0
buf = array[i];
array[i]= array[length-1 - i];
array[length-1-i] = buf;
}
return array;
}

int[] testArray= FillingArray(13);
int[] reversedArray= ReversNewArray(testArray);
PrintIntArray(testArray);
PrintIntArray(reversedArray);
PrintIntArray(RewersSwapArray(testArray));