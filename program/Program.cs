﻿string[] FillArray1()
{
    Console.WriteLine("Введите элементы массива через пробел");
    string[] array = Console.ReadLine().Split(" ").ToArray();
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine();
}

int LengthArray2(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3) count++;
    }
    return count;
}

string[] FillArray2(int count, string[] array)
{
    string[] array2 = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            array2[index] = array[i];
            index++;
        }
    }
    return array2;
}

string[] array1 = FillArray1();
string[] array2 = FillArray2(LengthArray2(array1), array1);
PrintArray(array1);
PrintArray(array2);
