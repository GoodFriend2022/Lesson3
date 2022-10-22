// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)// Запрашивает на ввод число
{
    System.Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

double Distanсe(int x1, int y1, int z1, int x2, int y2, int z2)// Возвращает расстояние двух точек
{
    int x = x2 - x1;
    int y = y2 - y1;
    int z = z2 - z1;
    double powDistance2D = Math.Pow(x, 2) + Math.Pow(y, 2);
    double distanse3D = Math.Sqrt(Math.Pow(z, 2) + powDistance2D);
    return distanse3D;
}

int x1 = Prompt("Введите Х для первой координаты > ");
int y1 = Prompt("Введите Y для первой координаты > ");
int z1 = Prompt("Введите Z для первой координаты > ");
int x2 = Prompt("Введите Х для второй координаты > ");
int y2 = Prompt("Введите Y для второй координаты > ");
int z2 = Prompt("Введите Z для второй координаты > ");

double length = Distanсe(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine($"Расстояние между двух точек с координатами ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно => {length:f2}");
