// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.(С помощю цикла)


int DataNumber(string meseg)
{
    Console.Write(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberA = DataNumber("Введите число А ");
int numberB = DataNumber("Введите число В ");
double exp = numberA;
if(numberB > 0)
{
    for (int i = 1; i < numberB; i++)
    {
     exp = exp*numberA;
    }
    Console.WriteLine($"Степень числа {numberA} в {numberB} = {Math.Round(exp, 2)}");
}
else if(numberB == 0) exp = 1;
else
{
    numberB = -numberB;
    for (int i = 1; i < numberB; i++)
    {
    exp = exp*numberA;
    }
    exp = 1/exp;
    Console.WriteLine($"Степень числа {numberA} в -{numberB} = {Math.Round(exp, 2)}");
}
