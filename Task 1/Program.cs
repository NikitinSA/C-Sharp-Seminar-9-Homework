/*Задайте значения M и N. Напишите программу, которая выведет все натуральные 
числа в промежутке от M до N от большего к меньшему.
M = 1; N = 5. -> "5, 4, 3, 2, 1"
M = 4; N = 8. -> "8, 7, 6, 5, 4"*/

Console.Clear();

Console.Write("Введите число M: ");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());

string Number(int secondUserNumber, int firstUserNumber)
{
    if (firstUserNumber <= secondUserNumber)
    {
        return $"{secondUserNumber} " + Number(secondUserNumber - 1, firstUserNumber);
    }
    else
    {
        return String.Empty;
    }
}

Console.Write(Number(secondUserNumber, firstUserNumber));