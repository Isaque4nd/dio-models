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

int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while(numero != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}");