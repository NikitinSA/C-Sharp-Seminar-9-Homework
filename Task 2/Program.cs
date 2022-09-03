/*Задайте значения M и N. Напишите программу, которая найдёт сумму чётных чисел 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18*/

Console.Clear();

Console.Write("Введите число M: ");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());

int SumOfEvenNumbers(int firstUserNumber, int secondUserNumber)
{
    if (firstUserNumber <= secondUserNumber)
    {
        if (firstUserNumber % 2 == 0)
        {
            return firstUserNumber + SumOfEvenNumbers(firstUserNumber + 2, secondUserNumber);
        }
        else
        {
            firstUserNumber = firstUserNumber + 1;
            return firstUserNumber + SumOfEvenNumbers(firstUserNumber + 2, secondUserNumber);
        }
    }
    else return 0;
}

Console.Write($"Cумма чётных чисел в промежутке от {firstUserNumber} до {secondUserNumber} = {SumOfEvenNumbers(firstUserNumber, secondUserNumber)}");