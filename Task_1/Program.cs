// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write ("Введите число ");

int Number = Convert.ToInt32(Console.ReadLine());

if (Number / 100 < 9)
{
    int Result = Number / 10;
    Result = Result % 10;
    Console.Write ($"Вторая цифра числа {Number} = {Result}");
}
else
{
    Console.Write ("Введено неправильное число, повторите попытку");
}
