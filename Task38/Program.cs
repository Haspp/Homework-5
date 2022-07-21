// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76




int size = InputInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);
int max = 0;
int min = 0;


for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] < min)
    {
        min = numbers[i];
    }
    else if (numbers[i] > max)
    {
        max = numbers[i];
    }


  
}
Console.WriteLine($"Максимальное число: {max}, Минимальное числов: {min}");
// Console.WriteLine("Максимальное число: " + max);
// Console.WriteLine("Минимальное число: " + min);


int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
    
}

void FillArray(int[] array)
{
for(int i = 0; i< array.Length; i++)
{
array[i] = new Random().Next(-99,100);
}
}

void PrintArray(int[] array)
{
for(int i = 0; i< array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}