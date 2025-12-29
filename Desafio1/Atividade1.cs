using System;

namespace Desafio
{
    public class Atividade1
    {
        public static void Executar()
        {
            Console.Write("Qual seu nome? ");
            string name = Console.ReadLine();

            Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
        }
    }
}
