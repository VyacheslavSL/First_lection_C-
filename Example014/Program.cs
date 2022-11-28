// Собрать строку с числами от a до b, a <= b.
// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for(int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if(a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(1,10));
// Console.WriteLine(NumbersRec(1,10));

// ==================================================================================================

// Собрать строку с числами от a до b, a => b.

// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for(int i = a; i >=b; i--)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if(a <= b) return NumbersRec(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(10,1));
// Console.WriteLine(NumbersRec(1,10));

// =========================================================================================================================

// Сумма чисел от 1 до n

// int SumFor(int n)
// {
//     int result = 0;
//     for(int i = 1; i <= n; i++) result += i;
//     return result;
// }

// int SumRec(int n)
// {
//     if(n == 0) return 0;
//     else return n + SumRec(n - 1);
// }

// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));

// ========================================================================================================================

// Факториал числа

// int FactorialFor(int n)
// {
//     int result = 1;
//     for(int i = 1; i <= n; i++) result *= i;
//     return result;
// }

// int FactorialRec(int n)
// {
//     if(n == 1) return 1;
//     else return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRec(10));

// =========================================================================================================================

// Вычислить a в степени n.

// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for(int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// int PowerRec(int a, int n)
// {   
//     if(n == 0) return 1;                    // Можно эти две строчки заменить тернарным оператором 
//     else return PowerRec(a, n - 1) * a;     // return n == 0 ? 1 : PowerRec(a, n - 1) * a;
// }

// Console.WriteLine(PowerFor(2,10));
// Console.WriteLine(PowerRec(2,10));

// =======================================================================================================================

// int PowerRecMath(int a, int n)
// {
//     if(n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRecMath(a, n - 1) * a;
// }

// Console.WriteLine(PowerRecMath(2,10));

// ========================================================================================================================

// Перебор слов. В некотором машинном алфавите имеются четыре буквы "а", "и", "с" и "в". Покажите все слова, состоящие из "Т"
// букв, которые можно построить из букв этого алфавита.

// int n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if(length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for(int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }

// FindWords("аисв", new char[2]);

// ===================================================================================================================

// Обход дирректории. Нужно просмотреть все папки, которые находятся внутри этой папки и все файлы находящиеся внутри этой
// папки. Папка внутри будет хранилещем папок и файлов и т.д. Для того чтобы посмотреть, что находится в папке, нужно посмотреть
// что находится в следующих папках

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for(int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }


//     FileInfo[] files = catalog.GetFiles();

//     for(int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }
// string path = @"\Slava\Учеба\EXAMPLES\Example001_HelloConsole";
// CatalogInfo(path);

// =======================================================================================================================

//  3 Пирамидки

// void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// {
//     if(count > 1) Towers(with, some, on, count - 1 );
//     Console.WriteLine($"{with} >> {on}");
//     if(count > 1) Towers(some, on, with, count - 1);
// }

// Towers();

// ===================================================================================================================

string emp = String.Empty;
string[]tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//               0    1    2     3    4    5    6    7    8    9    10   11

void InOrderTraversal(int pos = 1)
{
    if(pos < tree.Length)
    {
        int left = 2 * pos;
        int rigt = 2 * pos + 1;
        if(left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if(rigt < tree.Length && !String.IsNullOrEmpty(tree[rigt])) InOrderTraversal(rigt);
    }
}

InOrderTraversal();