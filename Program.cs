
using System.Globalization;
using propriedadesCsharp.Model;
using Newtonsoft.Json;

String conteudoArquvo = File.ReadAllText("Arquivos/listaDeVendas.json");
List<VendaDeserializada> listVenda = JsonConvert.DeserializeObject<List<VendaDeserializada>>(conteudoArquvo);
foreach(VendaDeserializada venda in listVenda){
    Console.WriteLine($"Id : {venda.Id}"
    + $"\nProduto: {venda.Produto}"
    + $"\nPreço: {venda.Preco}"
    + $"\nData de Venda: {venda.DataVenda}\n"
            );

}




// List<Venda> listaVenda = new List<Venda>();
// DateTime dataAtual = DateTime.Now;

// Venda venda01 = new Venda(1, "material de escritorio", 25,dataAtual);
// Venda venda02 = new Venda(2, "Software", 110,dataAtual);

// listaVenda.Add(venda01);
// listaVenda.Add(venda02);

// string serealizador = JsonConvert.SerializeObject(listaVenda, Formatting.Indented);

// File.WriteAllText("Arquivos/listaDeVendas.json", serealizador);

// Console.WriteLine(serealizador);

















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhas, QuantidadeDeLinhas) = arquivo.LerArquivos("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//   Console.WriteLine("Quantidade de linhas do arquivo:" + QuantidadeDeLinhas);
//   foreach (String linha in linhas)
//   {
//     Console.WriteLine(linha);
//   }
// }
// else
// {
//   Console.WriteLine("Não foi possivel ler o arquivo");
// }



















// (int id, string nome, string Sobrenome) tupla = (1,"vitor","fernandes");

// Console.WriteLine(tupla);
// Console.WriteLine($"ID: {tupla.id}");
// Console.WriteLine($"Nome: {tupla.nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");

































// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("BA", "Bahia");
// estados.Add("SP", "São Paulo");
// estados.Add("GO", "Goiás");

// foreach (var item in estados)

// {
// Console.WriteLine($"\nChave: {item.Key} \nValor: {item.Value}:");
// }

// estados.Remove("BA");
// estados["SP"] = "São Paulo - Alterado";

// string chave = "BA2";
// Console.WriteLine("Verificando Valor Existente");

// if(estados.ContainsKey(chave)) {Console.WriteLine($"Valor {chave} já exite");}
// else{   Console.WriteLine($"Valor {chave} ainda não existe");}














// Stack<int> pilha = new Stack<int>();

// void imprimePilha(){
// foreach (var item in pilha)
// {
//     Console.WriteLine(item);
// }
// }



// pilha.Push(2);
// pilha.Push(26);
// pilha.Push(8);
// pilha.Push(15);
// pilha.Push(13);
// imprimePilha();


// Console.WriteLine($"O ultimo elemento a ser removido {pilha.Pop()}");
// pilha.Push(55);
// imprimePilha();







// Queue<int> fila = new Queue<int>();

// fila.Enqueue(8);
// fila.Enqueue(33);
// fila.Enqueue(45);
// fila.Enqueue(2);
// fila.Enqueue(89);
// fila.Enqueue(85);
// int contador = 0;
// foreach (var item in fila)

// {

//     Console.WriteLine($"Posição na fila {contador} = {item}");   
//     contador++; 
// }

// for(int i = 0; i <= fila.Count; i++){
// Console.WriteLine($"O item na posição {i} foi removido =  " + fila.Dequeue());
// }
// foreach (var item in fila)

// {
//     Console.WriteLine(item);    
// }
















// new ExemploExcecao().metodo1();







// try
// {
//     String[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

// foreach (String linha in linhas)
// {
//     Console.WriteLine(linha);
// }

// }catch(Exception ex){
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }











// Pessoa p1 = new Pessoa();
// p1.Nome = "Vitor";
// p1.Sobrenome = "Fernandes";
// p1.Idade = 30;

// p1.Apresentar();

// Pessoa p1 = new Pessoa("Vitor", "Fernandes");


// Pessoa p2 = new Pessoa("Paulo","Santos");


// Curso cursoDeArtes = new Curso();
// cursoDeArtes.Nome = "Artes";
// cursoDeArtes.Alunos = new List<Pessoa>();

// cursoDeArtes.AdicionarAlunos(p1);
// cursoDeArtes.AdicionarAlunos(p2);
// cursoDeArtes.ListarAlunos();