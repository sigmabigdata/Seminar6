﻿int[] Fibonachi(int number)
{
    int[] array = new int[number];
    if (number == 1)
    return new int[1] {0};

    if (number == 2)
    return new int[2] {0, 1};
    array [0] = 0;
    array [1] = 1;
    for (int i = 2; i < number; i++)
    {
        array[i] = array[i-1] + array[i-2]; 
    }
    return array;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = Fibonachi(number);
Console.WriteLine(string.Join(", ", array));