// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] arr = new string[5] {"22", "12345", ":0)", "hello", "world"};
string[] newarr = new string[arr.Length];
CrateModArray(arr, newarr);
Console.WriteLine("Изначальный массив :");
PrintArray(arr);
Console.WriteLine("Новый массив, с применённым методом :");
PrintArray(newarr);

void CrateModArray(string[] arr, string[] arr1)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if(arr[i].Length <= 3)
        {
        arr1[count] = arr[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{   
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}    
