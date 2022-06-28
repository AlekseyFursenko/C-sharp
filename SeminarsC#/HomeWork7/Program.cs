Console.Clear();

int[,] CreateIntRandomTwoDimArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b];

    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
           newMatrix[i,j] = new Random().Next(min, max + 1);
        }
    }
    return newMatrix;
}

double[,] CreateRandomTwoDimArray(int a, int b, int min, int max)
{
    double[,] newMatrix = new double[a,b];

    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
           int temp = new Random().Next(min, max + 1);
           newMatrix[i,j] = new Random().NextDouble() * temp;
        }
    }
    return newMatrix;
}

void PrintArray(double[,] array, int round)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i,j], round) + " ");
        }

        Console.WriteLine();
    }
}

void PrintArrayInt(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }

        Console.WriteLine();
    }
}

void CheckPosition(double[,] array, int row, int column)
{
    if(row <= array.GetLength(0) && column <= array.GetLength(1))
    {
        Console.WriteLine("Element of the array with position (" + 
                            row + ", " +
                            column + ") is " +
                            Math.Round(array[row-1, column-1], 1));
    }
    else 
    {
        Console.WriteLine("This element is out of range of the array");
    }
}

void ColumnArithmeticMean(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++ )
    {
        double sum = array[0, j];
        
        for(int i = 1; i < array.GetLength(0); i++)
        {
            sum +=array[i, j];
        }
        
        double arithmeticMean = sum / array.GetLength(0);
        
        Console.WriteLine("Arithmetic mean of " +
                         (j + 1) + " column is: " + 
                         arithmeticMean);

    }
}

// Задача 1 и 2 объеденены в одну программу

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
int m = 3; // row quantity
int n = 4; // column quantity
int maxNum = 9; // maximum number in array
int minNum = -9; // minimum number in array 
double[,] myArray = CreateRandomTwoDimArray(m, n, minNum, maxNum);

int round = 1; // quantity numbers after decimal after round
PrintArray(myArray, round);

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Input row position: ");
int rowPosition = Convert.ToInt32(Console.ReadLine());

Console.Write("Input column position: ");
int columnPosition = Convert.ToInt32(Console.ReadLine());

CheckPosition(myArray, rowPosition, columnPosition);
*/


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int m = 3; // row quantity
int n = 4; // column quantity
int maxNum = 9; // maximum number in array
int minNum = 0; // minimum number in array 

int[,] myArray = CreateIntRandomTwoDimArray(m,n,minNum,maxNum);

PrintArrayInt(myArray);

ColumnArithmeticMean(myArray);
*/