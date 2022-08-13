Console.Write("Введите целое положительное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
if (num1 >= 0)
{
    while (num2 <= num1)
        {
        Console.Write(num2 + " ");
        num2 = num2 + 2;
        }
}
else Console.Write("Число не подходит условиям");

