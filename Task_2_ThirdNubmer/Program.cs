// Вывести третью цийру слева числа
// и сообщить, что третьей цифры нет

Console.Write ("Введите число ");

int Number = Convert.ToInt32(Console.ReadLine());

if (Number / 100 > 0)
{
    int Result = Number % 1000;
    Result = Result /100;
    Console.Write($"Третья цифра числа {Number} = {Result}");
}
else
{
    Console.Write("Введено неправильное число, повторите попытку");
}
