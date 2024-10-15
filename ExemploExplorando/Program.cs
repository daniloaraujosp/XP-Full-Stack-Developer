using ExemploExplorando.Models;
using System.Globalization;

new ExemploExcecao().Metodo1();



























/*
try {

    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }

} 
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreuum erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreuum erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui");
}
*/
























/*
//DateTime data = DateTime.Now;

string dataString = "2022-04-170 18:00";

bool sucesso = DateTime.TryParseExact(dataString, 
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, 
                        out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}

// DateTime data = DateTime.Parse(dataString);

//DateTime data = DateTime.Parse("14/04/2022 18:00"); //Data fixa

//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
//Console.WriteLine(data.ToShortDateString()); // somente a data
//Console.WriteLine(data.ToShortTimeString()); // somente a hora

//Console.WriteLine(data);
*/
























/*
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;

//Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(valorMonetario.ToString("N2"));

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));
*/































/*
int numero1 = 10;
int numero2 = 20;

int resultado = numero1 + numero2;

Console.WriteLine(resultado);
*/


































/*
Pessoa p1 = new Pessoa(nome: "Danilo", sobrenome: "Araujo");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();





//p1.Idade = 40;
//p1._nome = ""; 

//p1.Apresentar();
*/