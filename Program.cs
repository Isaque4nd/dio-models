using System.Diagnostics.Contracts;
using diomodels.Models;


//Calculadora calc = new Calculadora();


//calc.Somar(10, 3);
//calc.Subtratir(10, 3);
//calc.Multiplicar(10, 3);
//calc.Dividir(10, 3);
//calc.Resto(10, 5);
//calc.Potencia(3, 3);

//calc.Seno(40);
//calc.Conseno(30);
//calc.Tangente(50);
//calc.RaizQuadrada(9);
//int numeroIncremento = 10;

//Console.Write(numeroIncremento);

//Console.WriteLine("\n Incrementando o 10");

//numeroIncremento++;

//Console.WriteLine(numeroIncremento);

//int numeroDecremento = 10;

//Console.Write(numeroDecremento);

//Console.WriteLine("\n Decrementando o 10");

//numeroDecremento--;

//Console.WriteLine(numeroDecremento);


//Pessoa pessoa = new Pessoa();

//pessoa.Nome = "Isaque";
//pessoa.Idade = 21;
//pessoa.Apresentar();

//int numero = 1;

//for(int contador = 0; contador <=10; contador ++) {
//    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//}
//int numero = 1;
//int contador = 0;


//while (contador <= 10)
//{
//  Console.WriteLine($"{contador + 1}º Execução: {numero} x {contador} = {numero * contador}");
//  contador++;
//}

//int soma = 0, numero = 0;

//do
//{
//    Console.WriteLine("Digite um número (0 para parar)");
//    numero = Convert.ToInt32(Console.ReadLine());

//    soma += numero;

//} while(numero != 0);

//Console.WriteLine($"Total da soma dos números digitados é: {soma}");


//string opcao;
//bool exibirMenu = true;

//while(exibirMenu)
//{
//    Console.WriteLine("Digite a sua opção:");
//    Console.WriteLine("1 - Cadastrar usuário");
//    Console.WriteLine("2 - Buscar usuário");
//    Console.WriteLine("3 - Apagar usuário");
//    Console.WriteLine("4 - Fechar");
//
//    opcao = Console.ReadLine();

//    switch(opcao)
//    {
//        case "1":
//            Console.WriteLine("Você selecionou a função de Cadastro");
//            break;
//        
//        case "2":
//            Console.WriteLine("Você selecionou a função de Busca");
//            break;

//        case "3":
//            Console.WriteLine("Você selecionou a função de Apagar");
//            break;

//        case "4":
//            Console.WriteLine("Você selecionou a função de Fechar");
//            exibirMenu = false;
//            break;

//        default:
//            Console.WriteLine("Opção inválida");
//            break;
//    }

//}

//Console.WriteLine("O programa foi finalizado");


int[] arrayInteiros = new int[3];

arrayInteiros[0] = 30;
arrayInteiros[1] = 50;
arrayInteiros[2] = 70;


// Copia os dados de um array já criado e passa para outro
//int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
//Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

Console.WriteLine("Percorrendo array com o FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
}

//aumenta o tamanhodo array copiando os parametrs já criados no array inicial
// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

Console.WriteLine("Percorrendo array com o FOREACH");

int contadorForeach = 0;
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
    contadorForeach++;
}

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);