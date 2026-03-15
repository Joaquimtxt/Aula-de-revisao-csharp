using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        ////Fundamentos
        ////Exercício 1, programa que soma dois números
        Console.WriteLine("Programa que soma dois números:");
        Console.WriteLine("Insira o 1° número");
        string numero1 = Console.ReadLine();
        Console.WriteLine("Insira o segundo número");
        string numero2 = Console.ReadLine();
        int num1 = int.Parse(numero1);
        int num2 = int.Parse(numero2);
        Console.WriteLine($"A soma entre {num1}+{num2} é igual a: {SomarNumero(num1, num2)}");

        ////Programa que verifica se número é par
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

        //Receber nome e idade e imprime mensagem
        Console.WriteLine("Programa recebe nome e idade:");
        Console.WriteLine("Insira seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Insira sua idade:");
        string idade = Console.ReadLine();
        Console.WriteLine($"Olá {nome}, que legal! Você já tem {idade} anos!");

    }
    static int SomarNumero(int a, int b)
    {
        return a + b;
    }

    //Programa que verifica se número é par

}