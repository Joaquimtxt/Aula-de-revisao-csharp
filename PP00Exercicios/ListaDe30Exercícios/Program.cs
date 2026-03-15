using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //Fundamentos
        //Exercício 1, programa que soma dois números
        Console.WriteLine("Programa que soma dois números:");
        Console.WriteLine("Insira o 1° número");
        string numero1 = Console.ReadLine();
        Console.WriteLine("Insira o segundo número");
        string numero2 = Console.ReadLine();
        int num1 = int.Parse(numero1);
        int num2 = int.Parse(numero2);
        Console.WriteLine($"A soma entre {num1}+{num2} é igual a: {SomarNumero(num1, num2)}");

        //2 - Programa que verifica se número é par
        Console.WriteLine("Programa que verifica se número é par:");
        Console.WriteLine("Insira um número");
        string numeroIsPar = Console.ReadLine();
        int numSPar = int.Parse(numeroIsPar);
        int dividir = numSPar % 2;
        if (dividir == 0)
        {
            Console.WriteLine($"o Número {numSPar} é par!");
        }
        else
        {
            Console.WriteLine($"o Número {numSPar} não é par!");
        }

        //3 -Receber nome e idade e imprime mensagem
        Console.WriteLine("Programa recebe nome e idade:");
        Console.WriteLine("Insira seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Insira sua idade:");
        string idade = Console.ReadLine();
        Console.WriteLine($"Olá {nome}, que legal! Você já tem {idade} anos!");

        //4 - Converter Graus celsius para farenheit
        Console.WriteLine("Insira a temperatura em Graus Celsius");
        string Celsius = Console.ReadLine();
        int Graus = int.Parse(Celsius);
        int Farenheit = (Graus * 9 / 5) + 32;
        Console.WriteLine($"Farenheit: {Farenheit} °F");

        //5 - Programa que calcula média de notas
        Console.WriteLine("Insira o nome do aluno");
        string nomeAluno = Console.ReadLine();
        Console.WriteLine($"Insira as notas do aluno {nomeAluno}");
        Console.WriteLine("Nota 1:");
        string nota1 = Console.ReadLine();
        Console.WriteLine("Nota 2:");
        string nota2 = Console.ReadLine();
        Console.WriteLine("Nota 3:");
        string nota3 = Console.ReadLine();
        double n1 = double.Parse(nota1);
        double n2 = double.Parse(nota2);
        double n3 = double.Parse(nota3);
        double media = ((n1 + n2 + n3) / 3);
        Console.WriteLine($"A média final do aluno {nomeAluno} é {Math.Round(media, 2)}");

        //6 - Loop números de 1 a 100
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine(i);

            if (i == 100)
            {
                Console.WriteLine("Fim da contagem");
            }
        }

        //7 - Apenas números pares
        for (int p = 0; p <= 100; p = p + 2)
        {
            Console.WriteLine(p);
            if (p == 100)
            {
                Console.WriteLine("Fim da contagem");
            }
        }
        //8 - Programa que soma dois números
        Console.WriteLine("Programa que multiplica dois números:");
        Console.WriteLine("Insira o 1° número");
        string primeiro = Console.ReadLine();
        Console.WriteLine("Insira o segundo número");
        string segundo = Console.ReadLine();
        int fst = int.Parse(primeiro);
        int snd = int.Parse(segundo);
        Console.WriteLine($"O produto entre {fst}*{snd} é igual a: {MultiplicarNumero(fst, snd)}");

        //9 - Verifica o maior número entre dois
        Console.WriteLine("Programa que identifica o maior entre dois números:");
        Console.WriteLine("Insira o 1° número");
        string number1 = Console.ReadLine();
        Console.WriteLine("Insira o segundo número");
        string number2 = Console.ReadLine();
        int numb1 = int.Parse(number1);
        int numb2 = int.Parse(number2);
        if (numb1 > numb2)
        {
            Console.WriteLine($"O número {numb1} é maior que o {numb2}");
        }
        else if (numb1 == numb2)
        {
            Console.WriteLine($"Os números {numb1} e {numb2}, são iguais!");
        }
        else
        {
            Console.WriteLine($"O número {numb2} é maior que o {numb1}");
        }

    }
    static int SomarNumero(int a, int b)
    {
        return a + b;
    }

    static int MultiplicarNumero(int a, int b)
    {
        return a * b;
    }

}