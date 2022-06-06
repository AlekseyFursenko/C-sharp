//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Clear();

int a, b;

Console.Write("Input first integer number - ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number - ");
b = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    Console.Write("Max = " + a + ", Min = " + b);
}
else
{
    Console.Write("Max = " + b + ", Min = " + a);
}
*/

//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Clear();

int a, b, c;

Console.Write("Input first integer number - ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number - ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third integer number - ");
c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(max < b)
{
    max = b;
}

if(max < c)
{
    max = c;
}

Console.Write("Max = " + max);
*/

//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Clear();

int a;

Console.Write("Input integer number - ");
a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0)
{
    Console.Write("Number " + a + " is even number");
}
else
{
    Console.Write("Number " + a + " is odd number");
}
*/

//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Clear();

int n;

Console.Write("Input integer number - ");
n = Convert.ToInt32(Console.ReadLine());

int count = 1;

Console.WriteLine("All even numbers from 2 to " + n + ":");

while(count <= n)
{
    if(count % 2 == 0)
    {
        Console.Write(count + ", ");
    }
    count++;
}
*/