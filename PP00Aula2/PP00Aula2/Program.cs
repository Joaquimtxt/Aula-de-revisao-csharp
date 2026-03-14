internal class Program
{
    private static void Main(string[] args)
    {
        //exemplo de atributo de classe console
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        //Exemplo de método da classe console
        Console.WriteLine("Hello, World!");

        //Exemplo de método para ler entrada do usuário
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        //Exibir o nome digitado pelo user
        Console.WriteLine($"Olá {nome}");
    }
}