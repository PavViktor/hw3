/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите координаты первой точки");
bool isParsedX1 = int.TryParse(Console.ReadLine(), out int x1);
bool isParsedY1 = int.TryParse(Console.ReadLine(), out int y1);
bool isParsedZ1 = int.TryParse(Console.ReadLine(), out int z1);

Console.WriteLine("Введите координаты второй точки");
bool isParsedX2 = int.TryParse(Console.ReadLine(), out int x2);
bool isParsedY2 = int.TryParse(Console.ReadLine(), out int y2);
bool isParsedZ2 = int.TryParse(Console.ReadLine(), out int z2);

if(!isParsedX1 || !isParsedY1 || !isParsedZ1 || !isParsedX2 || !isParsedY2 || !isParsedZ2)
{
    Console.WriteLine("Координаты ввели не корректно");
    return;
}

double number = calcDist(x1, y1, z1, x2, y2, z2 );
Console.WriteLine($"Расстояние между точками = {number}");

double calcDist(int xa, int ya, int za, int xb, int yb, int zb)
{
    double num = Math.Pow(Math.Pow (xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2), 0.5);
    return num;
}
