using ExemploExplorando.Models;


Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP","São Paulo");
estados.Add("BA","Bahia");
estados.Add("MG","Minas Gerais");


foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("---------------------");

estados.Remove("BA");
estados["SP"] = "Osasco";

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}




















// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(10);
// pilha.Push(8);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);


// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

























// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(2);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);    
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }
























//new ExemploExcecoes().Metodo1();



























// Pessoa p1= new Pessoa("Priscila", "Solla Nunes");
// Pessoa p2= new Pessoa("Alex Sandro", "Murador Nunes");

// Curso cursoDeingles = new Curso();
// cursoDeingles.Nome = "Inglês";
// cursoDeingles.Alunos = new List<Pessoa>();

// cursoDeingles.AdicionarAluno(p1);
// cursoDeingles.AdicionarAluno(p2);
// cursoDeingles.ListarAlunos();

































// Pessoa p1= new Pessoa();
// p1.Nome = "Priscila";
// p1.Sobrenome = "Solla Nunes";
// p1.Idade = 41;
// p1.Apresentar();


