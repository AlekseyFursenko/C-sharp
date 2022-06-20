// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//метод для создания массива

int[] CreateRandomArray(int size, int min, int max){
    int[] newArray = new int[size];
    for(int i =0; i < size; i++){
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
} 

int FindPositiveSum(int[] array){
    int sum = 0;
    for(int i=0; i < array.Length; i++){
        if(array[i] > 0) sum += array[i];
    }
    return sum;
}


int FindNegativeSum(int[] array){
    int sum = 0;
    for(int i=0; i < array.Length; i++){
        if(array[i] < 0) sum += array[i];
    }
    return sum;
}

bool FindNumberInArray(int[] array, int aa){
    for(int i = 0; i < array.Length; i++){
        if(array[i] == aa) return true;
    }
    return false;
}

int[] ReverseElementsArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        array[i] *= -1;
    }
    return array;
}

int FindCountElemensInRange( int[] array, int min, int max){
    int count = 0;
    for( int i=0; i < array.Length; i++){
        if( array[i] >= min && array[i] <= max ) count++;
    }
    return count;
}

string OutputArrayConsole(int[] array){
    string ss = "";
    for(int i = 0; i < array.Length; i++){
        ss += array[i] + ", ";
    }
    return ss;
}

//программа
Console.WriteLine("Работаем");
int[] myArray = CreateRandomArray(20,-20,20);
//задача 1
Console.WriteLine("reverse array " + OutputArrayConsole( ReverseElementsArray(myArray)) );
//задача 2
int find = 16;
Console.WriteLine("В массиве число "+ find + ( (FindNumberInArray(myArray,find)) ? "присутствует" : " не присутствует" ) );
//задача 3
int minnum = 10;
int maxnum = 99;
Console.WriteLine("Количество цифр в отрезке " + minnum + " до " + maxnum + " = " + FindCountElemensInRange( myArray, minnum, maxnum ) );

//Console.WriteLine("Sum of positive numbers is " + FindPositiveSum(myArray));
//Console.WriteLine("Sum of negative numbers is " + FindNegativeSum(myArray));



