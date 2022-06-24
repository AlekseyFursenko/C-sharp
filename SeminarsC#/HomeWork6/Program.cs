// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Clear();

int PositiveQty(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count ++;
    }
    return count;
}

int[] inputArrayManually(int size)
{
    int[] array = new int[size];
    
    for(int i=0; i < size; i++)
    {
        Console.Write($"PLease input {i+1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void printArray(int[] array, int size)
{
    for(int i=0; i < size; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

Console.Write("Please set a size of array (size 8 set as default if your input will be less or equal 0): ");
int size = Convert.ToInt32(Console.ReadLine()); 

if(size <=0)
{
    size = 8;
}

int[] myArray = inputArrayManually(size);

printArray(myArray, size);

int positiveNum = PositiveQty(myArray);

Console.WriteLine(positiveNum + " positive elements in the array.");
*/
//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
Console.Clear();

int[] arrayCopy(int[] array)
{
    int[] copyofArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++ )
    {
        copyofArray[i] = array[i];
    }
    return copyofArray;
}

void printArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

int[] myArray = {1, -2, 5, 7, 2, -6, 12};
Console.WriteLine("Present array:");
printArray(myArray);

int[] newArray = arrayCopy(myArray);
Console.WriteLine();
Console.WriteLine("Copy of the array:");
printArray(newArray);
*/