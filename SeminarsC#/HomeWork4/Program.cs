// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.Clear();

int[] num = new int[2];
string[] abc = {"A", "B"};

for(int i = 0; i < 2; i++)
{
    Console.Write($"Please input {abc[i]}: ");
    num[i] = Convert.ToInt32(Console.ReadLine());
}

double result = Math.Pow(num[0], num[1]);

Console.WriteLine("A raised to the power of B is: " + result);
*/

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 3, 44, 3 -> [1, 2, 5, 7, 19, 3, 44, 3]
/*
Console.Clear();

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

int[] inputArrayRnd(int size, int a, int b)
{
    int[] array = new int[size];
    
    for(int i=0; i < size; i++)
    {
        array[i] = new Random().Next(a, b+1);
    }

    return array;
}    

void printArray(int[] array, int size)
{
    for(int i=0; i < size; i++)
    {
        Console.Write(array[i] + "  ");
    }
}

Console.Write("Please set a size of array (size 8 set as default if your input will be less or equal 0): ");
int size = Convert.ToInt32(Console.ReadLine()); 

if(size <=0)
{
    size = 8;
}

Console.WriteLine("Please choose a method to generate an array of integer:" + "\n"
                     + "1 - manually" + "\n"
                     + "2 - random");
int method = Convert.ToInt32(Console.ReadLine());

if (method == 1)
{
    int[] array = inputArrayManually(size);
    printArray(array, size);
}

if (method == 2)
{
    Console.Write("Please input minimum possible number: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input maximum possible number: ");
    int b = Convert.ToInt32(Console.ReadLine());
    
    int[] array = inputArrayRnd(size, a, b);
    printArray(array, size);
}

if(method < 1 ^ method > 2)
{
    Console.WriteLine("You input wrong method.");
}
*/
