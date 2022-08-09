Console.Write("Введите число, обозначающее день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 6 ^ number == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
