using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe a primeira pontuação: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Informe a segunda pontuação: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Informe a terceira pontuação: ");
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
        {
            Console.WriteLine("As três pontuações são iguais.");
        }
        else
        {
            int maior = a;

            if (b > maior)
                maior = b;

            if (c > maior)
                maior = c;

            Console.WriteLine("Maior pontuação: " + maior);
        }
    }
}