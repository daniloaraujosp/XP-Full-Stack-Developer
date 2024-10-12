using ExemploExplorando.Models;


Pessoa p1 = new Pessoa();
p1.Nome = "Danilo";
p1.Sobrenome = "Araujo";

Pessoa p2 = new Pessoa();
p2.Nome = "Eduardo";
p2.Sobrenome = "Neves Queiroz";


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();





//p1.Idade = 40;
//p1._nome = ""; 

//p1.Apresentar();
