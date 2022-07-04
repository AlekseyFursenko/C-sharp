// Замена элементов между указанными строками

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

int[,] ChsngeLines(int[,] array, int strIndex1, int strIndex2)
{
    int temp;

    for(int j = 0; j < array.GetLength(1); j++)
    {
        temp = array [strIndex1,j];
        array[strIndex1, j] = array[strIndex2, j];
        array[strIndex2, j] = temp;
    }

    return array;
}

int[,] ChangeRowsToCol(int[,] array, int size)
{
    int temp;

    for(int i=0; i < size; i++)
    {
        for(int j = i+1; j < size; j++)
        {
            temp = array[i,j];
            array[i,j] = array [j,i];
            array[j,i] = temp;
        }
    }
    return array;
}

int[,] myArray = CreateIntRandomTwoDimArray (5, 5, 1, 9);

PrintArrayInt(myArray);

// задача начала урока myArray = ChsngeLines(myArray, 0, myArray.GetLength(0)-1);

Console.WriteLine();

myArray = ChangeRowsToCol(myArray, 5);

PrintArrayInt(myArray);

