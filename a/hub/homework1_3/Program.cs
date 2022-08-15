Console.Write("Введите номер дня недели: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 == 1) 
{
    Console.Write($"не выходной");
}
else
{
    if (num1 == 2) 
    {
        Console.Write($"не выходной");
    }
    else 
    {
        if (num1 == 3) 
        {
            Console.Write($"не выходной");
        }
        else
        {
            if (num1 == 4) 
            {
                Console.Write($"не выходной");
            }
            else
            {
                if (num1 == 5) 
                {
                    Console.Write($"не выходной");
                }
                else
                {
                    if (num1 == 6) 
                    {
                        Console.Write($"выходной");
                    }
                    else
                    {
                         if (num1 == 7) 
                        {
                            Console.Write($"выходной");
                        }
                        else
                        {
                            Console.Write($"число не подходит");
                        }
                    }
                }
            }
        }
    }
}
