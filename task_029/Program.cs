// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int DataNumber(string meseg)
{
    Console.Write(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintArray(int[] charr)
{
    int i;
    for (i = 0; i < charr.Length - 1; i++)
    {
        Console.Write(charr[i] + ", ");
    }
    Console.Write(charr[i]);
}

void RandomIndex(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 99);
    }
}

Console.Clear();
int index = DataNumber("Укажите раззмер масива ");
int[] array = new int[index];
RandomIndex(array);
PrintArray(array);