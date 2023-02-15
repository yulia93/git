// рекурсия
// сумма чисел от 1 до n

// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }

// int SumRec(int n)
// {
//     if (n==0) return 0;
//     else return n + SumRec(n - 1);
// }
// System.Console.WriteLine(SumFor(10));
// System.Console.WriteLine(SumRec(10));



// факториал числа

// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <=n; i++) result *= i;
//     return result;
// }

// int FactorialRec(int n)
// {
//     if (n==1) return 1;
//     else return n * FactorialRec(n - 1);
// }

// System.Console.WriteLine(FactorialFor(10));
// System.Console.WriteLine(FactorialRec(10));



// Вычислить a^n

// int PowerFor(int a, int n)
// {
//      int result = 1;
//      for (int i = 1; i <=n; i++) result *= a;
//      return result; 
// }

// int PowerRec(int a, int n)
// {
//     return n == 0 ? 1 : PowerRec(a, n - 1) * a;
//     if (n==0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }

// System.Console.WriteLine(PowerFor(2, 10));
// System.Console.WriteLine(PowerRec(2, 10));



// Перебор слов. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из T букв, которые можно построить из букв этого алфавита.
// char[] s = { 'а', 'и', 'с', 'в' };
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         for (int k = 0; k < count; k++)
//         {
//             for (int l = 0; l < count; l++)
//             {
//                 for (int m = 0; m < count; m++)
//                 {
//                     Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
//                 }
//             }
//         }
//     }
// }



// Как посмотреть содержимое папки?

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalogs = new DirectoryInfo(path);
//     foreach (var currentCatalog in catalogs.GetDirectories())
//     {
//         Console.WriteLine($"{indent}{currentCatalog.Name}");
//         CatalogInfo(currentCatalog.FullName, indent + " ");
//     }
//     foreach (var item in catalogs.GetFiles())
//     {
//         Console.WriteLine($"{indent}{item.Name}");
//     }
// }
// string path = @"/Users/yperepechina/Documents";
// CatalogInfo(path);