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
for (int i = 1; i < numberB; i++)
{
    exp = exp*numberA;
}
Console.WriteLine($"Степень числа {numberA} в {numberB} = {exp}");
