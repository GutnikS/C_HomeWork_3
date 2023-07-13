// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message) //Пишем передаваемое сообщение - запрашиваем у пользователя число - на выходе выдаем это число
{
    Console.Write(message + " ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void Сube (int num) //Печатаем последовательно кубы числа от 1 до N
{
    for (int count = 1; count <= num; count++)
    {
        if (count == num)
            Console.Write(count * count * count);
        else
            Console.Write(count * count * count + ", ");
    }
}

int n = Prompt("Введите число N:");
Сube(n);
