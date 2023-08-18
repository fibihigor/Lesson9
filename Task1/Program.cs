/* Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
Пример:
M = 1; N = 9. -> "3, 6, 9" M = 13; N = 20. -> "15, 18"
*/

using static System.Console; 
 
Clear(); 
 
int M = AskNumber("M"); 
int N = AskNumber("N"); 
WriteLine($"M = {M}; N = {N}. -> \"{PrintRange(M, N)}\""); 
 
static string PrintRange(int M, int N)
{ 
    if (N < M) return string.Empty; 
    if (N % 3 == 0) 
    { 
        string part = (N - M) < 3 ? $"{N}" : $"{N}, "; 
        return part + PrintRange(M, N - 3);
    } 
    return PrintRange(M, N - 1); 
} 
 
static int AskNumber(string name) 
{ 
    Write($"Введите число {name}: "); 
    return int.Parse(ReadLine()); 
}