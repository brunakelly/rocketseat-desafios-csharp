using System;

namespace Desafio
{
    public class Atividade2
    {
        public static void Executar()
        {
            Console.Write("Qual seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual seu sobrenome? ");
            string sobrenome = Console.ReadLine();

            string nomeCompleto = $"{nome} {sobrenome}";

            Console.WriteLine($"Seu nome completo é: {nomeCompleto}");
        }
    }
}
