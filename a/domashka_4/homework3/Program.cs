int[] array = new int[8];
Random myRandom = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = myRandom.Next(0, 8);
Console.Write("{0}  ", array[i]);
}
Console.Write("-> [ ");
for (int i = 0; i < array.Length; i++)
{
Console.Write("{0}  ", array[i]);
}
Console.WriteLine("]");
Console.WriteLine("Нажмите любую клавишу...");
Console.ReadKey();
