using System.Globalization;
using ExemploExplorando.Models;
using Newtonsoft.Json;



Venda v1 = new(1, "Material de escritório", 25.00M);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);


Console.WriteLine(serializado);































// INTRODUÇÃO DICTIONARY


// Dictionary<string,string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["Minas Gerais"]);

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("<------------------>");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// VERIFICANDO SE A CHAVE JA EXISTE

// string chave = "BA2";

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: ");
// }
// else{
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }














// EXPLORANDO STACK(PILHA)

// Stack<int> pilha = new();

// pilha.Push(4); // Insere um objeto no topo da pilha
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}"); // Remove e retorna o objeto para o topo da pilha

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

















// EXPLORANDO QUEUE(FILA)

// Queue<int> fila = new();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {   
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {   
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

















// new ExemploExcecao().Metodo1();

























// TRATANDO UMA EXCEÇÃO

// try
// {

// string [] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

// foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado.{ex.Message}");
// }
// catch(Exception ex) // EXCEÇÃO GENÉRICA
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }

// BLOCO FINALLY
// finally
// {
//     Console.WriteLine("Chegou até aqui");    
// }




// FORMATANDO DATETIME

// USANDO TryParseExact

// string dataString = "2024-09-17 21:00";

// bool sucesso = DateTime.TryParseExact(dataString,
//                                     "yyyy-MM-dd HH:mm",
//                                     CultureInfo.InvariantCulture,
//                                     DateTimeStyles.None,
//                                      out DateTime data);

// VALIDANDO O TryParse

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }

// Console.WriteLine(data);

// OBTEM DATA E HORA ATUAL 

// DateTime data = DateTime.Now;

// CONVERTENDO UMA STRING PARA O DATETIME

// DateTime data = DateTime.Parse("11/09/2024 21:07");

// Console.WriteLine(data);

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// REMOVE A HORA, MOSTRANDO APENAS A DATA

// Console.WriteLine(data.ToShortDateString());

// REMOVE A DATA, MOSTRANDO APENAS A HORA

// Console.WriteLine(data.ToShortTimeString());



// FORMANTANDO A CULTURA DO SISTEMA.
// using System.Globalization;

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");



// decimal valorMonetario = 1582.40M;
// OUTRA FORMA FORMATAR A CULTURA DO SISTEMA
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// Console.WriteLine(valorMonetario.ToString("C2")); // FORMATANDO A QUANTIDADE DE CASAS DECIMAIS

// Console.WriteLine($"{valorMonetario:C}");

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("p"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));










// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);







// Pessoa p1 = new Pessoa(nome: "Gustavo", sobrenome: "Lobo");
// Pessoa p2 = new Pessoa(nome: "Louise", sobrenome: "Costa Lobo");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAlunos(p1);
// cursoDeIngles.AdicionarAlunos(p2);
// cursoDeIngles.ListarAlunos();































// Pessoa p1 = new Pessoa();
// p1.Nome =  "Gustavo";
// p1.Sobrenome = "Lobo";
// p1.Idade = 27;
// p1.Apresentar();