// Задача №4: Найти расстояние между точками в пространстве 2D/3D.
Console.Clear();

int space;
double x1, x2, y1, y2, z1, z2, distance;

Console.WriteLine("Выберите размерность пространства 2D или 3D");
Console.Write("Введите 2 для двумерного пространства или 3 для трёхмерного: ");

space = Convert.ToInt32(Console.ReadLine());
switch (space)
{
  case 2:
    Console.WriteLine("Введите координаты первой точки A для двумерного пространства:");
    Console.Write("Введите координаты точки A по оси X: ");
    x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты точки A по оси Y: ");
    y1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки B для двумерного пространства:");
    Console.Write("Введите координаты точки B по оси X: ");
    x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты точки B по оси Y: ");
    y2 = Convert.ToDouble(Console.ReadLine());
    distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.WriteLine($"Расстояние между двумя точками A и B в двумерном пространстве = {distance}");
    break;
  case 3:
    Console.WriteLine("Введите координаты первой точки A для трехмерного пространства:");
    Console.Write("Введите координаты точки A по оси X: ");
    x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты точки A по оси Y: ");
    y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты точки A по оси Z: ");
    z1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки B для трёхмерного пространства:");
    Console.Write("Введите координаты точки B по оси X: ");
    x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты точки B по оси Y: ");
    y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты точки B по оси Z: ");
    z2 = Convert.ToDouble(Console.ReadLine());
    distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine($"Расстояние между двумя точками A и B в двумерном пространстве = {distance}");
    break;
  default:
    Console.WriteLine("Пространство не выбрано, поробуйте еще раз!");
    break;
}