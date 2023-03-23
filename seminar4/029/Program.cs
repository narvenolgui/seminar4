//Задача 29: Напишите программу, которая будет создавать массив из 8 символов и заполнять значениями от пользователя

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int Prompt(string message)
{
    System.Console.Write(message);
    string ReadInput = System.Console.Readline();
    int result = int.Parse(ReadInput);
    returne result;
}
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}
int length = Prompt ("Длина массива: ");
int min = Prompt ("Начальное значение для диапозога случайного числа: ");
int max = Prompt ("Конечное значение для диапозога случайного числа: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);