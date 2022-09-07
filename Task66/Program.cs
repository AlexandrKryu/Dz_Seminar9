// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());


void NumberSum (int numM, int numN, int sum)
{   
    if (numM > numN) 
    {
        Console.Write($" M = {numberM}; N = {numN} -> {sum}");
        return;
    }
    sum +=  (numM++);
    NumberSum(numM, numN, sum);
}

NumberSum(numberM, numberN, 0);