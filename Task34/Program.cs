﻿int size = InputInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);
int evenNumber = 0;

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] % 2 == 0)
    {
       evenNumber += 1;
    }
  
}
Console.WriteLine(evenNumber);


int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
    
}

void FillArray(int[] array)
{
for(int i = 0; i< array.Length; i++)
{
array[i] = new Random().Next(100, 999);
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






