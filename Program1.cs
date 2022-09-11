System.Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
if((number[0] == number[4]) || (number[1] == number[3]))
{
    System.Console.WriteLine("Ваше число палиндром");
}
else
{
    System.Console.WriteLine("Ваше число не палиндром");
}