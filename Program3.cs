System.Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    System.Console.WriteLine(Math.Pow(i, 3));
}