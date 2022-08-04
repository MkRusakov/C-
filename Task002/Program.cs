Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ваши два числа: ");
Console.Write(number1);
Console.Write(" ");
Console.Write(number2);
if (number1/number2 == number2) 
{
    Console.Write(" Первое число является квадратом второго!");
}
else 
{
    Console.Write(" Первое число НЕ является квадратом второго!");
}