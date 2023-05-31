// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98 

Console.Clear();
Console.WriteLine("   *** Start program ***");
Console.WriteLine("");
Console.WriteLine("");

int number = new Random().Next(99, 1000);

Console.WriteLine($"Random number from 100 to 999: {number}");
Console.WriteLine("");

int result = DellMiddleDigit (number);
Console.WriteLine($"Findedly number: {result}");

int DellMiddleDigit (int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int dobleDigitNumber = firstDigit*10 + lastDigit;
    return dobleDigitNumber;
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("    *** END program ***");
Console.WriteLine("");
