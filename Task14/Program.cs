// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();
Console.WriteLine("   *** Start program ***");
Console.WriteLine("");
Console.WriteLine("");

Console.Write("Enter number:  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
bool result = MultiplicityFor7And23(number);
Console.WriteLine(result ? $"Yes, number {number} is multiplicity for 7 and 23" : $"No, number {number} is not multiplicity for 7 and 23");

bool MultiplicityFor7And23(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("    *** END program ***");
Console.WriteLine("");