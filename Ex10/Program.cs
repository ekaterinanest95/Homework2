Console.Write("Введите трехзначеное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = (number % 100) / 10;
Console.WriteLine($"Вторая цифра числа {number} - {secondDigit}");