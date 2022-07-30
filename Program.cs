// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Задача: Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше или равна 3 символа. Первоначальный 
// массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] => ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] => ["-2"]
// ["Russia", "Denmark", "Kazan"] => []

// метод, который принимает на вход аргументы: первоначальный массив и новый массив, для его формирования
void stringArrayInNewArray(string[] stringArray, string[] newStringArray)
{
    for (int i = 0; i < stringArray.Length; i++) // вывод в консоль первоначального массива
    {
        Console.Write(" " + stringArray[i] + " ");
    }
    Console.Write(" => ");

    if (newStringArray.Length == 0) // условие, при котором выводится 0 значение (массив 0 размера)
    {
        Console.WriteLine("[]");
    }
    else
    if (newStringArray.Length <= newStringArray.Length) // условие для формирования нового массива с учётом его длины
    {
        int temp = 0; // перменная для последующей записи данных в новый массив
        for (int i = 0; i < stringArray.Length && i < newStringArray.Length; i++) // формирование нового массива
        {
            temp = new Random().Next(0, stringArray.Length); // присваивание значений из из первоначального массива и 
            newStringArray[i] = stringArray[temp];           // их запись в новый массив
            Console.Write(" " + newStringArray[i] + " ");   // ввывод нового массива в консоль
        }
        Console.WriteLine();
    }
}

// Примеры
Console.Write("1 пример: ");
string[] stringArray1 = new String[] {"hello", "2", "world", ":-)"}; // первоначальный массив
string[] newStringArray1 = new String[2]; // новый массив
stringArrayInNewArray(stringArray1, newStringArray1); // вызов метода

Console.Write("2 пример: ");
string[] stringArray2 = new String[] {"1234", "1567", "-2", "computer science"}; // первоначальный массив
string[] newStringArray2 = new String[1]; // новый массив
stringArrayInNewArray(stringArray2, newStringArray2); // вызов метода

Console.Write("3 пример: ");
string[] stringArray3 = new String[] {"Russia", "Denmark", "Kazan"}; // первоначальный массив
string[] newStringArray3 = new String[0]; // новый массив
stringArrayInNewArray(stringArray3, newStringArray3); // вызов метода
