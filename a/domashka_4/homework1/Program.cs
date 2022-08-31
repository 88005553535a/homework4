Console.Write("Введите целое положительное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительную степень числа: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = num1;
int num4 = num2;
while (num2 > 1)
{
    num1 = num1 * num3;
    num2 = num2 - 1;
}
Console.WriteLine($"{num3}, {num4} -> {num1}");
Console.WriteLine("Нажмите любую клавишу...");
Console.ReadKey();
