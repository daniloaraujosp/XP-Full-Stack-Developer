using ExemploExplorando.Models;
using System.Globalization;

int numero = 21;
bool ehPar = false;

//IF Ternário
ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

/*
if(numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar");
}
*/




























/*
Pessoa p1 = new Pessoa("Danilo", "Araujo");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");
*/




















/*
LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");


if (sucesso)
{
    //Console.WriteLine("Quantidade linhas do arquivo:" + quantidadeLinhas);
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}
*/
















/*
(int, string, string, decimal) tupla = (1, "Danilo", "Araujo", 1.76M);

// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Danilo", "Araujo", 1.76M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Danilo", "Araujo", 1.76M)

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");


*/
























/*
------------------------------------
Dictionary<string, string> estados = new Dictionary<string,string>();


estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

Console.WriteLine(estados["MG"]); // acessar valor do dictionary


/*
foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("-------------");
estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
*/


/*
string chave = "BA2";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave)) 
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existente. É seguro adicionar a chave");
}
*/




















/*
Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

pilha.Push(20);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}
*/




















/*
new ExemploExcecao().Metodo1();

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (var item in fila)
{
    Console.WriteLine(item);    
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); // vai remover sempre o primeiro elemeto da fila
fila.Enqueue(10);

foreach (var item in fila)
{
    Console.WriteLine(item);    
}

*/
















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