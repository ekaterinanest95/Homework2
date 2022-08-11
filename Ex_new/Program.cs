/*Даны два натуральных числа N и K. Требуется вывести  все цепочки x1, x2, ..., xN такие, что xi - натуральное и 1 ≤ xi ≤ K.

Входные данные
Вводятся два натуральных числа N и K (N, K ≤ 6).

Выходные данные
Выведите все требуемые цепочки в произвольном порядке – по одной на строке. Никакая цепочка не должна встречаться более одного раза. */

void FillArray(int[] collection)
{
    int lengh = collection.Length;
    int index = 0;
    while(index < lengh)
    {
        collection[index] = new Random().Next(1, 6);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]);
        position++;
    }

}

Console.Write("Введите число К: ");
int numberK = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numberK);
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numberN);

if(numberK < numberN)
{
    int[] arrayK = new int[6];
    FillArray(arrayK);
    PrintArray(arrayK);
    Console.WriteLine();
    int[] arrayN = new int[6];
    FillArray(arrayN);
    PrintArray(arrayN);
    Console.WriteLine();
    int[] arrayKN = new int[6];
    FillArray(arrayKN);
    PrintArray(arrayKN);

}
if(numberN < numberK)
{
    int[] arrayK = new int[6];
    FillArray(arrayK);
    PrintArray(arrayK);
    Console.WriteLine();
    int[] arrayN = new int[6];
    FillArray(arrayN);
    PrintArray(arrayN);
    Console.WriteLine();
    int[] arrayNK = new int[6];
    FillArray(arrayNK);
    PrintArray(arrayNK);
}
if(numberK == numberN)
{
    int[] array = new int[6];
    FillArray(array);
    PrintArray(array);
}
