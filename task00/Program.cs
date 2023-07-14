// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int GetNumber(string message) //Пишем передаваемое сообщение - запрашиваем у пользователя число - на выходе из функции выдаем это число
{
    Console.Write(message + " ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int FindRazryad(int findRazryad) // Функция нахождения разряда
{
    int razryadNumber = 0;
    while (findRazryad > 0)
    {
        findRazryad = findRazryad / 10;
        razryadNumber++;
    }
    return razryadNumber;
}

int BitwiseAddition(int a) //Функция нахождения поразрадяной суммы числа (аргумент a - число)
{
    int sum = 0;
    int b = FindRazryad(a);
    while (b > 0)
    {
        sum = sum + a % 10;
        b = b - 1;
        a = a / 10;
    }
    return sum;
}


int HalfOfNum(int a) //Функция нахождения количества знаков числа для деления его на две части - (аргумент a - разряд числа) Для нечетного числа к аргументу надо прибавить 1 в нашем случае
{
    a = a / 2;
    return a;
}

int BitUnit(int a) //Находим эквивалентую числу разрядную единицу (аргумент a - разряд числа)
{
    int b = 1;
    while (a > 1)
    {
        b = b * 10;
        a = a - 1;
    }
    return b;
}

int TurnOfNumber(int a) //Функция разворота числа
{
    int razryad = FindRazryad(a);
    int razryadEqual = BitUnit(razryad);
    int turn = 0;
    while (razryad > 0)
    {
        turn = turn + (a % 10 * razryadEqual);
        a = a / 10;
        razryadEqual = razryadEqual / 10;
        razryad = razryad - 1;
    }
    return turn;
}

int num = GetNumber("Введите число:");
int razryad = FindRazryad(num);
if (razryad % 2 == 0) //Определяем является ли число нечетным
{
    int firstPartOfNumber = num / (BitUnit(HalfOfNum(razryad)) * 10);
    int secondPartofNumber = num % (BitUnit(HalfOfNum(razryad)) * 10);
    //В результате мы нашли 2 половинки числа (для четного 4444 = 44 и 44)
    if (firstPartOfNumber == TurnOfNumber(secondPartofNumber)) //теперь сравниваем половинку с отзеркаленной второй половинкой
        Console.Write($"Число {num} является полиндромом");
    else
        Console.Write($"Число {num} не является полиндромом");
}
else
{

    int firstPartOfNumber = num / BitUnit(HalfOfNum(razryad) + 1); // Так как число нечетное - смещаем разряд на 1, к примеру 858. Разряд числа 3/2 = 1. Нам же нужно взять 2 разряда с обеих сторон.
    int secondPartofNumber = num % (BitUnit(HalfOfNum(razryad) + 1) * 10); // Так как число нечетное - смещаем разряд на 1, к примеру 858. Разряд числа 3/2 = 1. Нам же нужно взять 2 разряда с обеих сторон.
    //В результате мы нашли 2 половинки числа (для нечетного 12321 = 123 и 321)
    if (firstPartOfNumber == TurnOfNumber(secondPartofNumber)) //теперь сравниваем половинку с отзеркаленной второй половинкой
        Console.Write($"Число {num} является полиндромом");
    else
        Console.Write($"Число {num} не является полиндромом");
}
