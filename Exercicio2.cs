using System;

public class AdicionarNumeros
{
    public static void Main(string[] args)
    {
        // Declara duas variáveis para armazenar os números a serem somados
        int numero1, numero2;

        // Lê os números do teclado
        Console.WriteLine("Digite o primeiro número: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        numero2 = int.Parse(Console.ReadLine());

        // Adiciona os números
        int soma = numero1 + numero2;

        // Imprime a soma na tela
        Console.WriteLine("A soma dos números é: {0}", soma);
    }
}


 /* 
 Exercício 2: Adicionar dois números

Objetivo: O objetivo deste exercício é aprender a adicionar dois números.
*/.