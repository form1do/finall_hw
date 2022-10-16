// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool Ackermann(int numberM, int numberN)
{
    if (numberM > -1 && numberM < 4)
    {
        if (numberN > -1 && numberN < 4)
        {
            return true;
        }
    }
    return false;
}

int AckermannFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    return AckermannFunction(numberM, numberN);
}

System.Console.WriteLine("Расчет вычисления функции Аккермана ");
int numM = Prompt("Введите первое число m > ");
int numN = Prompt("Введите вторрое число n > ");
if (Ackermann(numM, numN))
{
    int result = AckermannFunction(numM, numN);
    Console.WriteLine($"Функция Аккермана для чисел ({numM},{numN}) = {result}");
}
else
{
    System.Console.WriteLine(" Введите корректные ");
}
