// Вид 1

// Ничего не принимает, ничего не возвращает.

// void Method1()
// {
//     Console.WriteLine("Автор: Яппаров Вячеслав");
// }

// Method1(); // Вызов метода.


// Вид 2

// Что-то принимает, но ничего не возвращает.

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

//Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++; // Инкримент
//     }
// }

//Method21(msg:"новый текст", count: 4);

// Вид 3

// Ничего не принимает, но что то возвращает.

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// Вид 4

// Что-то принимает, что-то возвращает.

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // инициализация пустой строки.
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, " asdf");
// Console.WriteLine(res);


// Цикл for

// string Method4(int count, string text)
// {
//     string result = String.Empty;   // инициализация пустой строки.
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, " asdf");
// Console.WriteLine(res);


// Цикл в цикле. (На примере вывода таблицы умножения на экран).

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// Задача: В тексте нужно все пробелы заменить чёрточками, маленькие буквы "к" заменить 
// большими "К", а большие "С" заменить на маленькие "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             012345  length = 6
// // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;  // инициализация пустой строки.

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|'); // заменим пробелы на вертикальные чёрточки.
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'к', 'К'); // заменим "к" на "К". передадим прошлый текст на обработку в новый тест.
// Console.WriteLine(newText);


// Задача. 
// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть неотсортированные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

// создадим подзадачу для вывода этого массива на экран

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Сщздаем метод который упорядочивает наш массив

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) //искусственно вычитем 1.
    {
        int minPosition = i;
        
        for(int j = i + 1; j < array.Length; j++) // Цикл внутри цикла. 
        {
            if(array[j] < array[minPosition]) minPosition = j;  // этот блок кода ищет минимальный элемент
        }
                             


        int temporary = array[i]; // Времянная переменная  SWOP
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);