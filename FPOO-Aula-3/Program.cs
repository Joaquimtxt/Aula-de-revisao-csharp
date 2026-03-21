
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com Collections");

        //List
        //Criando uma Lista de strings
        List<string> frutas = new List<string>();

        //Adicionando elementos
        frutas.Add("Maçã");
        frutas.Add("Banana Nanica");
        frutas.Add("Morango");

        //Acessar elemento por índice
        Console.WriteLine($"A primeira fruta da lista é {frutas[0]}");

        //Alterando o elemento por Índice
        frutas[1] = "Maracujá";

        //Verificando o tamanho (qtd) da lista
        Console.WriteLine($"Total de frutas: {frutas.Count}");

        //Remover a fruta da lista
        frutas.Remove("Morango");

        //Imprimindo todos os itens da Lista
        foreach (var fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
        Console.WriteLine("============================================================================");
        // 2. DICTIONARY
        // Criando uma dicionario<Chave, Valor>
        Dictionary<string, double> notas = new Dictionary<string, double>();

        // Adicionar Dados ao dicionario
        notas.Add("Ana", 9.5);
        notas.Add("Carlos", 7.0);
        notas.Add("Marcos", 4.5);
        notas["João"] = 2.7;

        // Acessar um elemento pelo indice
        Console.WriteLine($"A nota da Ana é: {notas["Ana"]}");

        // Verificando se a chave existe no dicionario (importante para evitarmos erros)
        if (!notas.ContainsKey("José"))
        {
            Console.WriteLine("O Nome NÃO está sistema");
        }

        // Percorrendo um dicionario
        Console.WriteLine("\nBoletim Escolar");
        foreach (KeyValuePair<string, double> aluno in notas)
        {
            Console.WriteLine($"Aluno:{aluno.Key} | Nota: {aluno.Value}");
        }

        //Queue
        //Criando uma fila de documentos (string)
        Queue<string> documentos = new Queue<string>();

        //Enfileirando itens (Enqueue)
        documentos.Enqueue("Relatorio_final.pdf");
        documentos.Enqueue("Foto_Aluno.jpg");
        documentos.Enqueue("Declaracao_Matricula.docx");

        //Mostrar o próximo elemento da fila
        Console.WriteLine($"Próximo documento vai ser o: {documentos.Peek()}");

        //Desenfileirando documento da fila (Dequeue)
        Console.WriteLine($"Baixado o documento {documentos.Peek()}");
        documentos.Dequeue();//Remove o primeiro elemento

        //Contar elementos da lista
        Console.WriteLine("");

        //Percorrendo todos os documentos da fila
        foreach (string doc in documentos)
        {
            Console.WriteLine(doc);
        }

        //Stack (Último a entrar, primeiro a sair)
        //Criando pilha de favoritos
        Stack<string> favoritos = new Stack<string>();

        //Empilhando itens
        favoritos.Push("www.google.com");
        favoritos.Push("www.github.com/Joaquimtxt");
        favoritos.Push("www.microsoft.com");

        //Mostrar o primeiro elemento da lista
        Console.WriteLine($"O primeiro da lista é: {favoritos.Peek()}");

        //Desempilhar (remover) item da pilha
        favoritos.Pop();

        foreach (string site in favoritos)
        {
            Console.WriteLine(site);
        }
        favoritos.Clear();






    }
}