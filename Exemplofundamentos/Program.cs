using System.Collections.Concurrent;
using System.Reflection.Metadata;
using Exemplofundamentos.Models;



List <string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

Console.WriteLine("Percorrendo a lista como FOR");
for(int contador = 0; contador < listaString.Count; contador++)
{
     Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
}

Console.WriteLine("Percorrendo a lista como FOREACH");
int contadorForeach = 0;
foreach(string item in listaString)
{
     Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
     contadorForeach++;
}




























// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;



// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// // // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo o Array com o For");

// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//       Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }
















// Console.WriteLine("Percorrendo o Array com o FOREACH");

// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//      Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
//      contadorForeach++;
// }


















// string opcao;
// bool exibirMenu = true;


// while(exibirMenu)
// {
//      Console.Clear();
//      Console.WriteLine("Digite o sua opção:");
//      Console.WriteLine("1- Cadastrar cliente:");
//      Console.WriteLine("2- Buscar cliente:");
//      Console.WriteLine("3- Apagar cliente:");
//      Console.WriteLine("4- Encerrar");

//      opcao = Console.ReadLine();

//      switch(opcao)
//      {
//           case "1":
//                Console.WriteLine("Cadastro de cliente");
//                break;

//           case "2":
//                Console.WriteLine("Buscar cliente");
//                break;

//           case "3":
//                Console.WriteLine("Apagar cliente");
//                break;

//           case "4":
//                Console.WriteLine("Encerrar");
//                exibirMenu = false;
//                break;

//           default:
//                Console.WriteLine("Opção inválida");
//                break;

          
//      }

// }

// Console.WriteLine("O programa se encerrou");















// int soma = 0, numero = 0;

// do
// {
//      Console.WriteLine("Digite um número (o para parar)");
//      numero = Convert.ToInt32(Console.ReadLine());

//      soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total da soma dos númerosdigitados é: {soma}");



















// int numero = 5;
// int contador = 1;


// while (contador <= 10)
// {
//      Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//      contador++;

//      if (contador == 6)
//      {
//           break;
//      }
// }








// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//      Console.WriteLine($"{numero} x {contador} = {numero * contador}");

// }



















// Calculadora calc = new Calculadora();
// calc.RaizQuadrada(9);

// // calc.Somar(10, 30);
// // calc.Subtrair(10, 45);
// // calc.Multiplicar(15, 50);
// // calc.Dividir(5, 5);
// // calc.Potencia(3, 3);

// calc.Coseno(30);
// calc.Seno(30);
// calc.Tangente(30);

















// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//      Console.WriteLine("Vou pedalar!");
// }
// else
// {
//      Console.WriteLine("Não vou pedalar");
// }





















// bool PresencaMinima = true;
// double Media = 6;

// if (PresencaMinima && Media >= 7)
// {
//     Console.WriteLine("Aprovada!");
// }
// else
// {
//     Console.WriteLine("Reprovada");
// }





















// bool PresencaMinima = true;
// double Media = 6;

// if (PresencaMinima && Media >= 7)
// {
//    Console.WriteLine("Aprovada!");
// }
// else
// {
//    Console.WriteLine("Reprovada");
// }














// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }






















// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;

// }







// switch (letra)

// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma Vogal");
//         break;
// }






























// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade em estoque.");
// }



















//DateTime dataAtual = DateTime.Now;
//Console.WriteLine(dataAtual);


// Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Priscila";
//pessoa1.Idade = 41;
//pessoa1.Apresentar();
