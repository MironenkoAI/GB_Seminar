// СОБРАТЬ СТРОКУ с числами от a до b, a <= b
/*
string NumbersFor(int a, int b)   // итеративный подход
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)   // рекурсивный подход
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));

// СУММА ЧИСЕЛ
int SumFor(int n)   // итеративный подход
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)   // рекурсивный подход
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55

// ФАКТОРИАЛ ЧИСЛА

int FactorialFor(int n)   // итеративный подход
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n)   // рекурсивный подход
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800

// ВЫЧИСЛЕНИЕ СТЕПЕНИ
int PowerFor(int a, int n)   // итеративный подход
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)   // рекурсивный подход
{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
    // return n == 0 ? 1 : PowerRec(a, n - 1) * a; сокращенная запись
}

int PowerRecMath(int a, int n)   // рекурсивный подход с математическим вычислением
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024

// ПЕРЕБРАТЬ СИМВОЛЫ от.. до 
// (задача выводит все возможные сочетания букв из заданного алфавита)
int n = 1;  // рекурсия
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[2]);

// ПРОСМОТР СОДЕРЖИМОГО ПАПОК

string path = "/Users/Анастасия/Desktop/";  // путь папки
DirectoryInfo di = new DirectoryInfo(path);  // посмотреть папку
Console.WriteLine(di.CreationTime); // посмотреть дату создания
FileInfo[] fi = di.GetFiles();  // посмотреть какие файлы содержит папка

for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}
// рекурсия, которая позволяет ходить по папкам и смотреть содержимое
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
CatalogInfo(path);


// ИГРА в башенки (переставление с сортировкой)
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();
*/


// ОБХОД ДЕРЕВА (решение сложного примера)
// ((4-2) * (3+1)) / 10
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2     3    4    5    6    7    8    9    10   11
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();

