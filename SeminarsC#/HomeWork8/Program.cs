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

int[,] AscendingRows(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int minJ = 0; minJ < array.GetLength(1) - 1; minJ++)
        {
               
            for(int j = minJ + 1; j < array.GetLength(1); j++)
            {
                int minimum = array[i, minJ];

                if(minimum > array[i, j])
                {
                array[i, minJ] = array[i, j];
                array[i, j] = minimum;
                }
            }
        }    
    }

    return array;
}

int SummOfRow(int[,] array, int row)
{
    int sum = array[row, 0];
                
        for(int j = 1; j < array.GetLength(1); j++)
        {
            sum = sum + array[row, j];
        }

    return sum;
}

int RowMinSumm(int[,] array)
{
    int minSumm = SummOfRow(array, 0);
    int RowOfMinSum = 1;
    
    for(int i = 1; i < array.GetLength(0); i++)
    {
        int sum = SummOfRow(array, i);
                
        if(minSumm > sum)
        {
            minSumm = sum;
            RowOfMinSum = i + 1;
        }
    }

    return RowOfMinSum;
}

int[,] SpiralMatrix(int[,] array, int min)
{   
    int turn;
    int count = min;

    if(array.GetLength(0) > array.GetLength(1)) turn = array.GetLength(1) / 2;
    else turn = array.GetLength(0) / 2;
    
    for(int n = 0; n < turn; n++)
    {
        for(int j = n; j < array.GetLength(1) - n; j++)
        {
            array[n, j] = count;
            count++;
        }

        for(int i = n + 1; i < array.GetLength(0) - n; i++)
        {
            array[i, array.GetLength(1) - 1 - n] = count;
            count++;
        }

        for(int j = array.GetLength(1) - 2 - n; j >= n; j--)
        {
            array[array.GetLength(0) - 1 - n, j] = count;
            count++;
        }

        for(int i = array.GetLength(0) - 2 - n; i > n; i--)
        {
            array[i, n] = count;
            count++;
        }
    }

    return array;
}    



// Задайте двумерный массив. Напишите программу, которая
// упорядочит по возрастанию элементы каждой строки двумерного массива.

/*
int row = 4;
int column = 4;
int minNum = 1;
int maxNum = 9;

int [,] myArray = CreateIntRandomTwoDimArray(row, column, minNum, maxNum);

PrintArrayInt(myArray);

myArray = AscendingRows(myArray);

Console.WriteLine();

PrintArrayInt(myArray);
*/

//Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.

/*
int row = 4;
int column = 4;
int minNum = 1;
int maxNum = 9;

int [,] myArray = CreateIntRandomTwoDimArray(row, column, minNum, maxNum);

PrintArrayInt(myArray);

Console.WriteLine("Number of row with minimum sum of elements is " + RowMinSumm(myArray));
*/

//Заполните спирально массив 4 на 4
// *(Работает только с чётным колличеством строк и столбцов)


int row = 4; // только чётное число!!!
int column = 4; // только чётное число!!!
int[,] myMatrix = new int[row, column];
int min = 1; // Минмальное с которого начинается заполнение массива

myMatrix = SpiralMatrix(myMatrix, min);

PrintArrayInt(myMatrix);
