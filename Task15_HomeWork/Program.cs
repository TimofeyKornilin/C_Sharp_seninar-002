// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("   *** Start program ***");
Console.WriteLine("");
Console.WriteLine("");

Console.Write("Enter number of week day:  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

if (number < 1 || number > 7) Console.WriteLine($"Not correct entered. Try again");
else
{
    bool result = WeekEnd(number);
    Console.Write($"{number} -> "); 
    Console.WriteLine(result ? "Yes" : "No");
}


bool WeekEnd(int num)
{
    return num == 6 || num == 7;
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("    *** END program ***");
Console.WriteLine("");