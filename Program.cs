// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void ShowResult(int[] mas)
{
    int sum = 0;
    for (int i = 1; i < mas.Length; i+=2)
    {
        sum = sum + mas[i];
    }
    Console.Write($"{sum}");
}

int[] GetMas(int number, int numMin, int numMax)
{
    int[] mas = new int[number];
    for(int i = 0; i < number; i++)
    {
        mas[i] = new Random().Next(numMin, numMax+1);
    }
    return mas;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите количество чисел в массиве: ");
int numMin = GetInput("Введите минимальное число массива: ");
int numMax = GetInput("Введите максимальное число массива: ");
int[] mas = GetMas(number, numMin, numMax);
Console.WriteLine($"Массив [{String.Join(",", mas)}]");
ShowResult(mas);