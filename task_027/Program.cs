// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int DataNumber(string meseg)
{
    Console.Write(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Decay(int number)
{
    int sum;
    for (sum = 0; number != 0; number = number/10)
    {
        int count = number % 10;
        sum = sum + count;
        // Console.WriteLine(sum); //Поверка(что происходит в цикле)
    }
    return sum;
}

int num = DataNumber("Введите число ");
if(num > 0)
{
    int sum = Decay(num);
    Console.WriteLine(sum);
}
else (Console.WriteLine("Введено неверно число"));