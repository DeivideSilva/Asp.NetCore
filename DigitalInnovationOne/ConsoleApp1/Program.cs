using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pilha = new Pilha();
            pilha.Empilhar(1);
            pilha.Empilhar(10);
            pilha.Empilhar(100);
            Console.WriteLine(pilha.Desempilhar());
            Console.WriteLine(pilha.Desempilhar());
            Console.WriteLine(pilha.Desempilhar());


            //int[] a = new int[10];

            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = i * i;
            //    Console.WriteLine($"a[{i}] = [a{i}]");
            //}
        }
    }
}
