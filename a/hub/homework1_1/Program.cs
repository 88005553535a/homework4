Console.Write("Введите целое трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1;
if (num1 / 100 == 0) 
{
    Console.Write($"У числа нет 3 значащих цифр");
}
else
{
    num2 = num2 / 10;
    num2 = num2 % 10;
    Console.Write($"вторая цифра = {num2}");
}
