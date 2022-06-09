/*
Console.Clear();

int FindMaxPart(int num)
{
  int dec, ed;

    if(num > 9 && num < 100)
    {
        dec = num / 10;
        ed = num % 10;

        if (dec > ed)
        {
            return dec;
        }
        else
        {
            return ed;
        }
    }
    else
    {
        return -1;
    }
}

Console.Write("Input two-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindMaxPart(a);

if(result == -1)
{
    Console.WriteLine("Not two-diggit number!");
}
else
{
    Console.WriteLine($"Biggest digit of {a} is {result}");
}
*/

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int CutNumber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine($"Current number is {num}");

    int sot = num / 100;
    int ed = num % 10;

    int result = sot * 10 + ed;

    return result;
}
Console.WriteLine(CutNumber());
*/

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
/*
string IsAliquot(int num1, int num2)
{
    if(num2 % num1 == 0) return "True";
    else return ("False, rest is " + num2 % num1);
}
*/

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

bool IsAliquot2(int num)
{
    if(num % 23*7 == 0 ) return true;
    else return false;

    // return (num % 23 == 0 && num % 7 == 0); короткое написание того же метода
}

if(IsAliquot2(161)) Console.WriteLine("Число кратно");
else Console.WriteLine("Число не кратно");
