using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemplosFundamentos.Common.Models;

// // Listas:
// // Listas são mais práticas e fáceis de se trabalhar, pois trabalha de forma sistemática com um 'Array' internamente, e nos tira algumas
// //      responsabilidades para gerenciar o array

// List<string> listaCompras = new List<string>();
// listaCompras.Add("Sal");
// listaCompras.Add("Açúcar");
// listaCompras.Add("Feijão");
// listaCompras.Add("Leite");

// Console.WriteLine($"Itens na lista: {listaCompras.Count} - Capacidade: {listaCompras.Capacity}");
// // 'Count' é um método da parte das listas em que conta todos os elementos que existem dentro dela e mostra a quantidade
// // 'Capacity' é um método que mostra a quantidade máxima de elementos que podem ser colocados na lista (mas aumentam automaticamente)
// Console.WriteLine("");

// listaCompras.Add("Suco");

// Console.WriteLine($"Itens na lista: {listaCompras.Count} - Capacidade: {listaCompras.Capacity}");
// Console.WriteLine("");

// listaCompras.Remove("Leite");

// Console.WriteLine($"Itens na lista: {listaCompras.Count} - Capacidade: {listaCompras.Capacity}");
// Console.WriteLine("");

// listaCompras.Add("Banana");
// listaCompras.Add("Maçã");
// listaCompras.Add("Maracujá");

// Console.WriteLine($"Itens na lista: {listaCompras.Count} - Capacidade: {listaCompras.Capacity}");
// Console.WriteLine("");

// listaCompras.Add("Alface");
// listaCompras.Add("Tomate");

// Console.WriteLine($"Itens na lista: {listaCompras.Count} - Capacidade: {listaCompras.Capacity}");
// Console.WriteLine("");

// for(int i = 0; i < listaCompras.Count; i++)
// {
//     Console.WriteLine($"Posição Nº {i} - {listaCompras[i]}");
// }

// int i2 = 0;
// foreach (string item in listaCompras)
// {
//     Console.WriteLine($"Posição Nº {i2} - {item}");
//     i2++;
// }

// ----------------------------------------------------------------------------------------------------------------------------- //

// // Arrays:

// int[] arrayInteiros = new int [3];
/*
    Colocar '[]' na frente de um tipo de variavel, define que esta será um array (lista)
    O '[3]' no final do código ali indica que este array terá 3 vagas para elementos (no caso, inteiros)
*/
// arrayInteiros [0] = 1;
// // nomeDaArray [Índice] = Valor;
// arrayInteiros [1] = 2;
// // nomeDaArray [Índice] = Valor;
// arrayInteiros [2] = 3;
// // nomeDaArray [Índice] = Valor;
/*
    Indicar o nome da lista (array), a posição (índice) nela, e o valor que voce quer adicionar (ou mudar), voce insere o valor na variavel
    ISabendo que as posiçoes dos arrays começam com a numeraçao '0', esta tem a contagem até o numero '2'
*/
// Console.WriteLine("Percorrendo o Array com 'FOR': \n");

// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     Console.WriteLine($"Posição Nº {i} - {arrayInteiros[i]}");
//     Console.WriteLine("      Índice - Valor\n");
// }

// Console.WriteLine("Percorrendo o Array com 'FOREACH': \n");

// // Para usar em ARRAYS especificamente, e que NÃO SEJA OBRIGATÓRIO definir uma CONDIÇÃO DE PARADA, o 'FOREACH' é mais simples 
// int contador = 0;
// foreach(int valor in arrayInteiros)
// {
//     contador++;
//     Console.WriteLine($"Posição Nº {contador} - {valor}");
// }
// // Resumindo: para cada (elemento dentro da Array)
// // {
//     // Mostre-me (cada elemento)
// // }

// // Redimensionando uma Array:

// int[] arrayInteirosDobrado = new int [arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// foreach (int valorDobrado in arrayInteirosDobrado)
// {
//     Console.WriteLine(valorDobrado);
// }

// ----------------------------------------------------------------------------------------------------------------------------- //

    // Montando um menu:
    string? opcao;
    bool mostrarMenu = true;
    Console.WriteLine($"Bem-vindos ao menu feito em C#");

while(mostrarMenu)
{
    Console.WriteLine("1- Curso de Java");
    Console.WriteLine("2- Curso de .NET");
    Console.WriteLine("3- Curso de Android Studio");
    Console.WriteLine("4- Curso de Unity 3D");
    Console.WriteLine("5- Encerrar");
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1": 
            Console.WriteLine("CLIQUE NO LINK: https://web.dio.me/track/formacao-java-developer");
            break;
        case "2": 
            Console.WriteLine("CLIQUE NO LINK: https://web.dio.me/track/formacao-dotnet-developer");
            break;
        case "3": 
            Console.WriteLine("CLIQUE NO LINK: https://web.dio.me/track/formacao-android-developer");
            break;
        case "4": 
            Console.WriteLine("CLIQUE NO LINK: https://web.dio.me/track/formacao-unity-3d-game-developer");
            break;
        case "5":
            Console.WriteLine("Encerrando");
            mostrarMenu = false;
            break;
    }
}

// ----------------------------------------------------------------------------------------------------------------------------- //

// Loop com 'DO WHILE':

// int soma = 0, numero = 0;

// do
// {
    
//     Console.Write("Digite um número: ");
//     numero = Convert.ToInt32(Console.ReadLine());
//     // soma = soma + numero;
//     soma+= numero;
    
// }while(numero != 0);

// Console.WriteLine($"Soma total: {soma}");

// ----------------------------------------------------------------------------------------------------------------------------- //

// Loop com 'WHILE':

// int numero = 3;
// int contador = 0;
// short auxiliar = 1;

// // while(true)
// while (numero > contador)
// {
//     Console.WriteLine($"Execução {auxiliar}º: {numero} x {contador} = {numero * contador}");
//     contador++;
//     auxiliar++;

//     if (contador == 2)
//     {
//         break;
//     }
// }

// ----------------------------------------------------------------------------------------------------------------------------- //

// Loop com 'FOR':

// int numero = 10;
// for (int con=0; con<=10; con++)
/*
    no 'FOR' em C#, diferente de python, temos que declarar 3 parametros para que ele funcione
    e sao eles:
            1- ex.:'int con=0;': esta é a declaração da VARIÁVEL do contador ('con'). Cria a VARIÁVEL começando, no caso, em '0';
            2- ex.:'con<=10;': esta é a CONDIÇÃO de PARADA, se define qual será o numero de vezes que o 'FOR' irá fazer o loop;
            3- ex.:'con++': este é o INCREMENTADOR, que adiciona '+1' para o contador, que fica contando até chegar na CONDIÇÃO.
    Em uma explicação resumida: definimos o contador com o valor zero (1-), e a cada loop ele acrescenta +1 (2-) até atingir a condição (3-).
*/
// {
//     Console.WriteLine($"{numero} x {con} = {numero * con}");
// }

// ----------------------------------------------------------------------------------------------------------------------------- //

// Incrementação e Decrementação:

// int numero = 10;
// Console.WriteLine($"Numero sem incrementação: {numero}");
// numero++;
// Console.WriteLine($"Numero com incrementação: {numero}");
// int numero1 = 10;
// numero1--;
// Console.WriteLine($"Numero com decrementação: {numero1}");

// ----------------------------------------------------------------------------------------------------------------------------- //

// Calculadora calc = new Calculadora();

// calc.Somar(10, 20);
// calc.Subtrair(35, 50);
// calc.Multiplicar(10, 30);
// calc.Dividir(22, 4);
// calc.Potencia(3, 3);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.Seno(30);

// Para arredondar/simplificar as casas decimais de um resultado, usa-se o '{Math.Round (parametro, numero de decimais)}'

// ----------------------------------------------------------------------------------------------------------------------------- //

// // Usando NOT ('!'):

// bool choveu = true;
// bool estaTarde = true;

// // Colocando um '!' na frente de cada variavel nos parametros de 'IF', 'SWITCH', etc, ele inverte os valores da variavel
// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Não pode sair.");
// }
// else
// {
//     Console.WriteLine("Pode passear.");
// }

// ----------------------------------------------------------------------------------------------------------------------------- //

// // Usando 'And'/'E':

// bool presencaMinima = true;
// double media = 7.5;

// if (presencaMinima && media >= 6)
// {
//     Console.WriteLine("Aprovado.");
// }
// else
// {
//     Console.WriteLine("Reprovado.");
// }

// ----------------------------------------------------------------------------------------------------------------------------- //

// // Usando 'Or'/'Ou'/'Pipe':

// bool maiorDeIdade = false;
// bool acompanhamentoResponsavel = false;

// if (maiorDeIdade || acompanhamentoResponsavel)
// {
//     Console.WriteLine("Entrada Aceita.");
// }
// else
// {
//     Console.WriteLine("Entrada Recusada.");
// }

// ----------------------------------------------------------------------------------------------------------------------------- //

// // Switch Case:

// Console.Write("Digite uma letra (usando '|| (Pipe)' / 'ou'): ");
// string? letra = Console.ReadLine(); 

// // Usa-se o '?' ao lado do tipo "string" quando sabemos que pode ser uma variável anulável (ou não)
// // Ou seja, quando uma variável pode ou não conter um valor

// if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u"){
//     Console.WriteLine("É uma vogal.");
// }
// else
// {
//     Console.WriteLine("Não é vogal.");
// }

// Console.Write("Digite uma letra (usando 'switch case'): ");
// string? letra1 = Console.ReadLine();

// // Selecionamos dentro do parenteces a lista ou valor que desejamos comparar com os casos que colocaremos logo abaixo
// switch (letra1)
// {
//     // Em seguida, colocamos os casos que vamos colocar de paremetro a ser seguido
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal.");
//         break;
//     // O 'default' é o 'else' do 'switch' que seria o 'if'
//     default:
//         Console.WriteLine("Não é vogal.");
//         break;;
//         // Por se tratar de um segundo 'break' dentro de um escopo, deve-se ter dois ';'
// }

// ----------------------------------------------------------------------------------------------------------------------------- //

// // Simulação de um caixa de venda de um e-commerce:
// double quantidadeEmEstoque = 50;
// double quantidadeCompra = 110;
// // Variável booleana
// bool vendaValida = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine("Quantidade em estoque: " + quantidadeEmEstoque);
// Console.WriteLine("Quantidade desejada de compra: " + quantidadeCompra);
// Console.WriteLine($"É possível realizar está compra? {vendaValida}");

// ----------------------------------------------------------------------------------------------------------------------------- //

// // Operador Condicional:
// //if (quantidadeEmEstoque >= quantidadeCompra)
// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda Inválida.");
// }
// else if (vendaValida)
// {
//     Console.WriteLine("Venda Realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada no estoque.");
// }

// ----------------------------------------------------------------------------------------------------------------------------- //

// Usando a data da máquina que está rodando o código:
// DateTime dataAtual = DateTime.Now;
// Console.WriteLine("Data Atual: " + dataAtual);

// dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine("Data Atual: " + dataAtual);

// dataAtual = DateTime.Now;
// Console.WriteLine("Data Atual: " + dataAtual.ToString("dd/MM/yy"));

// ----------------------------------------------------------------------------------------------------------------------------- //

// Tipos de dados:
// string apresentacao = "Ola, seja bem-vindo";
// int quantidade = 1;
// quantidade = 10;
// double altura = 1.80; //double sempre tenta utilizar o minimo de casa decimal possivel; ruim para valores monetarios
// decimal  preco = 1.80M; //mostra no terminal sempre o valor completo; bom para valores monetarios; precisa do 'M' para validar valores
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine($"Valor de 'quantidade': {quantidade}");
// Console.WriteLine($"Valor de 'altura': {altura}");
// Console.WriteLine("Valor de 'preco': " + preco);
// Console.WriteLine("Valor booleana: " + condicao);

// ----------------------------------------------------------------------------------------------------------------------------- //

// / Variáveis:

// // Instancia da classe 'Pessoa':
// Pessoa p = new();

// // Atribui o nome e a idade da pessoa:
// Console.WriteLine("Digite seu nome: ");
// p.Nome = Console.ReadLine();
// Console.WriteLine("Digite sua idade: ");
// p.Idade = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite seu e-mail: ");
// p.Email = Console.ReadLine();
// Console.WriteLine("Digite seu endereço: ");
// p.Endereço = Console.ReadLine();

// // Mostra a apresentação da classe 'Pessoa':
// p.Apresentar();

// ============================================================================================================================ //