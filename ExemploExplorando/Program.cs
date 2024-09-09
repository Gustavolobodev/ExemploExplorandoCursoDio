using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Gustavo", sobrenome: "Lobo");
Pessoa p2 = new Pessoa(nome: "Louise", sobrenome: "Costa Lobo");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAlunos(p1);
cursoDeIngles.AdicionarAlunos(p2);
cursoDeIngles.ListarAlunos();































// Pessoa p1 = new Pessoa();
// p1.Nome =  "Gustavo";
// p1.Sobrenome = "Lobo";
// p1.Idade = 27;
// p1.Apresentar();