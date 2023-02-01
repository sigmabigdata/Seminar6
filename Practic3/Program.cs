Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberStr = "";

while (number > 0)
{
    numberStr = numberStr + number % 2;
    number = number / 2;

}

Console.WriteLine(new string(numberStr.Reverse().ToArray()));
