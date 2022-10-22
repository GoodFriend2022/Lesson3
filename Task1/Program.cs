// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Без использования строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)// Запрашивает на ввод число
{
    System.Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

bool Right(int value)// Проверяет: является ли число пятизначным
{
    if (value > 9999 && value < 100000)
    {
        return true;
    }
    return false;
}

void Palindrome(int number)// Проверяет: является ли число полиндромом
{
    int firstNumber = number / 10000;
    int lastNumber = number % 10;
    int secondNumber = (number - number / 10000 * 10000) / 1000;
    int penultNumber = number / 10 % 10;
    if (firstNumber == lastNumber && secondNumber == penultNumber)
    {
        System.Console.WriteLine($"Да, введенное Вами число ({number}) является полиндромом");
    }
    else
    {
        System.Console.WriteLine($"Нет, введенное Вами число ({number}) не является полиндромом");
    }
}

int number = Prompt("Введите пятизначное число > ");

if (Right(number))
{
    Palindrome(number);
}



