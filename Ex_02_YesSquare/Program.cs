// Задача №2: По двум заданным числам проверять, 
//            является ли одно квадратом другого

Console.Clear();
Console.Write("Ввведите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Ввведите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "");
if (number1 == number2*number2)
{
  Console.WriteLine($"Первое число {number1} является квадратом второго числа {number2}");
}
else if (number2 == number1*number1)
{
  Console.WriteLine($"Второе число {number2} является квадратом первого числа {number1}");
}
else
{
  Console.WriteLine("Ни одно из этих двух чисел не является квадратом второго");
}