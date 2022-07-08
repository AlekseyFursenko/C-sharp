// Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
/*
bool IdentFirstVowel(string word)
{
    char[] vowel = {'a', 'e', 'i', 'o', 'u', 'y'};
    
    for (int i = 0; i < vowel.Length; i++)
    {
        string wordToLowerReg = word.ToLower();

        if(wordToLowerReg[0] == vowel[i]) return true;
    }
    
    return false;
}

int FirstVowelCount(string[] array)
{
    
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IdentFirstVowel(array[i])) count++;
        
    }

    return count;
}

string[] array = {"qwe", "Asd", "ert", "sh", "yes", "23dfg"};

Console.WriteLine("The number of words in the array starting with a vowel letter is - " + FirstVowelCount(array));
*/

// Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
/*
string[] PairedElements(string[] array)
{
    string[] pairedArray = new string[(array.Length / 2) + (array.Length % 2)];

    pairedArray[(array.Length / 2) + (array.Length % 2) -1] = array[array.Length - 1];

    for (int i = 0; i < array.Length / 2; i++)
    {
        pairedArray[i] = array[i * 2] + array[i * 2 + 1];
    }

    return pairedArray;
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    
    Console.WriteLine();
}

string[] array = {"qwe", "Asd", "ert", "sh", "yes", "no", "rest"};

PrintArray(array);

string[] newarray = PairedElements(array);

Console.WriteLine("New array with paired elements - ");

PrintArray(newarray);
*/