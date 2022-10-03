using PropMetCons.Model;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Vitor";
// p1.Sobrenome = "Fernandes";
// p1.Idade = 30;

// p1.Apresentar();

Pessoa p1 = new Pessoa("Vitor", "Fernandes");


Pessoa p2 = new Pessoa("Paulo","Santos");


Curso cursoDeArtes = new Curso();
cursoDeArtes.Nome = "Artes";
cursoDeArtes.Alunos = new List<Pessoa>();

cursoDeArtes.AdicionarAlunos(p1);
cursoDeArtes.AdicionarAlunos(p2);
cursoDeArtes.ListarAlunos();