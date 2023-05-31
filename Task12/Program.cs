// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.WriteLine("   *** Start program ***");
Console.WriteLine("");
Console.WriteLine("");


Console.Write("Enter first number:  ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");
int remainder = DivisionAndRemainder(firstNumber, secondNumber);
string result = remainder == 0 ? $"Yes {firstNumber} is a multiple of the {secondNumber}" 
                             : $"No {firstNumber} is not a multiple of the {secondNumber}, remainder is {remainder}";
Console.WriteLine(result);

// if (result == 0) Console.WriteLine($"Yes {firstNumber} is a multiple of the {secondNumber}");
// else Console.WriteLine($"No {firstNumber} is not a multiple of the {secondNumber}, remainder is {result}");


int DivisionAndRemainder(int num1, int num2)
{
    return num1 % num2;
}


Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("    *** END program ***");
Console.WriteLine("");
