//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i =0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
} 
/*
int counterEvenNumbers (int[] array)
{
    int count = 0;

    for (int i=0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count ++;
    }
    return count;
}

int size = 10;
int minNum = 100;
int maxNum = 999;
int[] myArray = CreateRandomArray(size, minNum, maxNum);
int evenCount = counterEvenNumbers(myArray);

Console.WriteLine($"Even numbers quantity in the array is: {evenCount}");
*/

//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int sumOddPositions(int[] array)
{
    int sumOdd  = array [0];
    for(int i=2; i < array.Length; i+=2)
    {
        sumOdd += array[i];
    }
    return sumOdd;
}

int size = 4;
int minNum = -100;
int maxNum = 100;
int[] myArray = CreateRandomArray(size, minNum, maxNum);
int sumOdd = sumOddPositions(myArray);

Console.WriteLine($"Sum of elements on odd positions of the array is: {sumOdd}");
*/

// Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CrtDblRandomArray(int size, int min, int max)
{
    double[] newArray = new double[size];
    for(int i =0; i < size; i++)
    {
        int temp = new Random().Next(min,max); // временная переменная для создания случайного вещественного числа в заданных пределах
        newArray[i] = new Random().NextDouble() * temp;
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
} 

double arrayMax(double[] array)
{
    double Max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(Max < array[i]) Max = array[i];
    }
    return Max;
}

double arrayMin(double[] array)
{
    double Min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(Min > array[i]) Min = array[i];
    }
    return Min;
}

int size = 8;
int minNum = -100;
int maxNum = 100;
double[] myArray = CrtDblRandomArray(size, minNum, maxNum);
double maxElmnt = arrayMax(myArray);
double minElmnt = arrayMin(myArray);
double diffMaxMin = maxElmnt - minElmnt;

Console.WriteLine($"Defference between maximum and minimum elements of the array is: {diffMaxMin}");
*/