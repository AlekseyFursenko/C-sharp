// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int RangeSum(int m, int n)
{
    int sum = m;
    if(m != n)
        sum = sum + RangeSum(m+1, n);
    return sum; 
}

Console.Write("Input M value  - ");
int startRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N value, must be greater than M - ");
int endRange = Convert.ToInt32(Console.ReadLine());

if(startRange < endRange) Console.WriteLine("Sum of elements between M to N is - " + RangeSum(startRange, endRange));
else Console.WriteLine("Your input is wrong");
*/

// Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.
/*
int RegistersQty(int n)
{
    int qty = 1;

    if(n/10 != 0)
    {
        qty = qty + RegistersQty(n/10);
    }
    
    return qty;
        
}

Console.Write("Input a number - ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantity of registers in the number are - " + RegistersQty(number));
*/