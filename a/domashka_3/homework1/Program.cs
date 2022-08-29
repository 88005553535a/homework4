Console.Write("Введите целое пятизначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1;
int num3 = 0;
int num4 = 0;
if (num1 / 10000 == 0) 
{
    Console.WriteLine($"У числа нет 5 значащих цифр");
}
else
{
    while(num1 > 0)
    {
    num4 = num1 % 10;
    num3 = num3 * 10 + num4;
    num1 = num1 / 10;
    }
        if (num3 == num2)
        {
        Console.WriteLine($"да");
        }
        else
        {
        Console.WriteLine($"нет");
        }
}
Console.WriteLine("Нажмите любую клавишу...");
Console.ReadKey();
