Console.Write("Введите первую координату числа 1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату числа 1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью координату числа 1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую координату числа 2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату числа 2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью координату числа 2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
         Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
Console.WriteLine("Нажмите любую клавишу...");
Console.ReadKey();
