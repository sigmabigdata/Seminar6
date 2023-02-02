
/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

вводим через один Enter (разбиваем через Split())
*/

Console.WriteLine("Введите числа: ");
int[] InitArray(int dimention)


{
    int[] result = new int[dimention];


    for (int i = 0; i < dimention; i++)
    {
        result[i] = Convert.ToInt32(Console.ReadLine());
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


int[] startArray = InitArray(5);

void SplitArray(int[] startArray)
{
    int[] arr = startArray;
    string[] massStr = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        massStr[i] = arr[i].ToString();
    }

}

void GetMoreZero(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Вы ввели {count} чисел больше 0.");
}

PrintArray(startArray);
SplitArray(startArray);
GetMoreZero(startArray);