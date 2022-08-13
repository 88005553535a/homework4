Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 1)
{
    Console.Write($"{num1} нечетное");
}
else
{
    Console.Write($"{num1} четное");
}
