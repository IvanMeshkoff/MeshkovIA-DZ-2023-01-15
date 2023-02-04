// Задача №3: Задать номер четверти, показать диапазоны для возможных координат.
Console.Clear();
Console.Write("Введите номер четверти: ");
int quarterNumber = int.Parse(Console.ReadLine() ?? "");
switch (quarterNumber)
{
  case 1:
    Console.WriteLine("Первая координатная четверть:");
    Console.WriteLine("Диапазон координат по X: [0, +бесконечность)");
    Console.WriteLine("Диапазон координат по Y: [0, +бесконечность)");
    break;
  case 2:
    Console.WriteLine("Вторая координатная четверть:");
    Console.WriteLine("Диапазон координат по X: [0, -бесконечность)");
    Console.WriteLine("Диапазон координат по Y: [0, +бесконечность)");
    break;
  case 3:
    Console.WriteLine("Третья координатная четверть:");
    Console.WriteLine("Диапазон координат по X: [0, -бесконечность)");
    Console.WriteLine("Диапазон координат по Y: [0, -бесконечность)");
    break;
  case 4:
    Console.WriteLine("Четвертая координатная четверть:");
    Console.WriteLine("Диапазон координат по X: [0, +бесконечность)");
    Console.WriteLine("Диапазон координат по Y: [0, -бесконечность)");
    break;
  default:
    Console.WriteLine("Такой координатной четверти не существует!");
    break;
}