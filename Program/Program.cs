// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите количество элементов массива: ");
var size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
FillArray(array);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine();
string[] resultArray = NoMoreThenThree(array);
Console.WriteLine("Результат: ");
PrintArray(resultArray);

void FillArray(string[] array)
{  
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите текст для {i+1} элемента массива: ");
        array[i] = new string(Console.ReadLine());
    }
}

void PrintArray(string[] array)
{
    for (int k = 0; k < array.Length; k++)
    {
            Console.Write($"{array[k]} ");
    }
}

string[] NoMoreThenThree (string[] array)
{
    var temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) temp++;
    }
    string[] arrayResult = new string[temp];
    for (int j = 0; j < arrayResult.Length; j++)
    {
        for (int k = 0; k < array.Length; k++)
        {
            if (array[k].Length <= 3) 
            {
                arrayResult[j] = array[k];
                j++;
            }        
        }
    }
    return arrayResult;
}