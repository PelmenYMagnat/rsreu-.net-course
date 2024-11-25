using System;
class Programm
{ 
   static void Main(string[] args)
    {
        int N;
        Console.Write("Введите количество элементов N: ");
        N = int.Parse(Console.ReadLine());
        
        for (int n = 0; n < N; n++)
        {
            double a_n = CalculateAN(n);
            Console.WriteLine($"a({n}) = {a_n}");
        }
    }
    static double CalculateAN(int n)
    {
        return Math.Pow(-1, n) * (n + 1) / (Math.Pow(n, 3) + 2);
    }
}