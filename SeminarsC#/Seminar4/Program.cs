/*
int SumOfDigits(int num)
{
    int sum = 0;

    while(num > 0)
    {
        sum = sum + num % 10; // sum += num % 10;
        num = num / 10;       // num /= 10;
    }

    return sum;
}

Console.WriteLine(SumOfDigits(12345));
*/

int size = 9;
int[] array = new int[size];

for(int i = 0; i < size; i++)
{
    array [i] = new Random().Next(0,2);
    Console.Write(array[i] + "  ");
}
