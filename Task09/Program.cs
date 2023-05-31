// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Console.Clear();
Console.WriteLine("   *** Start program ***");
Console.WriteLine("");
Console.WriteLine("");

int number = new Random().Next(10, 100);

Console.WriteLine($"Random number from 10 to 99: {number}");
Console.WriteLine("");
// int digit2 = number % 10;
// int digit1 = (number - digit2) / 10;
// Console.WriteLine($"First digit:  {digit1}");
// Console.WriteLine($"Second digit: {digit2}");

// Console.WriteLine("");
// if (digit1 == digit2) Console.WriteLine("First and second digit equal");
// else
// {
//     if (digit1 > digit2)
//     {
//         Console.WriteLine($"First digit bigger: {digit1}");
//         Console.WriteLine($"              {number} -> {digit1}");
//     }
//     else
//     {
//         Console.WriteLine($"Second digit bigger: {digit2}");
//         Console.WriteLine($"               {number} -> {digit2}");
//     }
// }

// Console.WriteLine("");
// Console.WriteLine("     *** Another way ***");

//            Тернарный оператор
// int maxDigit = digit1 > digit2 ? digit1 : digit2;
// Console.WriteLine($"Bigger digit is {maxDigit}");

// Console.WriteLine("");
Console.WriteLine("     *** Another way with METOD ***");


int maxDigit2 = MaxDigit(number);
Console.WriteLine($"Bigger digit with METOD: {maxDigit2}");

int MaxDigit(int num)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("    *** END program ***");
Console.WriteLine("");
