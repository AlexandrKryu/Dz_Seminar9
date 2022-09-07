// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M: ");
double numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
double numberN = Convert.ToInt32(Console.ReadLine());

double AkkermannFunction (double numberM, double numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AkkermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AkkermannFunction(numberM - 1,
     AkkermannFunction(numberM, numberN - 1));
return AkkermannFunction(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AkkermannFunction(numberM, numberN)}");