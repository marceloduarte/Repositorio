using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace MetodosExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string texto = "marcelo duarte de ávila";
            
            int numeroPalavras = texto.ContaPalavras();
            Console.WriteLine($"O texto possui {numeroPalavras} palavras");

            texto = texto.CaixaAltaPrimeiraLetra();
            Console.WriteLine(texto);

            //método de extensão EMaiorQue
            int numero = 10;
            bool resultado = numero.EMaiorQue(21);
            Console.WriteLine($"O numero {numero} é maior que 21 ? " + resultado);


            Console.WriteLine("Quantidade = 4, Preço =  1000,  Desconto = 50");
            CalculaPreco valor = new CalculaPreco();
            int precoSemDesconto = valor.PrecoTotal(4, 1000);
            int precoComDesconto = valor.PrecoFinalComDesconto(4, 1000, 50);
            Console.WriteLine($"Preço sem desconto       : {precoSemDesconto}");
            Console.WriteLine($"Preco com desconto de 50 : {precoComDesconto}");

 //generic list
        List<int> ListGeneric = new List<int> { 5, 9, 1, 4 };
        //non-generic list
        ArrayList ListNonGeneric = new ArrayList { 5, 9, 1, 4 };
        // timer for generic list sort
        Stopwatch s = Stopwatch.StartNew();
        ListGeneric.Sort();
        s.Stop();
        Console.WriteLine($"Generic Sort: {ListGeneric}  \n Time taken: {s.Elapsed.TotalMilliseconds}ms");

        //timer for non-generic list sort
        Stopwatch s2 = Stopwatch.StartNew();
        ListNonGeneric.Sort();
        s2.Stop();
        Console.WriteLine($"Non-Generic Sort: {ListNonGeneric}  \n Time taken: {s2.Elapsed.TotalMilliseconds}ms");
        Console.ReadLine();

            Console.ReadKey();
        }
    }


    public static class MetodosExtensao
    {
        public static string CaixaAltaPrimeiraLetra(this string valor)
        {
            // Põe a primeira letra em caixa alta
            if (valor.Length > 0)
            {
                char[] array = valor.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return valor;
        }

        public static int ContaPalavras(this String texto)
        {
            //conta quantas palavras exite na string
            return texto.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        //método com dois parâmetros
        //como o método vai operar sobre inteiros 
        //o primeiro parametro deve ser um int
        public static bool EMaiorQue(this int i, int valor)
        {
            return i > valor;
        }
       public static int PrecoFinalComDesconto(this CalculaPreco obj, int quantidade, int custo, int desconto )
        {
            // calcula o preco com desconto
            return (quantidade * custo) * desconto;
        }

    }

    public class CalculaPreco
    {
        public int PrecoTotal(int quantidade, int Custo)
        {
            return quantidade * Custo;
        }
    }

}
