Console.Write("Введите целое положительное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 1;
int num3 = 1;
    while(num1 > 0)
    {
    num2 = num3 * num3 * num3;
    num1 = num1 - 1;
    Console.Write($"{num2}, ");
    num3 = num3 + 1;
    }
Console.WriteLine("Нажмите любую клавишу...");
Console.ReadKey();
