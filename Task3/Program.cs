// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)// Запрашивает на ввод число
{
    System.Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

bool Right(int value)// Проверяет: является ли число натуральным
{
    if (value > 0)
    {
        return true;
    }
    return false;
}

void Cube(int value)// Возвращает список кубов чисел от 1 до value
{
    int count = 1;
    while (count <= value)
    {
        System.Console.Write($"{Math.Pow(count, 3)} ");
        count++;
    }
}

int number = Prompt("Введите натуральное число > ");

if (Right(number))
{
    Cube(number);
}
else
{
    System.Console.WriteLine($"Число {number} не является натуральным. Перезапустите программу и попробуйте ещё раз");
}


