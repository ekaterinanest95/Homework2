Console.Write("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;

if(length >= 3)
{
    Console.WriteLine(number[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
