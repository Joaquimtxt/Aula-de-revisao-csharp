using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

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

        //Instanciar um objeto da classe carro
        Carro meuCarro = new Carro(); //Criar um novo obj. do tipo Carro sem infos. inicializadas

        //Atribuir valores aos atributos do obj. carro
        meuCarro.Marca = "Toyota";
        meuCarro.Modelo = "Corolla";
        meuCarro.Ano = 2020;


        Carro novoCarro = new Carro();
        novoCarro.Marca = "Chevrolet";
        novoCarro.Modelo = "Celta";
        novoCarro.Ano = 2005;

        //Exibir as infos dos carros usando método
        meuCarro.ExibirInformacoes();
        novoCarro.ExibirInformacoes();

        //Ligar o Carro
        meuCarro.Ligar();
        novoCarro.Ligar();

        //Criar um objeto do tip Carro utilizando sintaxe de inicialização de objetos
        Carro carroInicializado = new Carro();
        {
            carroInicializado.Marca = "Honda";
            carroInicializado.Modelo = "Civic";
            carroInicializado.Ano = 2019;
        }

        ContaBancaria conta = new ContaBancaria();
        //conta.Saldo = 1000; // Não dá certo pq o atributo é private
        conta.Depositar(200);
        /****************/

        Acessorio carroTeste = new Acessorio(); // Declaração do Objeto
        carroTeste.Marca = "Volkswagen"; // Atributos da classe Mae (Superclasse)
        carroTeste.Ano = 1966;
        carroTeste.Modelo = "Fusca";

        carroTeste.Portas = 2; // Atributos da classe filha (Subclasse) 
        carroTeste.CambioAutomatico = false;

        carroTeste.ExibirInformacoes(); // Metodo da Classe Mae 

    }
    public class Carro
    {
        // Atributos da classe Carro
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        // Método para exibir as informações do carro
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}"); //Interpolação
            Console.WriteLine($"Ano: {Ano}");
        }
        public void Ligar()
        {
            Console.WriteLine($"O carro de modelo ", Modelo, ", está ligado");
        }
    }
    //Exemplo de encapsulamento: Classe Conta Bancária
    public class ContaBancaria
    {
        //Atributo privado: Ninguém fora da classe pode alterá-lo diretamente
        private double Saldo;

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Depósito de " + valor + " realizado com sucesso!");
        }
    }
    //Exemplo de Herança : A classe Acessorios irá herdar a classe Carro
    public class Acessorio : Carro
    {
        public int Portas;
        public bool CambioAutomatico;

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Número de Portas {Portas}");
            Console.WriteLine($"CambioAutomatico {CambioAutomatico}");

        }

    }
}