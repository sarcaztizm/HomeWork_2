// Принять на вход цифру обозначающую день неднли
// и проверить является ли этот день выходным

Console.Write ("Введите число ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number < 8 && Number > 5)
{
    Console.WriteLine("Выходной");
    if (Number == 6)    
    {
        Console.Write("Суббота");
    }
    else
    {
        Console.Write("Воскресенье");
    }
}
else
{
    Console.Write("Введено неправильное число или день недели не выходной");
}
