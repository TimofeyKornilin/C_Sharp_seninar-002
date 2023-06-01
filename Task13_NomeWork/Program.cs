// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("   *** Start program ***");
Console.WriteLine("");
Console.WriteLine("");

Console.Write("Enter number:  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

if (number < 100) Console.WriteLine($"The number {number} have not third digit");
else
{
    int result = ThirdDigit(number);
    Console.WriteLine($"The third digit of {number} is {result}");
    Console.WriteLine("");
    Console.WriteLine($"{number} -> {result}");
}


int ThirdDigit(int num)
{
    while (num > 999) num = num / 10;
    return num % 10;
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("    *** END program ***");
Console.WriteLine("");