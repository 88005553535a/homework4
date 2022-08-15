Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1;
if (num1 / 100 == 0) 
{
    Console.Write($"3 цифры нет");
}
else
{
    while (num2 > 1000)
    {
        num2 = num2 / 10;
    }
    Console.Write($"{num2}");
    num2 = num2 % 10;
    Console.Write($"третья цифра = {num2}");
}
