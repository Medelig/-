﻿System.Console.Write($"Введите значения через запятую в одну строчку для использования в массиве: ");

string word = Console.ReadLine();

string[] CreateArray()      // Создаем массив из введенный элементов.
{
    string[] arrayAll = word.Split(",");
    return arrayAll;
}

void PrintArray(string[] array)  // Метод для вывода массива (Используется для финального массива.).
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(", ");
    }
}