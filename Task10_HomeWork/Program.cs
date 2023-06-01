// Задача 10: Напишите программу,
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("   *** Start program ***");
Console.WriteLine("");
Console.WriteLine("");

Console.Write("Enter three digits number:  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

if (number < 100 || number > 999) Console.WriteLine("Entered not three digit number. Try again");
else
{
    int findDigit = SecondDigit(number);
    Console.WriteLine($"Second digit is {findDigit}");
}

int SecondDigit(int num)
{
    int result = (num / 10) % 10;
    return result;
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("    *** END program ***");
Console.WriteLine("");