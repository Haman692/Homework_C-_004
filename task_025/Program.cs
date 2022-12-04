// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int DataNumber(string meseg)
{
    Console.Write(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberA = DataNumber("Введите число А ");
int numberB = DataNumber("Введите число В ");

double exp = Math.Pow(numberA, numberB);
Console.WriteLine($"Степень числа {numberA} в {numberB} = {exp}");
