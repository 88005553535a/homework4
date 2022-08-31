Console.Write("Введите целое положительное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int num3 = num1;
while (num3 > 0)
{
    sum = sum + num3 % 10;
    num3 = num3 / 10;
}
Console.WriteLine($"{num1} -> {sum}");
Console.WriteLine("Нажмите любую клавишу...");
Console.ReadKey();
