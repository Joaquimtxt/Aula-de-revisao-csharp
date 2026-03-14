internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");



        //Declarando variáveis
        int idade = 25; //Var do tipo inteiro

        string nome = "Joaquim";

        double altura = 1.75;

        bool estudante = true;

        Console.WriteLine("Nome: " + nome);

        //Interpolação
        Console.WriteLine($"Nome: {nome}, Idade:{idade}, Altura:{altura}, Estudante? {estudante}");

        //Operadores aritméticos(+, -, *, /, %)
        int a = 10;
        int b = 2;

        int soma = a + b;//12
        int subtracao = a - b;//8
        int multiplicacao = a * b;//20
        int divisao = a / b;//5
        int resto = a % b;//0

        //Operadores de comparação (==, !=, >, <, >=, <=)
        bool igual = (a == b); //false
        bool diferente = (a != b);//true
        bool maior = (a > b); //true
        bool menor = (a < b);// false
        bool maiorOuIgual = (a >= b);//true
        bool menorOuIgual = (a <= b); //false

        //Operadores lógicos(&&, ||, !)
        int idadePessoa = 20;
        string sexoPessoa = "Feminino";

        bool alistar = (sexoPessoa == "Masculino") && (idadePessoa >= 18); //false

        Console.WriteLine($"A pessoa está apta para o alistamento? {alistar} ");

        //Exemplo uso operador lógico NOT (!)
        //Verifiar se a pessoa não é do sexo feminino
        sexoPessoa = "Masculino";
        bool feminino = !(sexoPessoa == "Feminino");
        Console.WriteLine($"A pessoa é diferente do sexo feminino? {feminino} ");


        //If else
        /* Sintaxe:
         if(){
        } else
        {
        }
         */
        int Idade = 20;
        if (Idade >= 18)
        {
            Console.WriteLine("Maior de Idade");
        }
        else
        {
            Console.WriteLine("Menor de Idade");
        }


        //Verificar faixa etária
        idade = 26;
        if (idade >= 18)
        {
            Console.WriteLine("Adulto");
        }
        else if (idade >= 13)
        {
            Console.WriteLine("Adolescente");
        }
        else if (idade < 0)
        {
            Console.WriteLine("Insira uma idade válida!");
        }
        else
        {
            Console.WriteLine("Criança");
        }

        //Estrutura switch-case
        //Verificar dia da semana com base em número
        int diasSemana = 7;
        switch (diasSemana)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda-feira");
                break;
            case 3:
                Console.WriteLine("Terça-feira");
                break;
            case 4:
                Console.WriteLine("Quarta-feira");
                break;
            case 5:
                Console.WriteLine("Quinta-feira");
                break;
            case 6:
                Console.WriteLine("Sexta-feira");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Número inválido, é para ser um número de 1 a 7");
                break;

        }

        //Laços de repetição
        //Laço while
        int contador = 1;

        while (contador <= 10)
        {
            Console.WriteLine($"Contador: {contador}");
            contador++;
        }

        //do while
        contador = 0;
        do
        {
            Console.WriteLine($"Contador: {contador}");
            contador = contador + 1;
        }
        while (contador <= 10);

        //for
        for (int cont = 0; cont < 10; cont++)
        {
            Console.WriteLine($"Contador: {cont}");
        }


        //Estrutura foreach
        //Criando um array de strings
        string[] frutas = { "Maçã", "Banana", "Laranja", "Uva" };

        foreach (string fruta in frutas)
        {
            Console.WriteLine($"Fruta: {fruta}");
        }

        //Chamando os métodos
        int num1 = 5;
        int num2 = 10;
        Console.WriteLine($"A soma de {num1}+{num2} é: {Somar(num1, num2)}");

    }
    //Métodos

    //Exemplo de método para calcular a soma de dois números
    static int Somar(int a, int b)
    {
        return a + b;
    }

}
