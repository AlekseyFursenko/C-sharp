/*
int[] ReversArr(int[] array)
{
    int temp;
    int j = array.Length - 1;
    for(int i = 0; i < array.Length / 2; i++, j--)
    {
        temp  = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    return array;
}

int[] myArray = {1, 2, 5, 2};

myArray = ReversArr(myArray);
*/
void PrintArray(int array) 

for(int i = 0; i < myArray.Length; i++ )
{
    Console.Write(myArray[i] + " ");
}

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.


// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

//Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string BinaryNum(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = num % 2 + result;// только в этом порядке сложения
        num /= 2
    }
    return result;
}