// Задача №1: Дано число обозначающее день недели. 
//            Выяснить является номер дня недели выходным

Console.Clear();
Console.Write("Введите число, обозначающее день недели: ");
int day = int.Parse(Console.ReadLine() ?? "");
if (day >= 1 && day <= 5)
{
  Console.WriteLine($"Веденное число {day} является РАБОЧИМ днем недели");
}
else if (day == 6 || day == 7)
{
  Console.WriteLine($"Веденное число {day} является ВЫХОДНЫМ днем недели");
}
else
{
  Console.WriteLine($"Веденное число {day} не является днем недели!");
}