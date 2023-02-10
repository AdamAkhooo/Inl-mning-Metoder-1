using System;
class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Skriv tal");
        int tal1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Skriv tal");
        int tal2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Skriv tal");
        int tal3 = int.Parse(Console.ReadLine());

        int summa = Addera(tal1, tal2, tal3);
        Console.WriteLine(summa);
    }

    static int Addera(int tal1, int tal2, int tal3)
    {
        int summa = tal1 + tal2 + tal3; 
        return summa; 
    }
}