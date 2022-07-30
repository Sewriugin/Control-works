// Задача: Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше или равна 3 символа. Первоначальный 
// массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] => ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] => ["-2"]
// ["Russia", "Denmark", "Kazan"] => []

// метод, который принимает на вход аргументы: первоначальный массив и количества символов для вывода
void stringArrayInNewArray(string[] stringArray, int n)
{
    for (int i = 0; i < stringArray.Length; i++) // вывод в консоль первоначального массива
    {
        Console.Write(stringArray[i] + " ");
    }
    Console.Write(" => ");
        
    string tempStr; // перменная для присваивания элемента массива строки
    char[] tempChars; // переменная для присваивания символов из массива строки (знаков)
    for (int i = 0; i < stringArray.Length; i++) // формирование нового массива и вывод его в консоль
    {
        tempStr = stringArray[i]; // присваивание i элемента
        tempChars = tempStr.ToCharArray(); // присваивание знаков элемента
        if (tempChars.Length <= n) // условие сравнения количества знаков в элементе строки
        {
        Console.Write(stringArray[i] + " "); // вывод в консоль
        }    
    }
    Console.WriteLine();
}

    // Примеры
    Console.Write("1 пример: ");
    string[] stringArray1 = new String[] {"hello", "2", "world", ":-)"};
    stringArrayInNewArray(stringArray1, 3); // вызов метода с указанием аргументов: массива и количества символов 
    Console.Write("2 пример: ");
    string[] stringArray2 = new String[] {"1234", "1567", "-2", "computer science"};
    stringArrayInNewArray(stringArray2, 3); // вызов метода с указанием аргументов: массива и количества символов
    Console.Write("3 пример: ");
    string[] stringArray3 = new String[] {"Russia", "Denmark", "Kazan"};
    stringArrayInNewArray(stringArray3, 3); // вызов метода с указанием аргументов: массива и количества символов
    
