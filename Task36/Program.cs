﻿int size = InputInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);
int sumNegative = 0;


for(int i = 0; i < numbers.Length; i++)
{
    if(i % 2 == 1)
    {
       sumNegative += numbers[i];
    }
  
}
Console.WriteLine(sumNegative);


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