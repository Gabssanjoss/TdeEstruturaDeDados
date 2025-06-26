//Dictionary<int, string> alunos = new Dictionary<int, string>();

//adicionar elementos

//alunos.Add(1, "Lucas");
//alunos.Add(2, "Gabss");
//alunos.Add(3, "Luan");

//acessar elementos
//Console.WriteLine(alunos[1]); //Lucas

//interar os elementos
//foreach (var aluno in alunos)
//{

//    Console.WriteLine($"ID: {aluno.Key}, Nome: {aluno.Value} ");

//}

//Queue<string> filaAtendimento = new Queue<string>();

//adicionando pessoas na fila
//filaAtendimento.Enqueue("Tais");
//filaAtendimento.Enqueue("Darlan");
//filaAtendimento.Enqueue("Matheus");

//atendimento
//Console.WriteLine($"{filaAtendimento.Dequeue()}");

//pilha

//Stack<int> pilhasNumeros = new Stack<int>();

//empilhar numeros
//pilhasNumeros.Push(10);
//pilhasNumeros.Push(20);
//pilhasNumeros.Push(30);

//desempilhar
//Console.WriteLine(pilhasNumeros.Pop()); //30

//lista
//List<int> numeros = new List<int> { 5, 2, 3, 4, 1 };

//filtrando numeros maior que tres
//var maioresQueTres = numeros.Where(n => n > 3);

//ordenar lista
//var numerosOrdenados = numeros.OrderBy(n => n);

//seleciona o primeiro número
//var primeiroNumero = numeros.FirstOrDefault();

//Console.WriteLine(string.Join(",", maioresQueTres));
//Console.WriteLine(string.Join(", ", numerosOrdenados));
//Console.WriteLine($"Primeiro Número: {primeiroNumero}");


//EXERCICIO 1
List<Aluno> alunosLista = new List<Aluno>
{
    new Aluno {Nome = "Gabss", Nota = 10},
    new Aluno {Nome = "Darlan", Nota = 8},
    new Aluno {Nome = "Matheus", Nota = 9}
};

var aprovados = alunosLista.Where(a => a.Nota >= 7.0)
.OrderBy(a => a.Nome)
.Select(a => a.Nome);

Console.WriteLine("Alunos Aprovados:");

foreach (var nome in aprovados)
{
    Console.WriteLine(nome);
}


//EXERCICIO 2
Queue<string> filaDeAtendimento = new Queue<string>();

        filaDeAtendimento.Enqueue("Lucas");
        filaDeAtendimento.Enqueue("Carla");
        filaDeAtendimento.Enqueue("João");
        filaDeAtendimento.Enqueue("Marcos");
        filaDeAtendimento.Enqueue("Juliana");

        Console.WriteLine("Iniciando atendimento:");

        while (filaDeAtendimento.Count > 0)
        {
            string cliente = filaDeAtendimento.Dequeue();
            Console.WriteLine($"Atendendo cliente: {cliente}");
        }

        Console.WriteLine("Atendimento encerrado.");
    