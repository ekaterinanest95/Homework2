/*Console.Write("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;

if(length >= 3)
{
    Console.WriteLine(number[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}*/



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 100 & number < 1000) Console.WriteLine(number % 10);
if(number >= 1000 & number < 10000) Console.WriteLine(((number % 100) - (number % 10)) / 10);
if(number >= 10000 & number < 100000) Console.WriteLine(((number % 1000) - (number % 100)) / 100);
if(number >= 100000 & number < 1000000) Console.WriteLine(((number % 10000) - (number % 1000)) / 1000);
if(number >= 1000000 & number < 10000000) Console.WriteLine(((number % 100000) - (number % 10000)) / 10000);
if(number >= 10000000 & number < 100000000) Console.WriteLine(((number % 1000000) - (number % 100000)) / 100000);
if(number >= 100000000 & number < 1000000000) Console.WriteLine(((number % 10000000) - (number % 1000000)) / 1000000);
if(number < 100) Console.WriteLine("Третьей цифры нет");









