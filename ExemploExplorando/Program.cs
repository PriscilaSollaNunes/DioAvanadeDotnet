using ExemploExplorando.Models;

Pessoa p1= new Pessoa("Priscila", "Solla Nunes");
Pessoa p2= new Pessoa("Alex Sandro", "Murador Nunes");

Curso cursoDeingles = new Curso();
cursoDeingles.Nome = "Inglês";
cursoDeingles.Alunos = new List<Pessoa>();

cursoDeingles.AdicionarAluno(p1);
cursoDeingles.AdicionarAluno(p2);
cursoDeingles.ListarAlunos();

































// Pessoa p1= new Pessoa();
// p1.Nome = "Priscila";
// p1.Sobrenome = "Solla Nunes";
// p1.Idade = 41;
// p1.Apresentar();


