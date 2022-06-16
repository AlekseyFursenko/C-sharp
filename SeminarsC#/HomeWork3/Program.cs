//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
Console.Clear();
void Palindrm(int num)
{
    if(num / 10000 == 0 ^ num / 10000 > 9)
    {
        Console.WriteLine(" Your number is not 5-digit");
    }
    else
    {
        if(num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10)
        {
            Console.WriteLine("You number " + num + " is palindrome.");
        }
        else
        {
            Console.WriteLine("You number " + num + " is NOT palindrome.");
        }
    }
}
Console.Write("Please, input a 5-digit number: ");
int num1  = Convert.ToInt32(Console.ReadLine());

Palindrm(num1);
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
Console.Clear();

double Dist(double xA, double yA, double zA, double xB, double yB, double zB)
{
    return (Math.Sqrt((xB-xA)*(xB-xA) + (yB-yA)*(yB-yA) + (zB-zA)*(zB-zA)));
}

Console.Write("Please, input xA: ");
double xA  = Convert.ToDouble(Console.ReadLine());

Console.Write("Please, input yA: ");
double yA  = Convert.ToDouble(Console.ReadLine());

Console.Write("Please, input zA: ");
double zA  = Convert.ToDouble(Console.ReadLine());

Console.Write("Please, input xB: ");
double xB  = Convert.ToDouble(Console.ReadLine());

Console.Write("Please, input yB: ");
double yB  = Convert.ToDouble(Console.ReadLine());

Console.Write("Please, input zB: ");
double zB  = Convert.ToDouble(Console.ReadLine());

double S = Dist(xA,yA,zA,xB,yB,zB);
Console.WriteLine("Segment lenght is: " + S);
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
Console.Clear();

void Cube(int num)
{
    int count = 0;
    while(Math.Abs(count) < Math.Abs(num))
    {
        count = count + (num/Math.Abs(num));
        Console.Write(Math.Pow(count, 3) + "  ");
    }
}

Console.Write("Please, input any integer number: ");
int number  = Convert.ToInt32(Console.ReadLine());

Cube (number);
*/