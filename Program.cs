 Console.Write("Informe o número inicial da contagem regressiva: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Fim da contagem.");