// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равно 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Создание массива из строк менее 4х символов
string[] CreateArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) count++;
    }
    string[] ShortArray = new string[count];
    count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            ShortArray[count] = arr[i];
            count++;
        }
    }
    return ShortArray;
} 

//Вывод массива
void ShowArray(string[] arr)
{
    Console.Write($"\nArray: [{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
    Console.Write("]\n");
}

//Заполнение массива строками
 void FillArray(string[] arr)
 {
        Console.WriteLine("Please, input array.");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToString(Console.ReadLine());
        }
}

string[] array = new string[3];
FillArray(array);
string[] shortArray = CreateArray(array);
ShowArray(shortArray);
