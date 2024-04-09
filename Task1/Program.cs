// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine()!);

LineOutput(m, n);

void LineOutput(int number1, int number2)
{
    if (number2 == number1)
    {
        return;
    }
    else
    {
        LineOutput(number1, number2 - 1);
        Console.Write($"{number2} ");
    }
}