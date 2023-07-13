// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Coordinata(string message) //Пишем передаваемое сообщение - запрашиваем у пользователя число - на выходе выдаем это число
{
    Console.Write(message + " ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
double Distance(int x, int y, int z, int x1, int y1, int z1) //считаем расстояние на оси координат между двумя точками и на выходе выдаем это расстояние
{
    double distance = Math.Sqrt((x1 - x)*(x1-x) + (y1 - y)*(y1-y) + (z1 - z)*(z1-z));
    return distance;
}

int x1 = Coordinata("Введите x координату точки 1");
int y1 = Coordinata("Введите y координату точки 1");
int z1 = Coordinata("Введите z координату точки 1");
int x2 = Coordinata("Введите x координату точки 2");
int y2 = Coordinata("Введите y координату точки 2");
int z2 = Coordinata("Введите z координату точки 2");


Console.WriteLine("Расстояние между точками: " + Distance(x1, y1, z1, x2, y2, z2));
