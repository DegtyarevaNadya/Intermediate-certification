
//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.


int m = 0;
int n = 0;

do
{
    Console.Write("Введите значение M: ");
} while (!int.TryParse(Console.ReadLine(), out m) || m <= 0);

do
{
    Console.Write("Введите значение N (больше либо равно M): ");
} while (!int.TryParse(Console.ReadLine(), out n) || n < m);


Console.WriteLine($"Натуральные числа от {m} до {n}:");
PrintNaturalNumbers(m, n);


static void PrintNaturalNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m + " ");
        PrintNaturalNumbers(m + 1, n); 
    }
}