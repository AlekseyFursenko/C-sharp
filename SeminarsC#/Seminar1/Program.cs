/*
int num;

Console.Write("Input integer number: ");

num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Result is " + num * num );
*/

/*
int num1, num2;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
{
    Console.WriteLine("Yes! The first number is square of second number!");
}
else
{
    Console.WriteLine("False!!!");
}
*/

int num, current;

Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}

